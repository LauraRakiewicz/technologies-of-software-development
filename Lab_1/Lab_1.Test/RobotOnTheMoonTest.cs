using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Test
{
    class RobotOnTheMoonTest
    {
        [Test]
        public static void IsSafeCommandTest1()
        {
            string[] board =
               {".....",
                 ".###.",
                 "..S#.",
                 "...#."};
            string s = "URURURURUR";
            RobotOnTheMoon robotOnTheMoon = new RobotOnTheMoon();

            Assert.AreEqual("Alive", robotOnTheMoon.IsSafeCommand(board, s));
        }

        [Test]
        public static void IsSafeCommandTest2()
        {
            string[] board =
               {".....",
                ".###.",
                "..S..",
                "...#." };
            string s = "URURURURUR";
            RobotOnTheMoon robotOnTheMoon = new RobotOnTheMoon();

            Assert.AreEqual("Dead", robotOnTheMoon.IsSafeCommand(board, s));
        }

        [Test]
        public static void IsSafeCommandTest3()
        {
            string[] board =
               {".....",
                ".###.",
                "..S..",
                "...#." };
            string s = "URURU";
            RobotOnTheMoon robotOnTheMoon = new RobotOnTheMoon();

            Assert.AreEqual("Alive", robotOnTheMoon.IsSafeCommand(board, s));
        }

        [Test]
        public static void IsSafeCommandTest4()
        {
            string[] board =
                 {"#####",
                 "#...#",
                 "#.S.#",
                 "#...#",
                 "#####"};
            string s = "DRULURLDRULRUDLRULDLRULDRLURLUUUURRRRDDLLDD";
            RobotOnTheMoon robotOnTheMoon = new RobotOnTheMoon();

            Assert.AreEqual("Alive", robotOnTheMoon.IsSafeCommand(board, s));
        }

        [Test]
        public static void IsSafeCommandTest5()
        {
            string[] board =
                {"#####",
                "#...#",
                "#.S.#",
                "#...#",
                "#.###" };
            string s = "DRULURLDRULRUDLRULDLRULDRLURLUUUURRRRDDLLDD";
            RobotOnTheMoon robotOnTheMoon = new RobotOnTheMoon();

            Assert.AreEqual("Dead", robotOnTheMoon.IsSafeCommand(board, s));
        }

        [Test]
        public static void IsSafeCommandTest6()
        {
            string[] board =
               {"S"};
            string s = "R";
            RobotOnTheMoon robotOnTheMoon = new RobotOnTheMoon();

            Assert.AreEqual("Dead", robotOnTheMoon.IsSafeCommand(board, s));
        }
    }
}
