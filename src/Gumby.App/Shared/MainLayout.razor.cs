using Blazor.Fluxor;
using Gumby.App.User.Store;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Layouts;
using System;
using MatBlazor;

namespace Gumby.App.Shared
{
    public class MainLayoutBase : LayoutComponentBase
    {
        [Inject] protected IState<UserState> _userState { get; set; }
        [Inject] protected IDispatcher _dispatcher { get; set; }
        [Inject] protected IUriHelper _uriHelper { get; set; }

        protected bool _isOpenDrawer = false;

        protected override void OnInit()
        {
            _userState.Subscribe(this);
            var currentUri = new Uri(_uriHelper.GetAbsoluteUri());
            var token = currentUri.Fragment.Replace("#id_token=", "");
            if (token.Length > 0)
            {
                _dispatcher.Dispatch(new TokenReceivedAction(token));
                _uriHelper.NavigateTo(currentUri.ToString().Replace(currentUri.Fragment, ""));
            }
        }

        protected void NavigateProfile()
        {
            if (_userState.Value.IsAuthenticated)
            {
                // TODO: Navigate to profile page
            }
            else
            {
                _dispatcher.Dispatch(new AuthenticateAction());
            }
        }

        protected void ToggleDrawer()
        {
            _isOpenDrawer = !_isOpenDrawer;
        }
    }
}
