using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        string capitalized = char.ToUpper(firstName[0]) + firstName .Substring(1).ToLower();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        

        Console.Write($"Your name is {lastName}, {firstName} {lastName }");

      
        
        
    }
}  