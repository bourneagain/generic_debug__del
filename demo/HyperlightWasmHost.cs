using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperlightWasm;
namespace test
{
    public class HyperlightWasmHost
    {
        public static void Main()
        {

            Action<IWasmSandboxRegistration> func = (s) =>
            {
                s.Name("Fu");
            };

            var host = new HyperlightWasmSandbox<IWasmSandboxRegistration>(func, 2, "C#");
            host.Name();
            
        }
    }
}
