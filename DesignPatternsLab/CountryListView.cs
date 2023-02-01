using System;
using DesignPatternsLab;

namespace DesignPatternsLab
{
	public class CountryListView
	{
		//properties
		public List<Country> Countries { get; set; }

		//constructors
		public CountryListView(List<Country> _countries)
		{
			Countries = _countries; 
		}

		//methods
		public void Display()
		{
			int counter = 1;

			foreach (Country name in Countries)
			{
				Console.WriteLine($"{counter}: {name.Name}");
				counter++;
			}
        }
	}
}

