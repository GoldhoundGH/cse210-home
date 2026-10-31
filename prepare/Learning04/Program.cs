using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment();
        math1.SetName("Bob Hope");
        math1.SetTopic("Long Division");
        math1.SetProblems("1-12");
        math1.SetSection("Comedy Math");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomework());

        WritingAssignment write1 = new WritingAssignment();
        write1.SetName("Bing Crosby");
        write1.SetTopic("Movies in the 40's");
        write1.SetTitle("Why Bob Hope is No Good in the 'Road To' Movies Series");

        Console.WriteLine();
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingHomework());
    }
}