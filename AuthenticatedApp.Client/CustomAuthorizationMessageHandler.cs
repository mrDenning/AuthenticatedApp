using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
{
    private static string scope = @"https://squiduob2c.onmicrosoft.com/fb1dcc49-e0a3-48e4-93c5-4fc746c9b7bf/access_app";
    //private static string scope = @;
  

    public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
        NavigationManager navigationManager, IConfiguration conf)
        : base(provider, navigationManager)
    {
        ConfigureHandler(
            authorizedUrls: new[] { conf["APIRoot"] },
            scopes: new[] { conf["APIScope"] });
    }
}