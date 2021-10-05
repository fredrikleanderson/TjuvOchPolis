using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TjuvochPolisFredrik.Randomizer;
using static TjuvochPolisFredrik.NameGenerator;
using static TjuvochPolisFredrik.Enums;

namespace TjuvochPolisFredrik
{
    abstract class Person
    {
        //Fields
        private string name;
        private int yPos;
        private int xPos;
        private int maxValueY;
        private int maxValueX;
        private Direction direction = (Direction)random.Next(0, 8);

        //Properties
        public string Name 
        {
            get { return name; } 
            set { name = value; }
        }

        public int YPos 
        { 
            get { return yPos; }
            set 
            {
                if (value < 0) yPos = MaxValueY;
                else if (value > MaxValueY) yPos = 0;
                else yPos = value;
            }
        }

        public int XPos
        {
            get { return xPos; }
            set 
            {
                if (value < 0) xPos = MaxValueX;
                else if (value > MaxValueX) xPos = 0;
                else xPos = value;
            }
        }

        public int MaxValueY
        {
            get { return maxValueY; }
        }

        public int MaxValueX
        {
            get { return maxValueX; }
        }

        public Direction Direction
        {
            get { return direction; }
        }

        //Constructor
        public Person(ICity city)
        {
            yPos = random.Next(0, city.Rows);
            xPos = random.Next(0, city.Columns);
            maxValueY = city.Rows - 1;
            maxValueX = city.Columns - 1;
        }
    }
}
