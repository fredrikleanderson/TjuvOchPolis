using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvochPolisFredrik.Counter;

namespace TjuvochPolisFredrik
{
    static class Printer
    {
        public static void PrintCity(ICity city)
        {
            Console.Clear();
            Console.WriteLine($"Turns left: {turnsLeft}");
            Console.WriteLine(" ____________________________________________________________________________________________________ ");
            for (int y = city.Rows - 1; y >= 0; y--)
            {
                Console.Write("|");
                for (int x = 0; x < city.Columns; x++)
                {
                    Console.Write(city.Grid[y, x]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("|____________________________________________________________________________________________________| ");
            Console.WriteLine($"Number of robberys: {numberOfRobberys}  Number of arrests: {numberOfArrests}  Number of confiscated items: {numberOfConfiscatedItems}\n");
        }
    }
}
