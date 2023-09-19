// See https://aka.ms/new-console-template for more information

//-1- Variable
using MonOutil;

string? userName;

//-2- Code
Console.Write("Bonjour, quel est votre nom?: ");
userName = Console.ReadLine();

//Alternatif à Console.WriteLine("Bienvenue " + userName + " à MonOutil.");
Console.WriteLine($"Bienvenue {userName} à MonOutil.");

new Meteo();