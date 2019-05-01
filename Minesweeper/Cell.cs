using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Cell
    {
        public bool HasMine { get; set; }
        public bool Uncovered { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
