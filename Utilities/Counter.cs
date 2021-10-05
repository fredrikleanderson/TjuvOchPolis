using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvochPolisFredrik.GameSetter;

namespace TjuvochPolisFredrik
{
    static class Counter
    {
        public static int turnsLeft = numberOfTurns;
        public static int numberOfRobberys = 0;
        public static int numberOfArrests = 0;
        public static int numberOfConfiscatedItems = 0;
        public static int policePoints = numberOfArrests + numberOfConfiscatedItems;
    }
}
