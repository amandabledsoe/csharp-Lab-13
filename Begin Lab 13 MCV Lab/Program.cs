using System;
using System.Collections.Generic;

namespace Begin_Lab_13_MCV_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of a CountryDB list from the Country class
            //then add items to the list
            List<Country> cdb = new List<Country>();
            cdb.Add(new Country("Switzerland", "Europe", new List<string> { "red", "white", "red" }));
            cdb.Add(new Country("Australia", "Australia", new List<string> { "blue", "red", "white" }));
            cdb.Add(new Country("Mexico", "North America", new List<string> { "white", "green", "red" }));
            cdb.Add(new Country("Equador", "South America", new List<string> { "yellow", "red", "blue" }));

            //call the WelcomeAction method from the CountryController class and pass the cdb list through it
            CountryController cc = new CountryController(cdb);
            cc.WelcomeAction();

        }
    }
}
