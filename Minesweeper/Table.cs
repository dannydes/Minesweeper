using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Table
    {
        private Cell[,] cells;
        public int M { get; }
        public int N { get; }
        public bool GameLost { get; set; }
        public bool GameWon { get; set; }
        
        public Table(int m = 4, int n = 4)
        {
            cells = new Cell[M = m, N = n];
            Random gen = new Random();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    cells[i, j] = new Cell();
                    cells[i, j].HasMine = gen.Next(10) > 6;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;
                }
            }

            M = m;
            N = n;
        }

        public Cell Get(int x, int y)
        {
            return cells[x, y];
        }

        public bool Lost()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Cell cell = cells[i, j];
                    if (cell.Uncovered && cell.HasMine)
                    {
                        return GameLost = true;
                    }
                }
            }
            return GameLost = false;
        }

        public bool Won()
        {
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Cell cell = cells[i, j];
                    if (!cell.Uncovered && !cell.HasMine)
                    {
                        return GameWon = false;
                    }
                }
            }
            return GameWon = true;
        }
    }
}
