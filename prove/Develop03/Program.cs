// Stretch and Creativity:
// - program only hides words that are not already hidden.
// - program allows user to reset scripture and show all words again.
// - program gives user multiple scriptures to choose from.


using System;
using System.Resources;
using System.Runtime.InteropServices;

class Program
{

    static void ScriptureDisplay(Scripture scripture)
    {
        Console.Clear();

        string option;
                
        while (scripture.RemainingWords() > 0) 
        {
            scripture.DisplayReference();
            scripture.DisplayScripture();
            Console.WriteLine("\n");
            Console.Write("Press Enter to continue, type 'reset' to start over, or type 'quit' to exit the program: ");
            option = Console.ReadLine();
            
            if (option.ToLower() == "reset") {scripture.ResetScripture();}
            else if (option.ToLower() == "quit")
            {
                Console.Clear();
                break;
            }
            else {scripture.RunHideWord();}

            Console.Clear();
        }
    }
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference1 = new Reference("John","3","16","For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture scripture1 = new Scripture(reference1);

        Reference reference2 = new Reference("Words of Mormon","1","13","14","13 And it came to pass also that the armies of the Lamanites came down out of the land of Nephi, to battle against his people. But behold, king Benjamin gathered together his armies, and he did stand against them; and he did fight with the strength of his own arm, with the sword of Laban.\n 14 And in the strength of the Lord they did contend against their enemies, until they had slain many thousands of the Lamanites. And it came to pass that they did contend against the Lamanites until they had driven them out of all the lands of their inheritance.");
        Scripture scripture2 = new Scripture(reference2);

        Reference reference3 = new Reference("Mosiah","2","41","And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
        Scripture scripture3 = new Scripture(reference3);
        
        List<Scripture> scriptures = new List<Scripture>{scripture1,scripture2,scripture3};

        Console.WriteLine("Select a scripture:");

        int count = 1;
        foreach (Scripture script in scriptures)
        {
            Console.Write($"  {count} - ");
            script.DisplayReference();
            count += 1;
        }
        Console.Write(" > ");
        string option = Console.ReadLine();

        ScriptureDisplay(scriptures[int.Parse(option) - 1]);
    }
}