using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Test
{
    public class AlarmsTest
    {
        [Test]
        public void CountAlarmsTest1()
        {
            int[] volume = { 5, 2, 4 };
            int s = 13;

            Assert.AreEqual(4, Alarms.CountAlarms(volume, s));
        }

        [Test]
        public void CountAlarmsTest2()
        {
            int[] volume = { 5, 2, 4 };
            int s = 3;

            Assert.AreEqual(1, Alarms.CountAlarms(volume, s));
        }

        [Test]
        public void CountAlarmsTest3()
        {
            int[] volume = { 1 };
            int s = 10000;

            Assert.AreEqual(10000, Alarms.CountAlarms(volume, s));
        }

        [Test]
        public void CountAlarmsTest4()
        {
            int[] volume = { 42, 68, 35, 1, 70, 25, 79, 59, 63, 65, 6, 46, 82, 28, 62, 92, 96, 43, 28, 37, 92, 5, 3, 54, 93, 83, 22, 17, 19, 96, 48, 27, 72, 39, 70, 13, 68, 100, 36, 95, 4, 12, 23, 34, 74, 65, 42, 12, 54, 69 };
            int s = 9999;

            Assert.AreEqual(203, Alarms.CountAlarms(volume, s));
        }
    }
}
