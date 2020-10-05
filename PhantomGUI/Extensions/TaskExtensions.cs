using System;
using System.Threading.Tasks;

namespace PhantomGUI.Extensions
{
    public static class TaskExtensions
    {
        public static async void SafeFireAndForget(this Task task, bool returnToCallingContext, Action<Exception> onException = null)
        {
            try
            {
                await task.ConfigureAwait(returnToCallingContext);
            }catch(Exception ex) when (onException != null)
            {
                onException(ex);
            }
        }
    }
}
