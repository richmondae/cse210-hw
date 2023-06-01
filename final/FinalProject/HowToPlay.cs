using System;

public class HowToPlay
{
    // Attributes 
    private string _howToPlay = $@"
***********************************************    
GUIDE TO PLAYING HANGMAN
************************************************
The Game:
Hangman is a timeless word game where your goal is to uncover a secret word by guessing one letter at a time. 
At the beginning of each game, you are presented with a series of blank lines, representing the hidden letters of the word.
To play, simply guess a letter that you believe might be part of the secret word. If your guess is correct,
the corresponding blank line(s) will be filled with the guessed letter. However, if your guess is incorrect,
a part of the hangman's gallows will be drawn, bringing you closer to losing the game.

Remember, you only have a total of 7 incorrect guesses before the hangman's gallows is fully drawn.
So, choose your letters wisely and try to unravel the hidden word before it's too late.
*****************************************************
Game Rules:
*****************************************************
Guess one letter at a time to reveal the secret word.
Each incorrect guess adds another part to the hangman's gallows.
You have a maximum of 7 incorrect guesses to solve the puzzle.
Good luck and enjoy the challenge of finding the hidden word before the hangman's gallows is complete!

***************************************************
***************************************************

Now that you're familiar with the rules of Hangman, why not test your skills and play a game?

+++ Press Enter to return to menu +++";

    public void GetInstructions()
    {
        Console.Clear();  // This will clear the console

        Console.Write(_howToPlay);
        // Enter key to exit page
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();  // This will clear the console
            // Return to main menu
        }
    }

}