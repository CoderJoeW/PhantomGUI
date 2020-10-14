using PhantomWPFUI.ViewModels;

namespace PhantomWPFUI.Services
{
    public interface IDialogService
    {
        public T OpenDialog<T>(BaseDialogViewModel<T> viewModel);
    }
}