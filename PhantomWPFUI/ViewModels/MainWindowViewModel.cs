using System.Collections.ObjectModel;
using System.Windows.Input;
using PhantomLib.Models;
using PhantomLib.Services;
using PhantomWPFUI.Commands;
using PhantomWPFUI.Services;

namespace PhantomWPFUI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IDialogService _dialogService;
        private ObservableCollection<PhantomInfo> _connections;
        private readonly PhantomRunner _phantomRunner;
        private readonly PhantomFactory _phantomFactory;
        public ICommand TryAddConnectionCommand { get; }

        public MainWindowViewModel(IDialogService dialogService, PhantomRunner phantomRunner, PhantomFactory phantomFactory)
        {
            _dialogService = dialogService;
            _phantomRunner = phantomRunner;
            _phantomFactory = phantomFactory;

            _connections = new ObservableCollection<PhantomInfo>();

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
            var newPhantomInfo = _dialogService.OpenDialog(dialog);
            if (newPhantomInfo is null) return;

            Connections.Add(newPhantomInfo);
            _phantomFactory.TryCreatePhantomExecutable(newPhantomInfo, out string exePath);
            _phantomRunner.TryStartProcess(newPhantomInfo, exePath);
        }
    }
}
