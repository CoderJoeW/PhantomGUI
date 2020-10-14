using System;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;
using PhantomLib.Models;

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

        public PhantomFactory()
        {
            var assembly = this.GetType().GetTypeInfo().Assembly;
            var memoryStream = new MemoryStream(); 
            assembly.GetManifestResourceStream("PhantomLib.Resources.phantom.exe")?.CopyTo(memoryStream);
            _baseExeBytes = memoryStream.ToArray();
        }

        public bool TryCreatePhantomExecutable(PhantomInfo phantomInfo, out string exePath, string serverFolderPath = "./Servers/")
        {
            if (Directory.Exists(serverFolderPath) == false)
                Directory.CreateDirectory(serverFolderPath);
            
            exePath = serverFolderPath + phantomInfo.ServerName + "_phantom.exe";
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
