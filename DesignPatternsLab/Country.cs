using System;
namespace DesignPatternsLab
{
	public class Country
	{
		public string Name { get; set; }
		public string Continent { get; set; }
		public List<string> Colors = new List<string>();



		//contructors
		public Country(string _name, string _continent, List<string> _colors)
		{
			Name = _name;
			Continent = _continent;
			Colors = _colors;
		}
	}
}

