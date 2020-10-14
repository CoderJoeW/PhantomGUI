using System;
using System.Diagnostics;
using PhantomLib.Helpers;

namespace PhantomWPFUI.ViewModels
{
    public abstract class BaseViewModel : Observable
    {
        public void OnException(Exception ex) => Debug.Print(ex.Message);
    }
}
