using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvochPolisFredrik.NumberValidator;

namespace TjuvochPolisFredrik
{
    static class GameSetter
    {
        public static int numberOfCitizens;
        public static int numberOfThieves;
        public static int numberOfPoliceOfficers;
        public static int numberOfTurns;

        public static void StartNewGame()
        {
            numberOfCitizens = GetValidNumber("citizens", 20, 40);
            numberOfThieves = GetValidNumber("thieves", 15, 30);
            numberOfPoliceOfficers = GetValidNumber("police officers", 10, 20);
            numberOfTurns = GetValidNumber("turns", 100, 1000);
        }

    }
}
