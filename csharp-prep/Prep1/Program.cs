using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you first name: ");
        string f_name = Console.ReadLine();

        Console.Write("What is you last name: ");
        string l_name = Console.ReadLine();

        Console.WriteLine($"Your name is {l_name}, {f_name} {l_name}.");
    }
}