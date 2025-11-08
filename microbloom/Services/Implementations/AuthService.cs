using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using microbloom.DTOs;
using microbloom.Services.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;

namespace microbloom.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<AuthResult> RegisterAsync(RegisterDto registerDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/account/register", registerDto);
            if (!response.IsSuccessStatusCode)
            {
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

            var authResponse = await response.Content.ReadFromJsonAsync<AuthResponseDto>();
            if (authResponse?.User == null)
            {
                return new AuthResult { Successful = false, Error = "Kullanıcı bilgisi alınamadı." };
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, authResponse.User.UserName!)
            };

            if (authResponse.User.Claims != null)
            {
                foreach (var claim in authResponse.User.Claims)
                {
                    claims.Add(new Claim(claim.Key, claim.Value));
                }
            }

            var identity = new ClaimsIdentity(claims, "serverauth");
            var user = new ClaimsPrincipal(identity);

            ((PersistentAuthenticationStateProvider)_authenticationStateProvider).NotifyUserAuthentication(user);

            return new AuthResult { Successful = true };
        }

        public async Task LogoutAsync()
        {
            await _httpClient.PostAsync("api/account/logout", null);
            ((PersistentAuthenticationStateProvider)_authenticationStateProvider).NotifyUserLogout();
        }
    }
}
