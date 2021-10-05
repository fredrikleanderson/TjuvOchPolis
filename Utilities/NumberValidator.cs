using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolisFredrik
{
    public static class NumberValidator
    {
        public static int GetValidNumber(string type, int minNumber, int maxNumber)
        {
            bool inputAccepted = false;
            int validNumber = 0;

            while (!inputAccepted || validNumber < minNumber || validNumber > maxNumber)
            {
                Console.Clear();
                Console.WriteLine($"How many {type} do you want your game to have? Chose a number between {minNumber} and {maxNumber}.");
                inputAccepted = Int32.TryParse(Console.ReadLine(), out validNumber);
            }

            return validNumber;
        }
    }
}
