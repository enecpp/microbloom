global using microbloom.Data;
global using microbloom.DTOs;
global using microbloom.Entities;
using microbloom.Services;
using microbloom.Services.Implementations;
using microbloom.Services.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using microbloom;
using System.Text;
using Microsoft.AspNetCore.Http;

// UTF-8 Encoding Support for Emojis
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<KariyerDBContext>(options =>
 options.UseSqlite(connectionString));

builder.Services.AddIdentity<AppUser, IdentityRole>()
 .AddEntityFrameworkStores<KariyerDBContext>()
 .AddDefaultTokenProviders();

// Identity cookie güvenliği
builder.Services.ConfigureApplicationCookie(options =>
{
 options.Cookie.HttpOnly = true;
 options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
 options.Cookie.SameSite = SameSiteMode.Lax;
 options.SlidingExpiration = true;
});

// Antiforgery cookie güvenliği (varsa)
builder.Services.AddAntiforgery(options =>
{
 options.Cookie.HttpOnly = true;
 options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
 options.Cookie.SameSite = SameSiteMode.Lax;
});

// HTTPS yönlendirme ayarları
builder.Services.AddHttpsRedirection(options =>
{
 options.RedirectStatusCode = StatusCodes.Status308PermanentRedirect;
});

// Blazor Authentication
builder.Services.AddScoped<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddCascadingAuthenticationState();

// HttpClient konfigürasyonu
builder.Services.AddScoped(sp => 
{
 var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
 var httpContext = httpContextAccessor.HttpContext;
 var baseAddress = $"{httpContext?.Request.Scheme}://{httpContext?.Request.Host}";
 return new HttpClient { BaseAddress = new Uri(baseAddress) };
});

// HttpContextAccessor
builder.Services.AddHttpContextAccessor();

// Auth Service
builder.Services.AddScoped<IAuthService, AuthService>();

// User Service
builder.Services.AddScoped<IUserService, UserService>();

// Blazor Components
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Controllers ve Services
builder.Services.AddControllers();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Rolleri Seed Et
using (var scope = app.Services.CreateScope())
{
 var services = scope.ServiceProvider;
 try
 {
 var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
 await SeedRolesAsync(roleManager);
 
 await DbSeeder.SeedRolesAndAdminAsync(services);
 }
 catch (Exception ex)
 {
 var logger = services.GetRequiredService<ILogger<Program>>();
 logger.LogError(ex, "Veritabanını tohumlarken bir hata oluştu.");
 }
}

if (app.Environment.IsDevelopment())
{
 app.UseSwagger();
 app.UseSwaggerUI();
 app.UseDeveloperExceptionPage();
}
else
{
 app.UseExceptionHandler("/Error");
 app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Cookie Policy - kimlik doğrulamadan önce olmalı
app.UseCookiePolicy(new CookiePolicyOptions
{
 MinimumSameSitePolicy = SameSiteMode.Lax,
 Secure = CookieSecurePolicy.Always
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

// Rol Seed Fonksiyonu
async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
{
 string[] roleNames = { "JobSeeker", "Employer", "Admin" };

 foreach (var roleName in roleNames)
 {
 var roleExist = await roleManager.RoleExistsAsync(roleName);
 if (!roleExist)
 {
 await roleManager.CreateAsync(new IdentityRole(roleName));
 Console.WriteLine($"✅ Rol oluşturuldu: {roleName}");
 }
 }
}