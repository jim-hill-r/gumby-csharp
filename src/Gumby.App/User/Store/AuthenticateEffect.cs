using Blazor.Fluxor;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Gumby.App.User.Store
{
    public class AuthenticateEffect : Effect<AuthenticateAction>
    {
        private readonly NavigationManager _navigationManager;

        public AuthenticateEffect(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        protected async override Task HandleAsync(AuthenticateAction action, IDispatcher dispatcher)
        {
            var currentUri = _navigationManager.Uri;
            var host = new Uri(currentUri).Host;
            var clientId = new Guid("62c98281-193a-4884-a3a3-131eac593dff");
            if (host.Contains("jimhillr.dev"))
            {
                clientId = new Guid("1f14efd2-38c7-4dbd-a834-6b07233e1fb2");
            }
            var uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "https";
            uriBuilder.Host = "6umby.b2clogin.com";
            uriBuilder.Path = "6umby.onmicrosoft.com/oauth2/v2.0/authorize";
            uriBuilder.Query =
                "p=B2C_1_GumbySignUpSignIn" +
                "&client_id=" + clientId.ToString() +
                "&nonce=defaultNonce" +
                "&redirect_uri=" + currentUri +
                "&scope=openid" +
                "&response_type=id_token" +
                "&prompt=login";
            _navigationManager.NavigateTo(uriBuilder.ToString());
        }
    }
}
