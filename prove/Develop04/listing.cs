using ProjUniversal;

public class ListingAct : Activity
{
    private int _number;
    private List<string> _prompts;

    public ListingAct()
    {
        SetName("Thoughtful Listing");
        SetDesc("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _prompts = ["Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];
        _number = 0;
    }

    public void ActivityStart()
    {
        MessageStart();
        SetDuration();
        MessageReady();

        Console.Clear();

        DateTime timeNow = DateTime.Now;
        DateTime timeEnd = timeNow.AddSeconds(RetDuration());

        while (timeNow < timeEnd)
        {
            PerformListing(_number);
            timeNow = DateTime.Now;
        }
        ProjFuncs.Pause(1);
        Console.WriteLine("\nYour time has concluded.");
        ProjFuncs.Pause(3);
        Console.WriteLine($"You listed {_number} responses.");
        ProjFuncs.Pause(3);
        MessageEnd();        
    }

    private void PerformListing(int num)
    {
        if (num == 0)
        {
            Random randPrompt = new Random();
            int select = randPrompt.Next(0,_prompts.Count());
            Console.WriteLine(_prompts[select]);
        }
        Console.Write($"{num + 1}. ");
        Console.ReadLine();
        _number += 1;
    }
}