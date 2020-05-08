using System;
using System.Collections.Generic;
using System.Text;

namespace Begin_Lab_13_MCV_Lab
{
    class CountryListView
    {
        //Next Create a CountryListView class. This view will take a list of countries in its constructor.
        //It should have the following property and method:

        //attributes/properties
        //  ● Public List<Country> Countries - store the parameter from the constructor here.
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }

        //  ● Public void Display() - Print the name of each country in the list along
        //  with the index for each country
        public void Display()
        {
            Console.WriteLine("");
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"Index: {i} -- Country Name: {Countries[i].name}");
            }
        }
    }
}
