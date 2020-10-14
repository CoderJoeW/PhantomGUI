using System.Windows.Input;
using PhantomLib.Models;
using PhantomWPFUI.Commands;
using PhantomWPFUI.Services;

namespace PhantomWPFUI.ViewModels
{
    public class ConnectionDialogViewModel : BaseDialogViewModel<PhantomInfo>
    {
        public PhantomInfo PhantomInfo { get; set; } = new PhantomInfo();
        public ICommand CreateCommand { get; }
        public ICommand CancelCommand { get; }
        public ConnectionDialogViewModel(string windowTitle, string message) : base(windowTitle, message)
        {
            CreateCommand = new RelayCmd<IDialogWindow>(Create, OnException);
            CancelCommand = new RelayCmd<IDialogWindow>(Cancel, OnException);
        }

        public void Create(IDialogWindow dialogWindow) => CloseDialogWithResult(dialogWindow, PhantomInfo);
        public void Cancel(IDialogWindow dialogWindow) => CloseDialogWithResult(dialogWindow, null);
    }
}
