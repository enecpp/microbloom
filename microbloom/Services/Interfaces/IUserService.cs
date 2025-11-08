using microbloom.Entities;

namespace microbloom.Services.Interfaces
{
    public interface IUserService
 {
        Task<AppUser?> GetUserByIdAsync(string userId);
      Task<AppUser?> GetUserByEmailAsync(string email);
    }
}
