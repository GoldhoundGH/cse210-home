using System;
using System.IO;

class Program
{
    static string sep = "^^^";
    static string path = @"C:\Journals\";
    static int ShowMenu()
    {
        int pass = 0;
        List<int> validOptions = new List<int> {0,1,2,3,4};
        int intUserInput = 5;

        while (pass == 0) {
            Console.WriteLine ("Select an option: ");
            Console.WriteLine (" 1 - Write an entry");
            Console.WriteLine (" 2 - Display entries");
            Console.WriteLine (" 3 - Load a journal");
            Console.WriteLine (" 4 - Save entries to journal");
            Console.WriteLine (" 0 - Exit program");
            Console.Write("Enter your selection: ");
            string menuUserInput = Console.ReadLine();

            intUserInput = int.Parse(menuUserInput);
            
            if (validOptions.Contains(intUserInput)) {pass = 1;} else
            {
                Console.WriteLine();
                Console.WriteLine("Your selection is not on the provided list.  Please select an appropriate number.");
            }
        }
        return intUserInput;
    }

    static void Write(Journal thisJournal)
    {
        thisJournal._entries.Add(thisJournal.NewEntry());
        Console.WriteLine("Entry recorded.");
    }
    static void Display(Journal thisJournal)
    {
        Console.WriteLine("");
        foreach (Entry entry in thisJournal._entries)
        {
            Console.WriteLine($"{entry._date}: \"{entry._prompt}\" - {entry._response} \n");
        }
        Console.Write("Press enter to continue...");
        Console.ReadLine();
    }

    static Journal Load()
    {
        Console.Write("Enter the name of the journal to load: ");
        string fileName = Console.ReadLine();
        if (fileName.Contains(".txt") != true) {fileName = fileName + ".txt";}

        string[] lines = File.ReadAllLines(path + fileName);

        Journal loadJournal = new Journal();
        foreach (string line in lines)
        {
            Entry loadEntries = new Entry();
            string[] parts = line.Split(sep);


            loadEntries._date = parts[0];
            loadEntries._prompt = parts[1];
            loadEntries._response = parts[2];

            loadJournal._entries.Add(loadEntries);
        }

        return loadJournal;
    }
    static void Save(Journal thisJournal)
    {
        Directory.CreateDirectory(path);
        Console.Write("Please give this journal a title: ");
        string fileName = Console.ReadLine();
        if (fileName.Contains(".txt") != true) {fileName = fileName + ".txt";}

        // string sep = "^^^";
        using (StreamWriter outputFile = new StreamWriter($"{path}{fileName}"))
        {
            foreach (Entry entry in thisJournal._entries)
            {
                Console.WriteLine($"{entry._date}{sep}{entry._prompt}{sep}{entry._response}\n");
                outputFile.WriteLine($"{entry._date}{sep}{entry._prompt}{sep}{entry._response}");
            }
        }

        Console.WriteLine($"This journal has been saved in '{fileName}'.\n"); 
    }

    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();

        int runProgram = 1;
        while (runProgram == 1) {
            int userInput = ShowMenu();

            if (userInput == 1) {Write(currentJournal);}
            else if (userInput == 2) {Display(currentJournal);}
            else if (userInput == 3) {currentJournal = Load();}
            else if (userInput == 4) {Save(currentJournal);}
            else if (userInput == 0) {runProgram = 0;}
            else
            {
                Console.WriteLine ("Invalid response.  Please enter a number from the given list.");
            }
            
        }
    }
}