using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Begin_Lab_13_MCV_Lab
{
    class CountryView
    {
        //Next Create a CountryView Class. In the constructor require a Country be taken inand set to DisplayCountry.
        //Create the following property and method:


        //attribute/property
        //  ● Public Country DisplayCountry
        public Country DisplayCountry { get; set; }

        //constructors
        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        //method(s)
        //  ● Public void Display() - This method will print out the Name, Continent, and Colors of 
        //    the Country DisplayCountry property
        public void Display()
        {
            Console.WriteLine($"Country: {DisplayCountry.name}");
            Console.WriteLine($"Continent: {DisplayCountry.continent}");
            Console.Write($"Colors: {DisplayCountry.colors[0]}, {DisplayCountry.colors[1]}, {DisplayCountry.colors[2]}");
            Console.WriteLine("");
        }
    }
}
