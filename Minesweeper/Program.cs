using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dimensions? m,n >>> ");
            string input = Console.ReadLine();
            string[] dimensions = input.Split(',');
            Table table = new Table(int.Parse(dimensions[0]), int.Parse(dimensions[1]));
            
            while (!table.Lost() && !table.Won())
            {
                Utilities.PrintTable(table);
                Console.Write("x,y >>> ");
                input = Console.ReadLine();
                string[] coordinates = input.Split(',');
                table.Get(int.Parse(coordinates[0]) - 1, int.Parse(coordinates[1]) - 1).Uncovered = true;
            }

            Utilities.PrintTable(table);

            if (table.Lost())
            {
                Console.WriteLine("You lose! :(");
            }
            else
            {
                Console.WriteLine("You win! :)");
            }

            Console.ReadKey();
        }
    }
}
