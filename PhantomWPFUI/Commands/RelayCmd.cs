using System;
using System.Windows.Input;

namespace PhantomWPFUI.Commands
{
    public class RelayCmd : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter) => !_isExecuting;

        public void Execute(object parameter)
        {
            IsExecuting = true;
            try
            {
                _callback();
            }
            catch (Exception ex)
            {
                _onException?.Invoke(ex);
            }
            IsExecuting = false;
        }

        private bool _isExecuting;
        public bool IsExecuting 
        {
            get => _isExecuting;
            set
            {
                _isExecuting = value;
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
        }

        private readonly Action<Exception> _onException;
        private readonly Action _callback;

        public RelayCmd(Action callback, Action<Exception> onException)
        {
            _onException = onException;
            _callback = callback;
        }
    }

    public class RelayCmd<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => !_isExecuting;

        public void Execute(object parameter)
        {
            IsExecuting = true;
            try
            {
                _callback.Invoke((T)parameter);
            }
            catch (Exception ex)
            {
                _onException?.Invoke(ex);
            }
            IsExecuting = false;
        }

        private bool _isExecuting;

        public bool IsExecuting
        {
            get => _isExecuting;
            set
            {
                _isExecuting = value;
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
        }

        private readonly Action<Exception> _onException;
        private readonly Action<T> _callback;

        public RelayCmd(Action<T> callback, Action<Exception> onException)
        {
            _onException = onException;
            _callback = callback;
        }
    }
}
