using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static TjuvochPolisFredrik.Messenger;
using static TjuvochPolisFredrik.GameSetter;
using static TjuvochPolisFredrik.Creator;
using static TjuvochPolisFredrik.Logger;
using static TjuvochPolisFredrik.Printer;
using static TjuvochPolisFredrik.Counter;
using static TjuvochPolisFredrik.Mover;
using static TjuvochPolisFredrik.EncounterTracker;

namespace TjuvochPolisFredrik
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            StartNewGame();
            ICity city = CreateCity(25, 100);
            CreatePersonList(city, numberOfCitizens, numberOfThieves, numberOfPoliceOfficers);

            for (int i = 0; i < numberOfTurns; i++)
            {
                UpdateCity(city);
                PrintCity(city);
                MovePeople(city);
                CheckForEncounter(city);
                turnsLeft--;
                Thread.Sleep(500);
            }

            GoodbyeMessage();
            Console.ReadKey();
        }
    }
}
