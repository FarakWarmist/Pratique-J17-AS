using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonOutil
{
    internal class Monnaie
    {
        public Monnaie() 
        {
            string? monnaieA;
            string? monnaieB;
            string? monnaieAType;
            string? monnaieBType;
            string? montant;
            double montantConvert;
            double monnaieConvert;

            Console.WriteLine("Bivenue à l'outil de Monnaie.");
            Console.WriteLine("Quelle est le type de monnaie que vous voulez convertir? : \n Canadien (C) \n Américain (A) \n Euro (E)");
            
            // Choix du type de monnaie à convertir
            while (true)
            {
                monnaieA = Console.ReadLine();
                if (monnaieA == "C" || monnaieA == "c")
                {
                    monnaieAType = "canadien";
                    break;
                }
                else if (monnaieA == "A" || monnaieA == "a")
                {
                    monnaieAType = "américain";
                    break;
                }
                else if (monnaieA == "E" || monnaieA == "e")
                {
                    monnaieAType = "euro";
                    break;
                }
                else
                {
                    Console.WriteLine("Veuillez entrez un des choix proposé. C, A ou E");
                }
            }

            Console.Write("Quel est le montant d'argent? :");
            montant = Console.ReadLine();
            montantConvert = Convert.ToDouble(montant);

            // Choix de en quoi on veut le convertir
            Console.WriteLine("En quoi voulez-vous le convertir? C, A ou E?");

            while(true)
            {
                monnaieB = Console.ReadLine();
                if (monnaieB == "a" ||  monnaieB == "A")
                {
                    monnaieBType = "américain";
                    if (monnaieAType == "américain")
                    {
                        Console.WriteLine("La monnaie est déjà en dollar américain. Veuillez sélectionner en Canandien (C) ou en Euro (E) :");
                    }
                    else
                    {
                        break;
                    }
                }
                else if (monnaieB == "c" ||  monnaieB == "C")
                {
                    monnaieBType = "canadien";
                    if (monnaieAType == "canadien")
                    {
                        Console.WriteLine("La monnaie est déjà en dollar canadien. Veuillez sélectionner en Américain (A) ou en Euro (E) :");
                    }
                    else
                    {
                        break;
                    }
                }
                else if (monnaieB == "e" || monnaieB == "E")
                {
                    monnaieBType = "euro";
                    if (monnaieAType == "euro")
                    {
                        Console.WriteLine("La monnaie est déjà en euro. Veuillez sélectionner en Canandien (C) ou en Américain (A) :");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrez un des choix proposé. C, A ou E");
                }
            }

            //Convertissement
            if (monnaieAType == "canadien")
            {   // Canadien => Américain
                if (monnaieB == "a" || monnaieB == "A")
                {
                    monnaieConvert = montantConvert * 0.74;
                    Console.WriteLine($"{montant}$ {monnaieAType} équivaut à {monnaieConvert}$ {monnaieBType}.");
                }
                // Canadien => Euro
                else if (monnaieB == "e" || monnaieB == "E")
                {
                    monnaieConvert = montantConvert * 0.70;
                    Console.WriteLine($"{montant}$ {monnaieAType} équivaut à {monnaieConvert}$ {monnaieBType}.");
                }
            }
            else if (monnaieAType == "américain")
            {   // Américain => Canadien
                if (monnaieB == "c" || monnaieB == "C")
                {
                    monnaieConvert = montantConvert * 1.34;
                    Console.WriteLine($"{montant}$ {monnaieAType} équivaut à {monnaieConvert}$ {monnaieBType}.");
                }
                // Américain => Euro
                else if (monnaieB == "e" || monnaieB == "E")
                {
                    monnaieConvert = montantConvert * 0.94;
                    Console.WriteLine($"{montant}$ {monnaieAType} équivaut à {monnaieConvert}$ {monnaieBType}.");
                }
            }
            else if (monnaieAType == "euro")
            {   // Euro => Canadien
                if (monnaieB == "c" || monnaieB == "C")
                {
                    monnaieConvert = montantConvert * 1.44;
                    Console.WriteLine($"{montant}$ {monnaieAType} équivaut à {monnaieConvert}$ {monnaieBType}.");
                }
                // Euro => Américain
                else if (monnaieB == "a" || monnaieB == "A")
                {
                    monnaieConvert = montantConvert * 1.07;
                    Console.WriteLine($"{montant}$ {monnaieAType} équivaut à {monnaieConvert}$ {monnaieBType}.");
                }
            }
        }
    }
}
