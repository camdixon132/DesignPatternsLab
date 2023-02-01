using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace DesignPatternsLab
{
    internal class CountryController
	{
		//constructors
		List<Country> CountryDb = new List<Country>()
		{
				new Country("USA","North America", new List<string>{"Red, White, Blue"}),
				new Country("Japan","Asia", new List<string>{"Red, White"}),
				new Country("China","Asia", new List<string>{"Red, Yellow"}),
				new Country("Mexico", "North America", new List<string>{"Red, White, Green"}),
				new Country("Canada", "North America", new List<string>{"Red, White"})

		};

		//methods
		public void CountryAction(Country c)
		{
			CountryView view = new CountryView(c);
			view.Display();
		}
		public void WelcomeAction()
		{
			CountryListView Db = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.");

			while (true)
			{
                Console.WriteLine("Please select a country from the following list:");
                Db.Display();

                int choice = int.Parse(Console.ReadLine());
                choice -= 1;

                Country C = CountryDb[choice];
                CountryAction(C);

                Console.WriteLine("Do you want to continue? y/n");
                string answer = Console.ReadLine();
				if(answer == "n" || answer == "no")
				{
					break;
				}
            }
			

        }
    }
}

