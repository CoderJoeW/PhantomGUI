using System;
using System.Collections.Generic;
using System.Diagnostics;
using PhantomLib.Models;

namespace PhantomLib.Services
{
    public class PhantomRunner
    {
        private readonly Action<Exception> _exceptionCallback;
        private readonly Dictionary<PhantomInfo, int> _phantomProcessIds;

        public PhantomRunner(Action<Exception> exceptionCallback)
        {
            _exceptionCallback = exceptionCallback;
            _phantomProcessIds = new Dictionary<PhantomInfo, int>();
        }

        public PhantomRunner() : this(ex => Debug.Print(ex.Message)) { }

        public bool TryKillProcess(PhantomInfo phantomInfo)
        {
            if (_phantomProcessIds.TryGetValue(phantomInfo, out int processId) == false) 
                return false;
            
            var process = Process.GetProcessById(processId);
            process.Kill();
            return true;
        }

        public bool TryStartProcess(PhantomInfo phantomInfo, string fileName)
        {
            var psi = new ProcessStartInfo(fileName, phantomInfo.AsParametersString())
            {
                WindowStyle = ProcessWindowStyle.Hidden
            };
            var process = new Process { StartInfo = psi };

            if (process.Start() == false) 
                return false;
            
            _phantomProcessIds.Add(phantomInfo, process.Id);
            return true;
        }
    }
}
