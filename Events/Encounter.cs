using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static TjuvochPolisFredrik.Counter;
using static TjuvochPolisFredrik.Randomizer;
using static TjuvochPolisFredrik.Printer;
using static TjuvochPolisFredrik.Program;

namespace TjuvochPolisFredrik
{
    static class Encounter
    {
        public static void Robbery(Thief thief, Citizen citizen)
        {
            Console.Write($"\aThe thief {thief.Name} attempts to rob the citizen {citizen.Name}...");
            Thread.Sleep(2000);

            if (citizen.Belongings.Items.Count == 0)
            {
                Console.WriteLine($" but {citizen.Name} had nothing to steal.");
                Thread.Sleep(2000);
            }
            else
            {
                numberOfRobberys++;
                int randomIndex = random.Next(0, citizen.Belongings.Items.Count);
                Console.WriteLine($" and successfully steals a {citizen.Belongings.Items[randomIndex]}.");
                thief.StolenStuff.Items.Add(citizen.Belongings.Items[randomIndex]);
                citizen.Belongings.Items.RemoveAt(randomIndex);
                Thread.Sleep(2000);
            }
        }

        public static void Arrest(Police police, Thief thief)
        {
            Console.Write($"\aThe police {police.Name} stops and strip searches {thief.Name}...");
            Thread.Sleep(2000);

            if (thief.StolenStuff.Items.Count == 0)
            {
                Console.WriteLine($" but {thief.Name} hadn't stolen anything.");
                Thread.Sleep(2000);
            }
            else
            {
                numberOfArrests++;
                string[] confiscatedItems = new string[thief.StolenStuff.Items.Count];
                numberOfConfiscatedItems += confiscatedItems.Length;
                thief.StolenStuff.Items.CopyTo(confiscatedItems);
                thief.StolenStuff.Items.Clear();
                Console.WriteLine($" and confiscates the following items:\n");

                foreach (string item in confiscatedItems)
                {
                    Console.WriteLine($"- A {item}");
                    police.ConfiscatedItems.Items.Add(item);
                }
                Array.Clear(confiscatedItems, 0, confiscatedItems.Length);
                Thread.Sleep(2000);              
            }
        }
    }
}
