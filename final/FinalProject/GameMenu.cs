using System;

public class GameMenu : Menu
{
    private new string _menu = $@"
*******************************************
       Available Gaming Choices
*******************************************
Available Game Options:
*******************************************
1. Random Word Selection
2. Choose a Word Category
3. Return to Main Menu
*********************************************
Which game are you interested in playing?  
*********************************************";

    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }

    public override void MenuChoice()
    {
        Menu listMenu = new ListMenu();
        int action = 0;

        while (action != 3)
        {
            action = UserChoice();

            switch (action)
            {
                case 1:
                    string wordFileName = "words2.txt";
                    Hangman game = new Hangman();
                    game.StartGame(wordFileName);
                    break;
                case 2:
                    Console.Clear();
                    listMenu.MenuChoice();
                    break;
                case 3:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("\nSorry, please enter a valid option.");
                    break;
            }
        }
    }
}
