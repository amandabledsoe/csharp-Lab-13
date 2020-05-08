using System;
using System.Collections.Generic;
using System.Text;

namespace Begin_Lab_13_MCV_Lab
{
    class Country
    {
        //Make a Country model with the following properties:
        //  ● Public string Name
        //  ● Public string Continent
        //  ● Public List<string> Colors

        //fields
        public string name;
        public string continent;
        public List<string> colors;
        
        //attributes/properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        //constructor(s) - overloaded & default
        public Country(string _name, string _continent, List<string> _colors)
        {
            name = _name;
            continent = _continent;
            colors = _colors;
        }
        public Country ()
        {

        }
    }
}
