using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvochPolisFredrik.Enums;
using static TjuvochPolisFredrik.Enums.PersonType;

namespace TjuvochPolisFredrik
{
    static class Creator
    {
        public static ICity CreateCity(int _rows, int _columns) => new City(_rows, _columns);

        public static IInventory CreateInventory(List<string> items) => new Inventory(items);

        public static Person CreatePerson(PersonType personType, ICity city)
        {
            switch (personType)
            {
                case citizen:
                    return new Citizen(city);

                case thief:
                    return new Thief(city);

                case police:
                    return new Police(city);

                default:
                    return new Citizen(city);
            }
        }

        public static void CreatePersonList(ICity city, int numberOfCitizens, int numberOfThieves, int numberOfPolice)
        {
            for (int i = 0; i < numberOfCitizens; i++)
            {
                city.People.Add(CreatePerson(citizen, city));
            }
            for (int i = 0; i < numberOfThieves; i++)
            {
                city.People.Add(CreatePerson(thief, city));
            }
            for (int i = 0; i < numberOfPolice; i++)
            {
                city.People.Add(CreatePerson(police, city));
            }


        }
    }
}
