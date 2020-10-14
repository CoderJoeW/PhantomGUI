using System;
using System.Threading.Tasks;

namespace PhantomWPFUI.Commands
{
    public class AsyncRelayCmd : AsyncCmdBase
    {
        private readonly Func<Task> _callback;
        public AsyncRelayCmd(Func<Task> callback, Action<Exception> onException) : base(onException)
        {
            _callback = callback;
        }
        protected override async Task ExecuteAsync(object parameter)
        {
            await _callback();
        }
    }
}
