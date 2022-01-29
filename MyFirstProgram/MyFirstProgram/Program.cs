using System;
using MyUtilities;

namespace MyFirstProgram
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go in May?");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelcius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelcius(77), 55);
            WeatherUtilities.Report("San Mateo", 23, 65);
        }
    }
}
