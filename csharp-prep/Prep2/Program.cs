using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string textReader = Console.ReadLine();
        string letter = "";

        if (int.TryParse(textReader, out int percentage))
        {
            if (percentage >= 90)
            {
                letter = "A";
            }
            else if (percentage >= 80)
            {
                letter = "B";
            }
            else if (percentage >= 70)
            {
                letter = "C";
            }
            else if (percentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your letter grade is: {letter}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the grade percentage.");
        }
        
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("You passed, Congratulations!");
        }
        else
        {
            Console.WriteLine("Try again next time,");
        }
    }
}
