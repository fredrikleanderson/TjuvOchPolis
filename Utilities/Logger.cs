using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolisFredrik
{
    static class Logger
    {
        public static void UpdateCity(ICity city)
        {
            for (int y = city.Rows - 1; y >= 0; y--)
            {
                for (int x = 0; x < city.Columns; x++)
                {
                    city.Grid[y, x] = ' ';
                }
            }
            foreach (Person p in city.People)
            {
                if (p is Citizen) city.Grid[p.YPos, p.XPos] = 'C';
                if (p is Thief) city.Grid[p.YPos, p.XPos] = 'T';
                if (p is Police) city.Grid[p.YPos, p.XPos] = 'P';
            }



        }
    }
}
