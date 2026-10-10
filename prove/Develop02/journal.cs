public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Entry NewEntry()
    {
        Entry thisEntry = new Entry();

        thisEntry._prompt = thisEntry.GetPrompt();

        Console.WriteLine("Enter your response to the following prompt:");
        Console.WriteLine(thisEntry._prompt);
        thisEntry._response = Console.ReadLine();
        
        DateTime now = DateTime.Now;
        thisEntry._date = now.ToShortDateString();

        return thisEntry;

    }
}