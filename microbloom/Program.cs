global using microbloom.Data;
global using microbloom.DTOs;
global using microbloom.Entities;
using microbloom.Services.Implementations;
using microbloom.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using microbloom;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<KariyerDBContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<KariyerDBContext>();

builder.Services.AddAuthenticationCore();

// HttpClient konfigürasyonu
builder.Services.AddScoped(sp => 
{
    var baseAddress = builder.Configuration["BaseUrl"] ?? "https://localhost:54082";
    return new HttpClient { BaseAddress = new Uri(baseAddress) };
});

// Blazor Cascading Authentication State
builder.Services.AddCascadingAuthenticationState();

// Auth Service
builder.Services.AddScoped<IAuthService, AuthService>();

// Blazor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Controllers ve Services
builder.Services.AddControllers();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
