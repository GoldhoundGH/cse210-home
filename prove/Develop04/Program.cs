// Creativity compliance:   program uses a custom namespace for pause functions so that the can be shared without duplicating code throughout the whole program.
//                          program uses different pause functions for a more intuitive user experience.
//                          program catches invalid menu responses.

using System;
using System.Runtime.InteropServices;
using ProjUniversal;

class Program
{
    static void Main(string[] args)
    {
        BreathingAct defAct1 = new BreathingAct();
        ReflectionAct defAct2 = new ReflectionAct();
        ListingAct defAct3 = new ListingAct();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Wellness Program.\n");
            
            string message = "Please select one of the following activities: ";
            ProjFuncs.Menu(message,[defAct1,defAct2,defAct3]);
            
            string select;
            Console.Write(">  ");
            select = Console.ReadLine();
            
            Console.Clear();
            if (int.TryParse(select,out _)) {
            int selectToInt = int.Parse(select);
            if (selectToInt == 1)
            {
                defAct1.ActivityStart();
            }
            else if (selectToInt == 2)
            {
                defAct2.ActivityStart();
            }
            else if (selectToInt == 3)
            {
                ListingAct act3 = new ListingAct();
                act3.ActivityStart();
            }
            else if (selectToInt == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Your selection is not on the list. Please try again.");
                ProjFuncs.PauseDots(3);
            }}
            else
            {
                Console.WriteLine("Please enter a number.");
                ProjFuncs.PauseDots(3);
            }

        }
    }
}