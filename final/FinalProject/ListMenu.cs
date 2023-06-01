using System;

public class ListMenu : Menu
{
    // Attributes 
    private new string _menu = $@"
*******************************************    
                List Options
*******************************************
Here are the available Options for you to choose from:
*******************************************
1. Choices for colors
2. Selections related to sports
3. Alternatives pertaining to seasons
4. Return to the game menu
*******************************************
Which set of options are you interested in utilizing? 
*******************************************";

    // Constructors


    // Methods
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        while (_action != 4)
        // switch case for list menu
        {
            Hangman game = new Hangman();
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Console.WriteLine("Success Choice 1!");
                    _wordFileName = "colors.txt";
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    _wordFileName = "sports.txt";
                    game.StartGame(_wordFileName);
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    _wordFileName = "seasons.txt";
                    game.StartGame(_wordFileName);
                    // Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Back to Main Menu
                    Console.Clear();  // This will clear the console
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}