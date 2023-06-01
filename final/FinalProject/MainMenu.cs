using System;

public class MainMenu : Menu
{
    // Attributes
    private new string _menu = @"
*******************************************    
            Main Menu Options
*******************************************
Kindly choose one option from the following selection:
********************************************
1. Commence Gaming
2. Guidelines for Playing
3. Terminate or Abandon
********************************************
Select an option from the menu:  
********************************************";

    private string _welcome = @"
|||||||||||||||||||||||||||||||||||||||||||
///                                     \\\
\\\          Welcome to Hangman         ///
///                                     \\\
||||||||||||||||||||||||||||||||||||||||||||";
    private string _goodbye = @"
///////////////////////////////////////////
|||                                     |||
|||    Thank you for playing Hangman!   |||
|||                                     |||
\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\";

    // Constructors

    // Methods
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }

    public override void MenuChoice()
    {
        // Call GameMenu
        Menu gameMenu = new GameMenu();
        // Print welcome message
        PrintWelcome();

        while (_action != 3)
        {
            // switch case for main menu
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Play Game - Untimed
                    Console.Clear();
                    gameMenu.MenuChoice();
                    break;
                case 2:
                    // How to Play
                    HowToPlay info = new HowToPlay();
                    info.GetInstructions();
                    break;
                case 3:
                    // Quit
                    PrintGoodbye();
                    break;
                default:
                    Console.WriteLine("\nSorry, please enter a valid option.");
                    break;
            }
        }
    }

    private void PrintWelcome()
    {
        Console.Clear();
        Console.Write($"{_welcome}\n\n");
    }

    private void PrintGoodbye()
    {
        Console.Clear();
        Console.Write($"{_goodbye}\n\n");
    }
}
