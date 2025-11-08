using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using microbloom.Entities;

namespace microbloom.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var dbContext = serviceProvider.GetRequiredService<KariyerDBContext>();

            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (!await roleManager.RoleExistsAsync("Employer"))
            {
                await roleManager.CreateAsync(new IdentityRole("Employer"));
            }

            if (!await roleManager.RoleExistsAsync("JobSeeker"))
            {
                await roleManager.CreateAsync(new IdentityRole("JobSeeker"));
            }

            string companyEmail = "company@microsoft.com";
            var companyUser = await userManager.FindByEmailAsync(companyEmail);

            if (companyUser == null)
            {
                var microsoftCompany = await dbContext.Companies!.FindAsync(2);

                if (microsoftCompany != null)
                {
                    companyUser = new AppUser
                    {
                        UserName = companyEmail,
                        Email = companyEmail,
                        FirstName = "Bill",
                        LastName = "Gates (Test)",
                        EmailConfirmed = true,
                        CompanyId = microsoftCompany.Id
                    };

                    var result = await userManager.CreateAsync(companyUser, "Company123!");
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(companyUser, "Employer");
                    }
                }
            }

            // Test normal kullanıcısı oluştur
            string userEmail = "user@test.com";
            var normalUser = await userManager.FindByEmailAsync(userEmail);

            if (normalUser == null)
            {
                normalUser = new AppUser
                {
                    UserName = userEmail,
                    Email = userEmail,
                    FirstName = "Normal",
                    LastName = "Kullanıcı (Test)",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(normalUser, "User123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(normalUser, "JobSeeker");
                }
            }
        }
    }
}