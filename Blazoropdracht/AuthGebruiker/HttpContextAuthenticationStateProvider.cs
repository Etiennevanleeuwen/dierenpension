using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

// This is a class that gives back the authentication state, meaning
// this is where the user is stored, which role it has, whether it's logged in
public class HttpContextAuthenticationStateProvider(IHttpContextAccessor accessor)
    : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var user = accessor.HttpContext?.User
            ?? new ClaimsPrincipal(new ClaimsIdentity());
        return Task.FromResult(new AuthenticationState(user));
    }
}
