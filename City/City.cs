using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TjuvochPolisFredrik
{
    class City : ICity
    {
        //Fields
        private int rows;
        private int columns;
        private char[,] grid;
        private List<Person> people = new List<Person>();

        //Properties
        public int Rows
        {
            get { return rows; }
        }
        public int Columns
        {
            get { return columns; }
        }
        public char[,] Grid
        {
            get { return grid; }
            set { grid = value; }
        }

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }


        //Constructor
        public City(int _rows, int _columns)
        {
            rows = _rows;
            columns = _columns;
            grid = new char[_rows, _columns];
        }
    }
}
