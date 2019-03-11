using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public static class Aomeba
    {
        public static int Simulate(int[] x, int a)
        {
            foreach (var i in x)
            {
                if (i == a)
                {
                    a *= 2;
                }
            }

            return a;
        }

        public static void RealDataTests()
        {
            int[] x = { 4, 5, 6, 8, 6, 3, 9, 12, 80, 35, 16, 40, 32, 24, 10, 20, 40, 48 };
            int a = 4;
            Console.WriteLine("Result for: [4, 5, 6, 8, 6, 3, 9, 12, 80, 35, 16, 40, 32, 24, 10, 20, 40, 48], \na = 4: \n"
                + Simulate(x, a) + "\n");

            a = 5;
            Console.WriteLine("Result for: a = 5: \n"
                + Simulate(x, a) + "\n");

            a = 6;
            Console.WriteLine("Result for: a = 6: \n"
                + Simulate(x, a) + "\n");
        }
    }
}
