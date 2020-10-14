using System.Collections.ObjectModel;
using System.Windows.Input;
using PhantomLib.Models;
using PhantomWPFUI.Commands;
using PhantomWPFUI.Services;

namespace PhantomWPFUI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IDialogService _dialogService;
        private ObservableCollection<PhantomInfo> _connections = 
            new ObservableCollection<PhantomInfo>();
        public ICommand TryAddConnectionCommand { get; }

        public MainWindowViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            TryAddConnectionCommand = new RelayCmd(TryAddConnection, OnException);
        }

        public ObservableCollection<PhantomInfo> Connections
        {
            get => _connections;
            set => Set(ref _connections, value);
        }

        private void TryAddConnection()
        {
            var dialog = new ConnectionDialogViewModel("Phantom", string.Empty);
            var newConnection = _dialogService.OpenDialog(dialog);
            if (newConnection != null)
                Connections.Add(newConnection);
        }
    }
}
