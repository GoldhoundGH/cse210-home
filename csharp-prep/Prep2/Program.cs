using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the student's grade? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter;
        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade < 70)
        {
            letter = "D";
        }
        else if (grade < 80)
        {
            letter = "C";
        }
        else if (grade < 90)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }

        string message;
        if (grade >= 70)
        {
            message = "You passed the class. Good job.";
        }
        else
        {
            message = "You did not pass the class. Better luck next time.";
        }

        Console.WriteLine($"\nYour letter grade is '{letter}'. {message}");
    }
}