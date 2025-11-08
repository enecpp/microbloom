using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using microbloom.Services.Interfaces;
using System.Security.Claims;

namespace microbloom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
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
                    return BadRequest(result.Errors);
                }

                // Varsayılan rol: JobSeeker
                var roleResult = await _userManager.AddToRoleAsync(user, "JobSeeker");
                if (!roleResult.Succeeded)
                {
                    return BadRequest(new { Message = "Rol atanırken hata oluştu.", Errors = roleResult.Errors });
                }

                return Ok(new { Message = "Kullanıcı başarıyla oluşturuldu.", UserId = user.Id });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, isPersistent: true, lockoutOnFailure: false);

                if (!result.Succeeded)
                {
                    return Unauthorized("Giriş bilgileri geçersiz.");
                }

                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                var roles = await _userManager.GetRolesAsync(user!);

                var claims = new Dictionary<string, string>
                {
                    { ClaimTypes.NameIdentifier, user!.Id }
                };
                foreach (var role in roles)
                {
                    claims.Add(ClaimTypes.Role, role);
                }

                var currentUser = new CurrentUser
                {
                    UserName = user.UserName,
                    Claims = claims
                };

                return Ok(new AuthResponseDto { User = currentUser });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
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
                return BadRequest(new { Message = $"Hata: {ex.Message}" });
            }
        }
    }
}