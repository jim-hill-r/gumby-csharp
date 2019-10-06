using Blazor.Fluxor;
using Gumby.App.User.Store;
using Microsoft.AspNetCore.Components;
using System;

namespace Gumby.App.Common.Layouts
{
    public class MainLayoutBase : LayoutComponentBase
    {
        [Inject] protected IState<UserState> _userState { get; set; }
        [Inject] protected IDispatcher _dispatcher { get; set; }
        [Inject] protected NavigationManager _navigationManager { get; set; }

        protected bool _isOpenDrawer = false;

        protected override void OnInitialized()
        {
            _userState.Subscribe(this);
            var currentUri = new Uri(_navigationManager.Uri);
            var token = currentUri.Fragment.Replace("#id_token=", "");
            if (token.Length > 0)
            {
                _dispatcher.Dispatch(new TokenReceivedAction(token));
                _navigationManager.NavigateTo(currentUri.ToString().Replace(currentUri.Fragment, ""));
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
