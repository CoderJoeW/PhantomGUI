using PhantomWPFUI.Services;

namespace PhantomWPFUI.ViewModels
{
    public class BaseDialogViewModel<T> : BaseViewModel
    {
        public string WindowTitle { get; set; }
        public string Message { get; set; }
        public T DialogResult { get; set; }

        public BaseDialogViewModel(string windowTitle, string message)
        {
            this.WindowTitle = windowTitle;
            this.Message = message;
        }
        public BaseDialogViewModel(string windowTitle) : this(windowTitle, string.Empty) { }
        public BaseDialogViewModel() : this(string.Empty, string.Empty) { }

        public void CloseDialogWithResult(IDialogWindow window, T result)
        {
            DialogResult = result;
            if (window != null)
                window.DialogResult = true;
        }
    }
}
