using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Fluxor;
using Gumby.App.Climb.Route.Store;
using Gumby.App.Shared;
using Microsoft.AspNetCore.Components;
using MatBlazor;
using Microsoft.AspNetCore.Components.Layouts;

namespace Gumby.App.Climb.Route
{
    [Layout(typeof(MainLayout))]
    public class RouteBase : ComponentBase
    {
        [Inject] protected IState<RouteState> _routeState { get; set; }
        [Inject] protected IDispatcher _dispatcher { get; set; }
        protected bool _isOpenAddRouteModal = false;

        protected void OpenAddRouteModal()
        {
            _isOpenAddRouteModal = true;
        }

        protected void OkAddRouteClicked()
        {
            _dispatcher.Dispatch(new AddRouteAction());
            _isOpenAddRouteModal = false;
        }

        protected void CancelAddRouteClicked()
        {
            _isOpenAddRouteModal = false;
        }
    }
}
