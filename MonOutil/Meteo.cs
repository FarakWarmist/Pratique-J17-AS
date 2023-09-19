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
            string? tempA;
            double tempB;
            double convert;
            string? tempType;
            string? tempSymbol;

            Console.WriteLine("Bivenue à l'outil Météo.");
            Console.WriteLine("Voulez-vous convertir la température en Celsius (C) ou en Fahrenheit (F)? : \n(C/F)");

            while (true)
            {
                tempType = Console.ReadLine();
                if (tempType == "f" || tempType == "F")
                {
                    Console.Write("Quelle est la température actuelle en celsius?: ");
                    tempA = Console.ReadLine();
                    convert = Convert.ToDouble(tempA);
                    tempB = (convert * 9 / 5) + 32;
                    tempSymbol = "°F";
                    break;
                }
                else if (tempType == "c" || tempType == "C")
                {
                    Console.Write("Quelle est la température actuelle en fahrenheit?: ");
                    tempA = Console.ReadLine();
                    convert = Convert.ToDouble(tempA);
                    tempB = Math.Round((convert - 32) * 5 / 9, 2);
                    tempSymbol = "°C";
                    break;
                }
                else
                {
                    Console.WriteLine("Veillez entrer C ou F");

                }
            }

            Console.WriteLine($"Il fait présentement {tempB}{tempSymbol}.");
        }
    }
}
