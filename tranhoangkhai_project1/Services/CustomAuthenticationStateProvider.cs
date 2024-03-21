using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace tranhoangkhai_project1.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public void MarkUserAsAuthenticated(string maDangNhap)
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, maDangNhap),
            }, "apiauth_type");

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // Here you can integrate any external validation
            // For demo purposes, the user is assumed to be authenticated
            var identity = new ClaimsIdentity();
            return Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));
        }
    }
}
