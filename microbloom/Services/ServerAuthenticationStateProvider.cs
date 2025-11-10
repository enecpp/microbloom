using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using System.Security.Claims;

namespace microbloom.Services
{
    /// <summary>
    /// Basit ve çalýþýr Server Authentication State Provider
    /// HttpContext'ten direkt user bilgisini okur
  /// </summary>
    public class ServerAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
  private readonly ILogger<ServerAuthenticationStateProvider> _logger;

        public ServerAuthenticationStateProvider(
            IHttpContextAccessor httpContextAccessor,
         ILogger<ServerAuthenticationStateProvider> logger)
        {
       _httpContextAccessor = httpContextAccessor;
            _logger = logger;
    }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var httpContext = _httpContextAccessor.HttpContext;
     
            if (httpContext?.User?.Identity?.IsAuthenticated == true)
      {
         _logger.LogInformation($"? User authenticated: {httpContext.User.Identity.Name}");
           return Task.FromResult(new AuthenticationState(httpContext.User));
        }

_logger.LogInformation("?? User not authenticated");
            return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
        }

        /// <summary>
      /// Auth state deðiþtiðinde UI'ý bilgilendir
        /// Login/Logout sonrasý çaðrýlmalý
   /// </summary>
  public void NotifyAuthenticationStateChanged()
 {
            _logger.LogInformation("?? NotifyAuthenticationStateChanged called");
   NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
    }
}
