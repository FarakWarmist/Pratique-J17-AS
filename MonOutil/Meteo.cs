using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonOutil
{
    internal class Meteo
    {
        public Meteo()
        {
            string? tempCelsius;
            double tempFahrenheit;
            double convert;

            Console.WriteLine("Welcome to the Weather tool.");
            Console.Write("What is the current temperature in celsius?: ");
            tempCelsius = Console.ReadLine();
            convert= Convert.ToDouble(tempCelsius);
            tempFahrenheit = (convert * 9 / 5) + 32;

            Console.WriteLine($"It's currently {tempFahrenheit}°F.");
        }
    }
}
