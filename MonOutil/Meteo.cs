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

            Console.WriteLine("Bivenue à l'outil Météo.");
            Console.Write("Quelle est la température actuelle en celsius?: ");
            tempCelsius = Console.ReadLine();
            convert= Convert.ToDouble(tempCelsius);
            tempFahrenheit = (convert * 9 / 5) + 32;

            Console.WriteLine($"Il fait présentement {tempFahrenheit}°F.");
        }
    }
}
