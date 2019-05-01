using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public static class Utilities
    {
        public static int CountNearbyMines(this Cell cell, Table table)
        {
            int mines = 0;
            for (int i = (cell.X == 0 ? 0 : cell.X - 1); i <= (cell.X == table.M - 1 ? table.M - 1 : cell.X + 1); i++)
            {
                for (int j = (cell.Y == 0 ? 0 : cell.Y - 1); j <= (cell.Y == table.N - 1 ? table.N - 1 : cell.Y + 1); j++)
                {
                    if (table.Get(i, j).HasMine)
                    {
                        mines++;
                    }
                }
            }
            return mines;
        }

        public static void PrintTable(Table table)
        {
            for (int i = 0; i < table.M; i++)
            {
                for (int j = 0; j < table.N; j++)
                {
                    Cell cell = table.Get(i, j);

                    if (cell.Uncovered)
                        Console.Write((cell.HasMine ? "*" : cell.CountNearbyMines(table).ToString()) + " ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }
    }
}
