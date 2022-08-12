using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperlight
{
    public interface ISandboxRegistration
    {
        public void Name();
        public void Name(string name);
        public void Name(string name, string description);

    }
    public class Sandbox<T> : ISandboxRegistration where T : ISandboxRegistration
    {
        int _a;
        Action<T> _action;
        public Sandbox()
        {
            _a = 0;
        }
        public Sandbox(int a)
        {
            this._a = a;
        }

        public Sandbox(Action<T>? func, int a, string s)
        {
            // How to invoke func?
            // func?.Invoke(<HyperlightWasmSandbox obj)
            Console.WriteLine("Need to find how to call the func Action here with instance of the HyperlightWasmSandbox");
        }

        public void Name()
        {
            throw new NotImplementedException();
        }

        public void Name(string name)
        {
            throw new NotImplementedException();
        }

        public void Name(string name, string description)
        {
            throw new NotImplementedException();
        }
    }
}

