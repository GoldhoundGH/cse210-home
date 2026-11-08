using ProjUniversal;

public class BreathingAct : Activity
{
    public BreathingAct()
    {
        SetName("Mind Reseting Breathing");
        SetDesc("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // SetActivity(PerformBreathing); // test pass function line
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
            PerformBreathing();
            timeNow = DateTime.Now;
        }
        MessageEnd();        
    }
    // private string PerformBreathing() // test pass function line
    private void PerformBreathing()
    {
        ProjFuncs.PauseCount("Breathe in...",5);
        ProjFuncs.PauseCount("Breathe out...", 8);

        // return "";  // test pass function line
    }
}