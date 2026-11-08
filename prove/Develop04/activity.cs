using System.ComponentModel;
using System.Net;
using ProjUniversal;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    // private Func<string> _activity; // test pass function line

    public void MessageStart()
    {
        Console.WriteLine($"You are now starting the {_name} activity.\n\n{_description}\n");
    }

    public void MessageReady()
    {
        Console.Write("Get ready to begin... ");
        ProjFuncs.AnimPause(5);
        Console.WriteLine();
    }
    public void MessageEnd()
    {
        Console.WriteLine("Well done.");
        ProjFuncs.Pause(2);
        Console.WriteLine($"You have completed the {_name} activity.");
        ProjFuncs.PauseDots(3);
        Console.WriteLine($"You performed this activity for {RetDuration()} seconds.");
        ProjFuncs.PauseDots(3);        
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetDesc(string desc)
    {
        _description = desc;
    }

    public void SetDuration()
    {
        Console.Write("How long would you like to perform this activity? Enter a number in seconds: ");
        string response = Console.ReadLine();
        int num = int.Parse(response);
        _duration = num;
    }

    public int RetDuration()
    {
        return _duration;
    }


    // public (DateTime, DateTime) StartClock(int dur)
    // {
    //     DateTime timeStart = DateTime.Now;
    //     DateTime timeEnd = timeStart.AddSeconds(dur);
    //     return (timeStart, timeEnd);
    // }
    // public void SetActivity(Func<string> function) // test pass function line
    // {
    //     _activity = function;
    // }
    // public void ActivityStart(int dur) // test pass function line
    // {
    //     Console.WriteLine(MessageStart());
    //     SetDuration();
    //     DateTime timeStart = DateTime.Now;
    //     DateTime timeEnd = timeStart.AddSeconds(dur);

    //     while (timeStart < timeEnd)
    //     {
    //         _activity();
    //     }
    // }

}