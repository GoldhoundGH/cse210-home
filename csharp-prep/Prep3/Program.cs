using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int masterNumber = randomNumber.Next(1,21);

        int guess = 0;

        while (guess != masterNumber)
        {
            Console.Write("Guess a number between 1 and 20: ");
            string inputGuess = Console.ReadLine();
            guess = int.Parse(inputGuess);

            if (guess != masterNumber)
            {
                if (guess > masterNumber)
                {
                    Console.WriteLine("That guess is too high.");
                }
                else
                {
                    Console.WriteLine("That guess is too low.");
                }

            }
            else
            {
                Console.WriteLine($"{guess} is the correct number!");
            }
        }
    }
}