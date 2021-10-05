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
    class Police : Person
    {
        //Fields
        private IInventory confiscatedItems = CreateInventory(new List<string>());

        //Properties
        public IInventory ConfiscatedItems
        {
            get { return confiscatedItems; }
            set { confiscatedItems = value; }
        }

        //Constructor
        public Police(ICity city) : base(city) 
        {
            Name = policeNames[random.Next(0, policeNames.Length)];
        }
    }
}
