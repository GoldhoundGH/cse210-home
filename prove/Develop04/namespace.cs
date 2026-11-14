namespace ProjUniversal
{
public static class ProjFuncs {
    public static void AnimPause(int dur)
    {
        List<string> animLib = ["—","\\","|","/"];
        DateTime timeNow = DateTime.Now;
        DateTime timeEnd = timeNow.AddSeconds(dur);
        while (timeNow < timeEnd)
        {
            foreach (string s in animLib)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
                timeNow = DateTime.Now;
            }
        }
    }
    public static void PauseCount(string message, int dur)
        {
            Console.Write($"{message} ");
            while (dur > 0) {
                Console.Write ("\b \b");
                Console.Write(dur);
                Thread.Sleep(1000);
                dur -= 1;
            }
            Console.Write ("\b \b\n");
        }

    public static void PauseDots(int dur)
        {
            DateTime timeNow = DateTime.Now;
            DateTime timeEnd = timeNow.AddSeconds(dur);
            int dots = 0;
            while (timeNow < timeEnd) {
                while (dots < 3) {
                    Console.Write(".");
                    Thread.Sleep(1000);
                    dots += 1;
                }
                Console.Write("\b\b\b   \b\b\b");
                dots = 0;
                timeNow = DateTime.Now;
            } 
        }
    public static void Pause(int dur)
    {
        Thread.Sleep(dur * 1000);
    }
    public static void Menu(string message, List<Activity> options)
        {
            Console.WriteLine(message);
            int count;
            count = 1;
            foreach (Activity option in options)
            {
                Console.WriteLine($"{count}. {option.GetName()}");
                count += 1;
            }
            Console.WriteLine($"{count}. Quit program");
        }
}}