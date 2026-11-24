using System.Runtime.InteropServices;

namespace GoalSpace
{
public static class Project {
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
    public static void DisplayMenu(List<string> menu)
        {
            foreach (string option in menu)
            {
                Thread.Sleep(500);
                Console.Write("      ");
                Console.WriteLine(option);
            }
        }

    public static int PerformMenu(List<string> menu)
        {
            int len = menu.Count();
            foreach (string option in menu)
            {
                Thread.Sleep(100);
                Console.Write("      ");
                Console.WriteLine(option);
            }

            Console.Write(" > ");
            string response = Console.ReadLine();
            int choice = -999;
            if (int.TryParse(response, out int number))
            {
                choice = GetIndex(response);
            }
            else
            {
                choice = -999;
            }
            return choice;
        }

    public static int GetIndex(string number)
        {
            int fix = int.Parse(number);
            return fix - 1;
        }

    public static int ResponseConvert(string response)
        {
            return int.Parse(response);
        }
}}