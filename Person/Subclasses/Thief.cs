using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvochPolisFredrik.Creator;
using static TjuvochPolisFredrik.Randomizer;
using static TjuvochPolisFredrik.NameGenerator;

namespace TjuvochPolisFredrik
{
    class Thief : Person
    {
        //Fields
        private IInventory stolenStuff = CreateInventory(new List<string>());
        private bool isWanted = false;

        //Properties
        public IInventory StolenStuff
        {
            get { return stolenStuff; }
            set { stolenStuff = value; }
        }

        public bool IsWanted
        {
            get { return isWanted; }
            set { isWanted = value; }
        }

        //Constructor
        public Thief(ICity city) : base(city) 
        {
            Name = thiefNames[random.Next(0, thiefNames.Length)];
        }
    }
}
