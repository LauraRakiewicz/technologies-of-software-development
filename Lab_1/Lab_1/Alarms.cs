using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public static class Alarms
    {
        public static int CountAlarms(int[] volume, int s)
        {
            List<int> volumeList = volume.ToList();
            int count = 0;
            while (s > 0)
            {
                int firstElem = volumeList.First();
                s -= firstElem;
                volumeList.RemoveAt(0);
                volumeList.Add(firstElem);
                count++;
            }
   
            return count;
        }

        public static void RealDataTests()
        {
            int[] volume ={ 42,68,35,1,70,25,79,59,63,65,6,46,82,28,62,92,96,43,28,37,92,5,3,54,93,83,22,17,19,96,48,27,72,39,70,13,68,100,36,95,4,12,23,34,74,65,42,12,54,69};
            int s = 500;
            int result = CountAlarms(volume, s);
            Console.WriteLine("volume={42,68,35,1,70,25,79,59,63,65,6,46,82,28,62,92,96,43,28,37,92,5,3,54,93,83,22,17,19,96,48,27,72,39,70,13,68,100,36,95,4,12,23,34,74,65,42,12,54,69}");
            Console.WriteLine("result for s = 500:\n" +
                +result + "\n");

            s = 700;
            result = CountAlarms(volume, s);
            Console.WriteLine("result s = 700: \n" + result + "\n");

            s = 900;
            result = CountAlarms(volume, s);
            Console.WriteLine("result s = 900: \n" + result + "\n");
        }
    }
}
