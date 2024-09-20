// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your first name?");
string fName = Console.ReadLine();

Console.WriteLine("\nWhat is your last name?");
string surname = Console.ReadLine();

Console.WriteLine($"\nthe name is {surname}, {fName} {surname}.");