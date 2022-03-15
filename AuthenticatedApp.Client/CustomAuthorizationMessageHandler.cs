using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
{
    
    public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
        NavigationManager navigationManager, IConfiguration conf)
        : base(provider, navigationManager)
    {
        ConfigureHandler(
            authorizedUrls: new[] { conf["APIRoot"] },
            scopes: new[] { conf["APIScope"] });
    } 
}