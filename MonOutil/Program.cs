// See https://aka.ms/new-console-template for more information

//-1- Variable
using MonOutil;
using System;

string? userName;
string? outil;

//-2- Code
Console.Write("Bonjour, quel est votre nom?: ");
userName = Console.ReadLine();
//Alternatif à Console.WriteLine("Bienvenue " + userName + " à MonOutil.");
Console.WriteLine($"Bienvenue {userName} à MonOutil.");

Console.WriteLine("Quel outil voulez-vous utiliser? Monnaie ou Météo?");
while (true)
{
    outil = Console.ReadLine();
    if (outil == "Monnaie" || outil == "monnaie")
    {
        new Monnaie();
        break;
    }
    else if (outil == "Météo" || outil == "météo" || outil == "Meteo" || outil == "meteo")
    {
        new Meteo();
        break;
    }
    else
    {
        Console.WriteLine("Veillez entrer Monnaie ou Météo");

    }
}
