using microbloom.DTOs;

namespace microbloom.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResult> RegisterAsync(RegisterDto registerDto);
        Task<AuthResult> LoginAsync(LoginDto loginDto);
        Task LogoutAsync();
    }

    public class AuthResult
    {
        public bool Successful { get; set; }
        public string? Error { get; set; }
    }

    public class AuthResponseDto
    {
        public CurrentUser? User { get; set; }
    }
}
