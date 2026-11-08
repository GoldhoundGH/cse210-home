using ProjUniversal;

public class ReflectionAct : Activity
{
    private List<string> _prompts;
    private List<string> _reflectPrompts;

    public ReflectionAct ()
    {
        SetName("Self Reflection");
        SetDesc("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
        _reflectPrompts = ["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"];
    }

    public void ActivityStart()
    {
        MessageStart();
        SetDuration();
        MessageReady();

        Console.Clear();

        Random randPrompt = new Random();
        int number = randPrompt.Next(0,_prompts.Count());

        Console.WriteLine(_prompts[number]);
        ProjFuncs.PauseDots(3);
        
        DateTime timeNow = DateTime.Now;
        DateTime timeEnd = timeNow.AddSeconds(RetDuration());

        int performReflect = 1;
        while (timeNow < timeEnd)
        {
            performReflect = PerformReflection();
            if (performReflect == 0) {break;}
            timeNow = DateTime.Now;
        }
        MessageEnd();        
    }

    private int PerformReflection()
    {
        if (_reflectPrompts.Count() == 0) {
            Console.WriteLine("You have completed all the reflection questions.");
            ProjFuncs.PauseDots(3);
            
            return 0;
        }
            Random randReflect = new Random();
            int num = randReflect.Next(0,_reflectPrompts.Count());

            Console.WriteLine(_reflectPrompts[num]);
            _reflectPrompts.RemoveAt(num);
            
            ProjFuncs.AnimPause(10);

            return 1;
    }
}