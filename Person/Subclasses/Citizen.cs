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
    class Citizen: Person
    {
        //Fields
        private IInventory belongings = CreateInventory(new List<string>() { "set of keys", "clock", "wallet", "phone" });

        //Properties
        public IInventory Belongings 
        { 
            get { return belongings; } 
            set { belongings = value; }
        }

        //Constructor
        public Citizen(ICity city) : base(city)
        {
            Name = citizenNames[random.Next(0, citizenNames.Length)];
        }
    }
}
