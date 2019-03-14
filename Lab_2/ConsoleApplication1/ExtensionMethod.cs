using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class ExtensionMethod
    {
        public static long GetTotalMemory(this List<Process> processes)
        {
            return processes.Sum(p => p.PrivateMemorySize64);
        }
    }
    

}
