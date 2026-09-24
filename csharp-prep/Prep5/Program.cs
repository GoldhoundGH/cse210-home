using System;

class Program
{
    static void GetYear(out int year)
    {
        Console.Write("What year were you born? ");
        string input = Console.ReadLine();
        year = int.Parse(input);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to this program.");
    }

    static string GetName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int GetNumber()
    {
        Console.Write("What is your favorite number? ");
        string numInput = Console.ReadLine();
        int favNum = int.Parse(numInput);
        return favNum;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
        
    }

    static void DisplayResults(string name, int square, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        int age = 2026 - year;
        Console.WriteLine($"{name}, by the end of this year you will be {age} years old.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = GetName();

        int favNum = GetNumber();
        
        int year;
        GetYear(out year);

        int square = SquareNumber(favNum);

        DisplayResults(name,square,year);
    }
}