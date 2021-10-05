using System;
using System.Collections.Generic;
namespace TjuvochPolisFredrik
{
    interface ICity
    {
        char[,] Grid { get; set; }
        int Columns { get; }
        int Rows { get; }
        List<Person> People { get; set; }
    }
}