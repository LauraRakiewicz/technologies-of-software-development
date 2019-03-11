using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aomeba");
            Aomeba.RealDataTests();
            Console.WriteLine("\n\n");

            Console.WriteLine("Alarms");
            Alarms.RealDataTests();
            Console.WriteLine("\n\n");

            Console.WriteLine("Robot on the Moon");
            RobotOnTheMoon robotOnTheMoon = new RobotOnTheMoon();
            robotOnTheMoon.RealDataTests();
            Console.ReadLine();
        }
    }
}
