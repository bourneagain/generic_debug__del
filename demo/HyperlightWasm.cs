using System.Collections;
using System.Collections.Generic;
using Hyperlight;

namespace HyperlightWasm
{
    public interface IWasmSandboxRegistration : ISandboxRegistration
    {
    }
    public class HyperlightWasmSandbox<T> : IWasmSandboxRegistration where T:ISandboxRegistration
    {
        private Sandbox<T> partition;

        public void Name()
        {
            Console.WriteLine("Main within HyperlightWasm");
        }

        public void Name(string name)
        {
            throw new NotImplementedException();
        }

        public void Name(string name, string description)
        {
            throw new NotImplementedException();
        }

        public HyperlightWasmSandbox(Action<T>? func, int a, string s)
        {
            this.partition = new Sandbox<T>(func, a, s);
        }


    }
}


