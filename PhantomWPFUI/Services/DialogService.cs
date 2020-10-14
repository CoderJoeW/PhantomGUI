using PhantomWPFUI.ViewModels;
using PhantomWPFUI.Views;

namespace PhantomWPFUI.Services
{
    public class DialogService : IDialogService
    {
        public T OpenDialog<T>(BaseDialogViewModel<T> viewModel)
        {
            IDialogWindow window = new BaseDialogView { DataContext = viewModel };
            window.ShowDialog();
            return viewModel.DialogResult;
        }
    }
}
