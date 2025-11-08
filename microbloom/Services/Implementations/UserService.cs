using Microsoft.AspNetCore.Identity;
using microbloom.Entities;
using microbloom.Services.Interfaces;

namespace microbloom.Services.Implementations
{
    public class UserService : IUserService
    {
    private readonly UserManager<AppUser> _userManager;

      public UserService(UserManager<AppUser> userManager)
  {
      _userManager = userManager;
  }

   public async Task<AppUser?> GetUserByIdAsync(string userId)
        {
        return await _userManager.FindByIdAsync(userId);
    }

   public async Task<AppUser?> GetUserByEmailAsync(string email)
        {
    return await _userManager.FindByEmailAsync(email);
        }
    }
}
