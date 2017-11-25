using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Demo
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Regex weather = new Regex(@"([A-Z]{2})(\d{1,2}\.\d{1,2})([A-Za-z]+)\|");

            Dictionary<string, CityTempWeather> solution = new Dictionary<string, CityTempWeather>();

            while (input != "end")
            {
                var weatherMatcher = weather.Matches(input);
                foreach (Match group in weatherMatcher)
                {
                    string cityName = group.Groups[1].Value.ToString();
                    CityTempWeather currentCity = new CityTempWeather()
                    {
                        city = group.Groups[1].Value,
                        temperature = decimal.Parse(group.Groups[2].Value),
                        cityweather = group.Groups[3].Value
                    }

                    ;
                    if (!solution.ContainsKey(cityName))
                    {
                        solution.Add(cityName, currentCity);
                    }
                    else
                    {
                        solution[cityName] = currentCity;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var city in solution.OrderBy(x => x.Value.temperature))
            {
                Console.WriteLine($"{city.Key} => {city.Value.temperature:f2} => {city.Value.cityweather}");
            }

        }


        class CityTempWeather
        {
            public string city { get; set; } 
            public string cityweather { get; set; }
            public decimal temperature { get; set; }
        }
    }
}
