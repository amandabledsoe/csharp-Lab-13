using System;
using System.Collections.Generic;
using System.Text;

namespace Begin_Lab_13_MCV_Lab
{
        //Lastly make a CountryController class. This class will be the big boss of your app.
        //This class should have the following properties and methods:
    class CountryController
    {
        //attributes/properties
        //  ● List<Country> CountryDb - this stands in for our country database.
        //    We’ll learn those later, but know the info from the database gets stored in a list
        public List<Country> CountryDB { get; set; } = new List<Country>();

        //constructor(s)
        public CountryController(List<Country> _countryDB)
        {
            CountryDB = _countryDB;
        }

        //  ● Public void CountryAction(Country c) - This will take in a Country
        //    model, passing the model into the CountryView constructor, and call
        //    Display Country on your CountryView object.
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        //  ● Public void WelcomeAction() - This will take no parameter and pass CountryDb into the CountryListView class. 
        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            bool runAction = true;
            while(runAction)
            {
                // pass countryDB into CountryListView
                CountryListView clv = new CountryListView(CountryDB);

                //  Then, it will print “Hello, welcome to the country app.Please select a country from the following list:” 
                //  Then it will call Display() on the CountryListView.
                clv.Display();

                //  Next allow the user to select a country by index.
                //  Upon getting the country out of CountryDb, pass that country along to the CountryAction() method.
                try
                {
                    string indexChoice = Console.ReadLine();
                    int.TryParse(indexChoice, out int index);
                    if(index <= CountryDB.Count || index >= 0)
                    {
                        CountryAction(CountryDB[index]);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("I'm sorry, that number is not a valid Country index.");
                }

                //   After that’s done, ask if the user would like to learn about another country.
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to learn about another country? (y/n)");
                    string userContinue = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine("");
                    if(userContinue == "y" || userContinue == "yes")
                    {
                        runAction = true;
                    }
                    else if(userContinue == "n" || userContinue == "no")
                    {
                        Console.WriteLine("Thank you for running our country app!");
                        runAction = false;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, I can only accept yes or no responses.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The statement hit the exception in the catch. Please try again.");
                }
            }
        }
    }
}
