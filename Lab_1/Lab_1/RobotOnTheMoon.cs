using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class RobotOnTheMoon
    {
        private static int height;
        private static int width;
        private Position robotPosition = new Position();
        private string[,] moonBoard;

        public string[,] GenerateBoard(string[] board)
        {
            width = board[0].Length;
            height = board.Length;

            moonBoard = new string[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    moonBoard[i, j] = board[i][j].ToString();
                    if (moonBoard[i, j] == "S")
                    {
                        robotPosition.X = i;
                        robotPosition.Y = j;
                    }
                }
            }

            return moonBoard;
        }

        private bool CanMove(Position newPosition)
        {
            if (!IsOutsideTheBoard(newPosition) && moonBoard[newPosition.Y, newPosition.X] == "#")
            {
                return false;
            }

            return true;
        }

        private bool IsOutsideTheBoard(Position position)
        {
            if (position.X >= width || position.X < 0 || position.Y >= height || position.Y < 0)
            {
                return true;
            }

            return false;
        }

        public string MoveRobot(char c)
        {
            Position newPosition = new Position();
            newPosition.X = robotPosition.X;
            newPosition.Y = robotPosition.Y;

            switch (c)
            {
                case 'U':
                    newPosition.Y--;
                    if (CanMove(newPosition))
                    {
                        robotPosition.Y--;
                    }
                    break;

                case 'D':
                    newPosition.Y++;
                    if (CanMove(newPosition))
                    {
                        robotPosition.Y++;
                    }
                    break;

                case 'L':
                    newPosition.X--;
                    if (CanMove(newPosition))
                    {
                        robotPosition.X--;
                    }
                    break;

                case 'R':
                    newPosition.X++;
                    if (CanMove(newPosition))
                    {
                        robotPosition.X++;
                    }
                    break;
            }

            if (IsOutsideTheBoard(robotPosition))
            {
                return "Dead";
            }
            return "Alive";
        }

        public string IsSafeCommand(string[] board, string S)
        {
            string[,] moonBoard = GenerateBoard(board);
            string answer = "";

            foreach (var item in S)
            {
                if ((answer = MoveRobot(item)) == "Dead") break;
            }

            return answer;
        }

        public void PrintMoonBoard(string[,] moonBoard, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < width; j++)
                {
                    Console.Write(moonBoard[i, j]);
                }
            }
        }

        public void RealDataTests()
        {
            string[] board = { ".....", ".###.", "..S..", "...#." };
            string s = "DRULRU";
            Console.WriteLine(IsSafeCommand(board, s));
        }
    }
}
