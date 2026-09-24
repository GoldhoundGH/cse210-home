using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers, ending with 0 to stop: ");

        bool flag = true;
        int number;
        float total = 0;
        while (flag == true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
                total = total + number;
            }
            else
            {
                flag = false;
            }
        }

        float average = total / numbers.Count;

        int high = 0;
        foreach (int entry in numbers)
        {
            if (entry > high)
            {high = entry;}
        }

        Console.WriteLine($"The sum of your entries is {total}.");
        Console.WriteLine($"The average of your entries is {average}.");
        Console.WriteLine($"The highest number of your entries was {high}.");

    }
}