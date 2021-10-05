using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolisFredrik
{
    class Inventory : IInventory
    {
        //Fields
        private List<string> items;

        //Properties
        public List<string> Items
        {
            get { return items; }
            set { items = value; }
        }

        //Constructor
        public Inventory(){}
        public Inventory(List<string> _items)
        {
            items = _items;
        }
    }
}
