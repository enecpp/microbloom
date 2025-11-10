using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using microbloom.Data;
using microbloom.Entities;

namespace microbloom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly KariyerDBContext _context;
        private readonly ILogger<AccountController> _logger;

        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            KariyerDBContext context,
            ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
            _logger = logger;
        }

    [HttpPost("register")]
    [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var isCompanyAccount = string.Equals(registerDto.AccountType, "Employer", StringComparison.OrdinalIgnoreCase);
            var accountTypeQuery = $"AccountType={(isCompanyAccount ? "Employer" : "JobSeeker")}";

            if (!ModelState.IsValid)
            {
                var errors = string.Join(" ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return Redirect($"/account/register?{accountTypeQuery}&ErrorMessage={Uri.EscapeDataString(errors)}");
            }

            try
            {
                if (isCompanyAccount && string.IsNullOrWhiteSpace(registerDto.CompanyName))
                {
                    return Redirect($"/account/register?{accountTypeQuery}&ErrorMessage={Uri.EscapeDataString("Şirket kaydı için şirket adı gereklidir.")}");
                }

                var user = new AppUser
                {
                    UserName = registerDto.Email,
                    Email = registerDto.Email,
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName
                };

                var result = await _userManager.CreateAsync(user, registerDto.Password);

                if (!result.Succeeded)
                {
                    var errors = string.Join(" ", result.Errors.Select(e => e.Description));
                    return Redirect($"/account/register?{accountTypeQuery}&ErrorMessage={Uri.EscapeDataString(errors)}");
                }

                var targetRole = isCompanyAccount ? "Employer" : "JobSeeker";
                var roleResult = await _userManager.AddToRoleAsync(user, targetRole);
                if (!roleResult.Succeeded)
                {
                    var errors = string.Join(" ", roleResult.Errors.Select(e => e.Description));
                    return Redirect($"/account/register?{accountTypeQuery}&ErrorMessage={Uri.EscapeDataString("Rol atanırken hata: " + errors)}");
                }

                if (isCompanyAccount)
                {
                    var company = new Company
                    {
                        Name = registerDto.CompanyName!.Trim(),
                        Description = string.IsNullOrWhiteSpace(registerDto.CompanyDescription)
                            ? null
                            : registerDto.CompanyDescription.Trim(),
                        LogoUrl = string.IsNullOrWhiteSpace(registerDto.CompanyLogoUrl)
                            ? null
                            : registerDto.CompanyLogoUrl.Trim()
                    };

                    _context.Companies.Add(company);
                    await _context.SaveChangesAsync();

                    user.CompanyId = company.Id;
                    await _userManager.UpdateAsync(user);
                }

                // Kayıt sonrası otomatik giriş yap
                await _signInManager.SignInAsync(user, isPersistent: false);
        
                _logger.LogInformation("New user registered and logged in: {Email}", user.Email);
                return Redirect(isCompanyAccount ? "/company-dashboard" : "/");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during registration");
                return Redirect($"/account/register?{accountTypeQuery}&ErrorMessage={Uri.EscapeDataString("Kayıt sırasında bir hata oluştu.")}");
            }
        }

    [HttpPost("login")]
    [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto, [FromQuery] string? returnUrl = null)
        {
            var targetUrl = NormalizeReturnUrl(returnUrl);

            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var result = await _signInManager.PasswordSignInAsync(
                loginDto.Email,
                loginDto.Password,
                isPersistent: false,
                lockoutOnFailure: false);

            if (result.Succeeded)
            {
                _logger.LogInformation("User {Email} signed in via API.", loginDto.Email);
                return Ok(new { returnUrl = targetUrl });
            }

            if (result.IsLockedOut)
            {
                _logger.LogWarning("Locked out user {Email} attempted to sign in via API.", loginDto.Email);
                return Unauthorized(new { message = "Hesabınız geçici olarak kilitli. Lütfen daha sonra tekrar deneyin." });
            }

            _logger.LogWarning("Invalid credentials for {Email} via API login.", loginDto.Email);
            return Unauthorized(new { message = "E-posta veya şifre hatalı." });
        }

    [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return Ok(new { Message = "Çıkış başarılı." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Çıkış işlemi sırasında hata oluştu.");
                return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
        }

        // POST: /api/account/promote-to-employer
        [HttpPost("promote-to-employer")]
        [Authorize] // Admin tarafından çağrılabilir
        public async Task<IActionResult> PromoteToEmployer([FromBody] PromoteUserDto promoteDto)
        {
            try
            {
                if (string.IsNullOrEmpty(promoteDto.UserId) || promoteDto.CompanyId <= 0)
                {
                    return BadRequest("UserId ve CompanyId gereklidir.");
                }

                var user = await _userManager.FindByIdAsync(promoteDto.UserId);
                if (user == null)
                {
                    return NotFound("Kullanıcı bulunamadı.");
                }

                // Kullanıcıyı Employer rolüne ekle
                var result = await _userManager.AddToRoleAsync(user, "Employer");
                if (!result.Succeeded)
                {
                    return BadRequest(new { Message = "Rol atanırken hata oluştu.", Errors = result.Errors });
                }

                // CompanyId'yi ata
                user.CompanyId = promoteDto.CompanyId;
                await _userManager.UpdateAsync(user);

                return Ok(new { Message = $"Kullanıcı başarıyla Employer olarak yükseltildi.", UserId = user.Id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Kullanıcıyı işveren olarak terfi ettirme sırasında hata oluştu.");
                return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
        }

        // ✅ YENİ: Test için basit login endpoint
        [HttpGet("test-cookie")]
        public IActionResult TestCookie()
        {
            var isAuthenticated = User?.Identity?.IsAuthenticated ?? false;
            var userName = User?.Identity?.Name ?? "NULL";
            var authType = User?.Identity?.AuthenticationType ?? "NULL";

            return Ok(new
            {
                Message = "Cookie kontrol endpoint'i",
                IsAuthenticated = isAuthenticated,
                UserName = userName,
                AuthenticationType = authType,
                HasIdentityCookie = Request.Cookies.ContainsKey(".AspNetCore.Identity.Application")
            });
        }

        private string NormalizeReturnUrl(string? returnUrl)
        {
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return Url.Content("~/");
            }

            return Url.IsLocalUrl(returnUrl) ? returnUrl : Url.Content("~/");
        }
    }
}