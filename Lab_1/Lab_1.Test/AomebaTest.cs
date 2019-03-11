using NUnit.Framework;
using System;

namespace Lab_1.Test
{  
    public class AomebaTest
    {
        [Test]
        public void SimuateTest1()
        {
            int[] x = { 2, 1, 3, 1, 2 };
            int a = 1;

            Assert.AreEqual(4, Aomeba.Simulate(x, a));
        }

        [Test]
        public void SimuateTest2()
        {
            int[] x = { 1, 4, 9, 16, 25, 36, 49 };
            int a = 10;

            Assert.AreEqual(10, Aomeba.Simulate(x, a));
        }

        [Test]
        public void SimuateTest3()
        {
            int[] x = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 1024, 2048 };
            int a = 1;

            Assert.AreEqual(512, Aomeba.Simulate(x, a));
        }

        [Test]
        public void SimuateTest4()
        {
            int[] x = { 817, 832, 817, 832, 126, 817, 63, 63, 126, 817, 832, 287, 823, 817, 574 };
            int a = 63;

            Assert.AreEqual(252, Aomeba.Simulate(x, a));
        }
    }
}
