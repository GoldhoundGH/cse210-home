using System;
using GoalSpace;

class Program

{
    static string Init()
    {
        Console.Write("Enter a username: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome, {name}");
        Project.AnimPause(2);
        Console.Clear();
        return name;
    }

    static void MenuError()
    {
        Console.WriteLine("Invalid response.  Please enter a number from the given list.");
        Project.Pause(1);
        Project.AnimPause(1);
    }
    
    static int MainMenu(List<Goal> goals)
    {
        List<string> menu = new List<string>(["1. Create a new goal","2. Record progress on a goal","3. Display current goals","4. Display completed goals", "5. Exit program"]);
        
        int choice = Project.PerformMenu(menu);
        int points = 0;

        if (choice == -999)
        {
            MenuError();
        }
        else if (choice == 0)
        {
            NewGoal(goals);
        }
        else if (choice == 4)
        {
            return -999;
        }
        else if (goals.Count > 0)
        {
            if (choice == 1)
            {
                points = ProgressGoal(goals);
            }
            else if (choice == 2)
            {
                DisplayGoals(goals, 0);
            }
            else if (choice == 3)
            {
                DisplayGoals(goals, 1);
            }
            else {MenuError();}
        }
        else
        {
            Console.WriteLine("You have no goals to display.  Begin by creating new goals.");
            Project.Pause(1);
            Project.AnimPause(1);
        }

        return points;
    }

    static void NewGoal(List<Goal> goals)
    {
        Console.Clear();

        Console.WriteLine("You have chosen to create a new goal.");
        Project.Pause(1);

        Console.WriteLine("What kind of goal would you like to start?");
        
        List<string> menu = new List<string>(["1. One-time goal","2. Ongoing goal","3. Multi-step goal"]);
        
        int choice = Project.PerformMenu(menu);
        

        if (choice == 0)
        {
            NewGoalSimple(goals);
        }
        else if (choice == 1)
        {
            NewGoalOngoing(goals);
        }
        else if (choice == 2)
        {
            NewGoalProgressive(goals);
        }
        else {MenuError();}

    }

    static void NewGoalSimple(List<Goal> goals)
    {
        Console.WriteLine ("You have started a new one-time goal.");
        Project.Pause(1);

        int confirm = 0;
        string name = "";
        while (confirm == 0) 
        {
            Console.Write("Enter the name of this goal: ");
            name = Console.ReadLine();
            Console.WriteLine($"You have named your new goal '{name}'. Enter 1 to confirm.");
            Console.Write(" > ");
            string response = Console.ReadLine();
            if (response == "1") {confirm = 1;}
        }
        Console.Write("Enter the point value of this goal: ");
        int value = Project.ResponseConvert(Console.ReadLine());
        
        goals.Add(new GoalSimple(name,value));

        Console.WriteLine($"\nA new one-time goal called '{name}' has been created.");
        Console.WriteLine($"It will award {value} points upon completion.");
        Project.Pause(1);
        Project.AnimPause(2);
    }
    static void NewGoalOngoing(List<Goal> goals)
    {
        Console.WriteLine ("You have started a new ongoing goal.");
        Project.Pause(1);

        int confirm = 0;
        string name = "";
        while (confirm == 0) 
        {
            Console.Write("Enter the name of this goal: ");
            name = Console.ReadLine();
            Console.WriteLine($"You have named your new goal '{name}'. Enter 1 to confirm.");
            Console.Write(" > ");
            string response = Console.ReadLine();
            if (response == "1") {confirm = 1;}
        }
        Console.Write("Enter the point value of this goal: ");
        int value = Project.ResponseConvert(Console.ReadLine());
        
        goals.Add(new GoalOngoing(name,value));
        Console.WriteLine($"\nA new ongoing goal called '{name}' has been created.");
        Console.WriteLine($"It will award {value} points every time it is completed.");
        Project.Pause(1);
        Project.AnimPause(2);
    }
    static void NewGoalProgressive(List<Goal> goals)
    {
        Console.WriteLine ("You have started a new multi-step goal.");
        Project.Pause(1);

        int confirm = 0;
        string name = "";
        while (confirm == 0) 
        {
            Console.Write("Enter the name of this goal: ");
            name = Console.ReadLine();
            Console.WriteLine($"You have named your new goal '{name}'. Enter 1 to confirm.");
            Console.Write(" > ");
            string response = Console.ReadLine();
            if (response == "1") {confirm = 1;}
        }
        Console.Write("Enter the number of steps required to complete this goal: ");
        int steps = Project.ResponseConvert(Console.ReadLine());

        Console.Write("Enter the point value for completing one step of this goal: ");
        int progressValue = Project.ResponseConvert(Console.ReadLine());

        Console.Write("Enter the point value for completing all steps: ");
        int value = Project.ResponseConvert(Console.ReadLine());
        
        goals.Add(new GoalProgressive(name,value,steps,progressValue));
        Console.WriteLine($"\nA new ongoing goal called '{name}' has been created.");
        Console.WriteLine($"It will award {value} points once every step is completed.");
        Project.Pause(1);
        Console.WriteLine($"It has {steps} stages to complete and awards {progressValue} points per stage.");
        Project.Pause(1);
        Project.AnimPause(2);
    }

