using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);
        int guessNumber;

        do
        {
            Console.WriteLine("What is your guess: ");
            string textGuessNumber = Console.ReadLine();
            guessNumber = int.Parse(textGuessNumber);

            if (randomNumber == guessNumber)
            {
                Console.WriteLine("Congratulations! You got it!");
            }
            else if (randomNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
        }
        while (randomNumber != guessNumber);
    }
}
