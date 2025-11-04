using System.Net.Http.Json;
using System.Threading.Tasks;   
using microbloom.Services.Interfaces;
using microbloom.DTOs;

namespace microbloom.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<AuthResult> RegisterAsync(RegisterDto registerDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/register", registerDto);
            if (!response.IsSuccessStatusCode)
            {
                // Hata detaylarını oku (varsa)
                var errors = await response.Content.ReadAsStringAsync();
                return new AuthResult { Successful = false, Error = errors };
            }
            return new AuthResult { Successful = true };
        }

        public async Task<AuthResult> LoginAsync(LoginDto loginDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/login", loginDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                return new AuthResult { Successful = false, Error = error };
            }
            return new AuthResult { Successful = true };
        }

        public async Task LogoutAsync()
        {
            await _httpClient.PostAsync("api/account/logout", null);
        }
    }
}
