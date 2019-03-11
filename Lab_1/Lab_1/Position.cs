using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Position
    {
        public int Y { get; set; }
        public int X { get; set; }

        public override string ToString()
        {
            return "position: " + this.X + "  " + this.Y;
        }
    }
}
