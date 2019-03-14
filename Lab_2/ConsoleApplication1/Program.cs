using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TSD.Linq.Cars;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarQuerries carQuerries = new CarQuerries();
            carQuerries.ExecuteQueries();
            carQuerries.SaveToXml();
            carQuerries.ReadFromXml();

            var processList = Process.GetProcesses().ToList();
            Console.WriteLine("memory used by processes: " + processList.GetTotalMemory());

            Func<int, bool> IsLeapYear = (x) => DateTime.IsLeapYear(x);
            Console.WriteLine("Is 2019 a leap year? " + IsLeapYear(2019));

            Console.ReadLine();
        }
    }

}
