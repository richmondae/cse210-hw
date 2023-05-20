using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop5 World! ");
        // Use to convert text to title case
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        GoalManagement goals = new GoalManagement();

        Console.Clear();  // This will clear the console
        Console.Write($" You have {goals.GetTotalPoints()} points!");
        //Call MainMenu
        MainMenu choice = new MainMenu();
        //Call GoalMenu
        GoalMenu goalChoice = new GoalMenu();


        int action = 0;
        while (action != 6)
        // switch case for main menu
        {
            // Ask for user input (1-6)
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Create New Goal
                    Console.Clear();  // This will clear the console
                    // Ask for user input (1-4)
                    int goalInput = 0;
                    while (goalInput != 5)
                    // switch case for goals menu
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                // Simple Goal
                                Console.WriteLine("write the name of your goal?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Please write  a short description of your goal?  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("Please Enter the amount of points associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(sGoal);
                                goalInput = 5;
                                break;
                            case 2:
                                // Eternal Goal
                                Console.WriteLine("write the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Please write  a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("Please Enter the amount of points associated with this goal? ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eGoal);
                                goalInput = 5;
                                break;
                            case 3:
                                // Checklist Goal
                                Console.WriteLine("write the name of your goal? ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Please write  a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("Please Enter the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("Enter the anount of time this goal need to be accomplished to receive a bonus?  ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goals.AddGoal(clGoal);
                                goalInput = 5;
                                break;
                            case 4:
                                // Negative Goal
                                Console.WriteLine("write the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Please write  a short description of your goal? ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("Please Enter the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                NegativeGoal nGoal = new NegativeGoal("Negative Goal:", name, description, points);
                                goals.AddGoal(nGoal);
                                goalInput = 5;
                                break;
                            case 5:
                                // Exit
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    // List Goals
                    Console.Clear();  // This will clear the console
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.ListGoals();
                    break;
                case 3:
                    // Save Goals
                    goals.SaveGoals();
                    break;
                case 4:
                    // Load Goals
                    Console.Clear();  // This will clear the console
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.LoadGoals();
                    break;
                case 5:
                    // Record Event
                    Console.Clear();  // This will clear the console
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    // Quite
                    Console.WriteLine("\nThank you for using this Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nInvalid Option please Enter a valid option.");
                    break;
            }
        }
    }
}