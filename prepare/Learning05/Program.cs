using System;

class Program
{
    static void Main(string[] args)
    {
        TestClass bobTest = new TestClass();
        Func<string> bob = bobTest.TestFunction;

        string bobAnswer = bob();
    }
}