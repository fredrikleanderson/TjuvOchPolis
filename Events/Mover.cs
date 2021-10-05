using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvochPolisFredrik.Enums.Direction;

namespace TjuvochPolisFredrik
{
    static class Mover
    {
        public static void MovePeople(ICity city)
        {
            foreach (Person person in city.People)
            {
                switch (person.Direction)
                {
                    case Up:
                        person.YPos++;
                        break;

                    case Down:
                        person.YPos--;
                        break;

                    case Left:
                        person.XPos--;
                        break;

                    case Right:
                        person.XPos++;
                        break;

                    case UpLeft:
                        person.YPos++;
                        person.XPos--;
                        break;

                    case UpRight:
                        person.YPos++;
                        person.XPos++;
                        break;

                    case DownLeft:
                        person.YPos--;
                        person.XPos--;
                        break;

                    case DownRight:
                        person.YPos--;
                        person.XPos++;
                        break;
                }

            }
        }
    }
}
