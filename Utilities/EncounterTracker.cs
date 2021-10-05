using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvochPolisFredrik.Encounter;

namespace TjuvochPolisFredrik
{
    static class EncounterTracker
    {
        public static void CheckForEncounter(ICity city)
        {
            foreach (Person firstPerson in city.People)
            {
                foreach (Person secondPerson in city.People)
                {
                    if (firstPerson is Thief && secondPerson is Citizen
                        && firstPerson.YPos == secondPerson.YPos
                        && firstPerson.XPos == secondPerson.XPos)
                    {
                        Robbery((Thief)firstPerson, (Citizen)secondPerson);
                    }
                    if (firstPerson is Police && secondPerson is Thief
                        && firstPerson.YPos == secondPerson.YPos
                        && firstPerson.XPos == secondPerson.XPos)
                    {
                        Arrest((Police)firstPerson, (Thief)secondPerson);
                    }
                }
            }
        }


    }
}
