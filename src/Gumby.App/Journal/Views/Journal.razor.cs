using Blazor.Fluxor;
using Gumby.App.Climb.Journal.Store;
using Gumby.App.Common.Layouts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Layouts;

namespace Gumby.App.Journal.Views
{
    [Layout(typeof(MainLayout))]
    public class JournalBase : ComponentBase
    {
        [Inject] protected IState<JournalState> _journalState { get; set; }
        [Inject] protected IDispatcher _dispatcher { get; set; }
        [Inject] protected IUriHelper _uriHelper { get; set; }
        
        protected override void OnInit()
        {
            _journalState.Subscribe(this);
        }

        protected void NavigateToAddPost()
        {
            _uriHelper.NavigateTo("/post/new");
        }
    }
}
