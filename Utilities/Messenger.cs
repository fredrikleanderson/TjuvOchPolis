using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static TjuvochPolisFredrik.Counter;

namespace TjuvochPolisFredrik
{
    static class Messenger
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Thieves & Police - A mindblowin' game for true adrenaline junkies");
            Thread.Sleep(2000);
            Console.WriteLine("Before you play, you have a few choices to make");
            Thread.Sleep(2000);
        }

        public static void GoodbyeMessage()
        {
            if (policePoints > numberOfRobberys)
            {
                Console.WriteLine("It looks like the police had the upper hand in this game. Well played!");
            }
            else if (policePoints < numberOfRobberys)
            {
                Console.WriteLine("Sorry to say, but the bad guys won in the end");
            }
            else Console.WriteLine("I can't belive it! We have a tied game!");
        }
    }
}
