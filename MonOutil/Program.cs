// See https://aka.ms/new-console-template for more information

//-1- Variable
using MonOutil;

string? userName;

//-2- Code
Console.Write("Hello ! What is your name?: ");
userName = Console.ReadLine();

//Alternatif à Console.WriteLine("Bienvenue " + userName + " à MonOutil.");
Console.WriteLine($"Nice to meet you {userName}, welcome to MonOutil.");

new Meteo();