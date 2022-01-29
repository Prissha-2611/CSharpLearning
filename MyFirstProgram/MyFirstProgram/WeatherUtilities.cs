using System;
namespace MyUtilities
{
    class WeatherUtilities
    {
        //static float FahrenheitToCelcius(float temperatureFahrenheit)
        //{
        //    var temperatureCelcius = temperatureFahrenheit - 32 / 1.8f;
        //    return temperatureCelcius;
        //}
        public static float FahrenheitToCelcius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }

        //static float CelciusToFahrenheit(float temperatureCelcius)
        //{
        //    var temperatureFahrenheit = temperatureCelcius * 1.8f + 32;
        //    return temperatureFahrenheit;
        //}
        public static float CelciusToFahrenheit(float temperatureCelcius)
        {
            return temperatureCelcius * 1.8f + 32;
        }

        //static float ComfortIndex(float temperatureFahrenheit,float humidityPercent)
        //{
        //    var comfortIndex = (temperatureFahrenheit + humidityPercent) / 4;
        //    return comfortIndex;
        //}
        private static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            return (temperatureFahrenheit + humidityPercent) / 4;
        }

        //static void Report(string location,float temperatureCelcius,float humidityPercent)
        //{
        //    var temperatureFahrenheit = CelciusToFahrenheit(temperatureCelcius);
        //    Console.WriteLine("Comfort Index for " + location + ":" + ComfortIndex(temperatureFahrenheit, humidityPercent));
        //}
        public static void Report(string location, float temperatureCelcius, float humidityPercent)
        {
            var temperatureFahrenheit = CelciusToFahrenheit(temperatureCelcius);
            Console.WriteLine($"Comfort Index for {location}:{ComfortIndex(temperatureFahrenheit, humidityPercent)}");
        }
    }
}
