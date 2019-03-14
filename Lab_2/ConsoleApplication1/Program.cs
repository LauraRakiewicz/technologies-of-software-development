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
        delegate void newDelegate(int year);

        static newDelegate instance;

        static void Main(string[] args)
        {
            CarQuerries carQuerries = new CarQuerries();
            carQuerries.ExecuteQueries();
            carQuerries.SaveToXml();
            carQuerries.ReadFromXml();

            var processList = Process.GetProcesses().ToList();
            Console.WriteLine("memory used by processes: " + processList.GetTotalMemory());

            Func<int, bool> IsLeapYear = (x) => DateTime.IsLeapYear(x);
            instance += x => Console.WriteLine("year {0} is {1}", x, IsLeapYear(x) ? "leap" : "not leap");
            instance(2019);
            Console.WriteLine("Is 2019 a leap year? " + IsLeapYear(2019));

            MyGenericCollection<Car> carTest = new MyGenericCollection<Car>();

            carTest.Add(new Car("Mini") { Sales2014 = 1241, Sales2015 = 1235 });
            carTest.Add(new Car("BMW") { Sales2014 = 1241, Sales2015 = 1235 });
            carTest.Add(new Car("AAA") { Sales2014 = 1241, Sales2015 = 1235 });
            Console.WriteLine("car.Make index 30: " + carTest.Get(30).Make);
            Console.WriteLine("car.Make index 3: " + carTest.Get(3).Make);
            Console.WriteLine("is list empty? " + carTest.IsEmpty());

            Console.ReadLine();
        }


    }

}
