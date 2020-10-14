using System;
using System.IO;

namespace PhantomLib.Services
{
    public class PhantomFactory
    {
        private readonly byte[] _baseExeBytes;
        private readonly Action<Exception> _onException;
        public PhantomFactory(byte[] baseExeBytes, Action<Exception> onException) : this(baseExeBytes)
        {
            _onException = onException;
        }

        public PhantomFactory(byte[] baseExeBytes)
        {
            _baseExeBytes = baseExeBytes;
        }

        public bool TryCreatePhantomExecutable(string exePath)
        {
            try
            {
                using (var stream = new FileStream(exePath, FileMode.Create, FileAccess.Write))
                {
                    stream.Write(_baseExeBytes, 0, _baseExeBytes.Length);
                }
                return true;
            }
            catch (Exception exception)
            {
                _onException?.Invoke(exception);
                return false;
            }
        }
    }
}
