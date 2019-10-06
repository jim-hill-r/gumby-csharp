using Blazor.Fluxor;
using Gumby.App.Climb.Journal.Store;
using Gumby.App.Common.Layouts;
using Microsoft.AspNetCore.Components;

namespace Gumby.App.Journal.Views
{
    [Layout(typeof(MainLayout))]
    public class PostNewBase : ComponentBase
    {
        [Inject] protected IState<JournalState> _journalState { get; set; }
        [Inject] protected IDispatcher _dispatcher { get; set; }
        [Inject] protected NavigationManager _navigationManager { get; set; }

        protected string _addJournalDialogText = "";

        protected override void OnInitialized()
        {
            _journalState.Subscribe(this);
        }
        
        protected void OkAddJournalClicked()
        {
            _dispatcher.Dispatch(new AddJournalAction() { Name = _addJournalDialogText });
            _navigationManager.NavigateTo("/");
        }
    }
}
