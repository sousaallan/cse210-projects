using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number;
        do
        {
            Console.Write("Enter number: ");
            string textNumber = Console.ReadLine();
            number = int.Parse(textNumber);
            numberList.Add(number);
        }
        while (number != 0);
        foreach (int i in numberList)
        {
            Console.WriteLine(i);
        }

        //Summing the numbers in list
        int sum = numberList.Sum();
        Console.WriteLine($"The sum of numbers in list is equal to: {sum}.");
    
        //Calculating and displaying the average
        double average = numberList.Average();
        Console.WriteLine($"The average of the numbers in the list is equal to: {average}.");

        //Finding the largest number
        int largestNumber = numberList.Max();
        Console.WriteLine($"The largest number in the list is: {largestNumber}.");
    }

}