    static void DisplayGoals(List<Goal> goals, int option)
    {
        Console.Clear();
        if (option != 1)
        {
            Console.WriteLine("These are your current goals: \n");
        }
        else
        {
            Console.WriteLine("These are your completed goals: \n");
        }

        foreach (Goal goal in goals)
        {
            if (goal.CheckComplete() == option)
            {
                Console.WriteLine($"\t{goal.DisplayGoal()}");
            }
            else if (goal.CheckComplete() == 2 && option == 0)
            {
                Console.WriteLine($"\t{goal.DisplayGoal()}");
            }
        }

        Console.Write("\n Press enter to return to main menu... ");
        Console.ReadLine();
    }

    static int ProgressGoal(List<Goal> goals)
    {
        Console.Clear();

        List<(Goal, int)> currentGoals = new List<(Goal,int)>();
        int index = 0;
        foreach (Goal goal in goals)
        {
            if (goal.CheckComplete() == 0 || goal.CheckComplete() == 2)
            {
                currentGoals.Add((goal,index));
            }
            index += 1;
        }

        if (currentGoals.Count() == 0)
        {
            Console.WriteLine("You have no current goals to make progress on.");
            Project.Pause(1);
            Project.AnimPause(1);
            return 0;
        }

        List<string> menu = new List<string>();
        int count = 0;
        foreach ((Goal, int) goal in currentGoals)
        {
            count += 1;
            string tag = goal.Item1.DisplayGoal();
            menu.Add($"{count}. {tag}");
        }
        int choice;
        while (true) {
            Console.WriteLine("Select a goal to record progress on: ");
            choice = Project.PerformMenu(menu);

            if (choice == -999)
            {
                MenuError();
            }
            else {break;}
        }

        int selectedGoalIndex = currentGoals[choice].Item2;
        Goal selectedGoal = goals[selectedGoalIndex];
        int points = selectedGoal.MarkComplete();

        Console.Clear();
        Console.WriteLine($"Progress recorded for '{selectedGoal.GetName()}.  You have earned {points} points.");
        Project.Pause(1);
        Project.AnimPause(1);
        if (selectedGoal.CheckComplete() == 1)
        {
            Console.WriteLine("Congradulations! You have completed this goal!");
            Project.Pause(1);
            Project.AnimPause(1);
        }

        return points;
    }



    static void DisplayHeader(string name, int score)
    {
        Console.WriteLine($"\n{name}\t\tScore: {score}\n");
    }

    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;
        string username;

        username = Init();

        int running = 1;
        while (running == 1)
        {
            Console.Clear();
            DisplayHeader(username, score);

            int points = MainMenu(goals);
            if (points == -999) {break;}
            score += points;
        }


    }
}