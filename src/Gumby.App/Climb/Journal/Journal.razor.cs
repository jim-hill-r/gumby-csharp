using Blazor.Fluxor;
using Gumby.App.Climb.Journal.Store;
using Microsoft.AspNetCore.Components;
using Gumby.App.Shared;
using MatBlazor;
using Microsoft.AspNetCore.Components.Layouts;
using Microsoft.JSInterop;

namespace Gumby.App.Climb.Journal
{
    [Layout(typeof(MainLayout))]
    public class JournalBase : ComponentBase
    {
        [Inject] protected IState<JournalState> _journalState { get; set; }
        [Inject] protected IDispatcher _dispatcher { get; set; }
        [Inject] protected IUriHelper _uriHelper { get; set; }

        protected string _addJournalDialogText = "";
        protected bool _isOpenAddJournalModal = false;

        protected override void OnInit()
        {
            _journalState.Subscribe(this);
        }

        protected void OpenAddJournalModal()
        {
            _isOpenAddJournalModal = true;
        }

        protected void OkAddJournalClicked()
        {
            _dispatcher.Dispatch(new AddJournalAction() { Name = _addJournalDialogText });
            _isOpenAddJournalModal = false;
        }

        protected void CancelAddJournalClicked()
        {
            _isOpenAddJournalModal = false;
        }
    }
}
