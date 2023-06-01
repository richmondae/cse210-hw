using System;

public class GallowsRenderer
{
    // Attributes
    
    // Constructors
    
    // Methods
    public void ShowGallows(int wrongGuessCount)
    {
        string[] gallows = new string[]
        {
            "\n+---+\n    |\n    |\n    |\n   ===", // 0 wrong guesses
            "\n+---+\nO   |\n    |\n    |\n   ===", // 1 wrong guess
            "\n+---+\nO   |\n|   |\n    |\n   ===", // 2 wrong guesses
            "\n+---+\n O  |\n/|  |\n    |\n   ===", // 3 wrong guesses
            "\n+---+\n O  |\n/|\\ |\n    |\n   ===", // 4 wrong guesses
            "\n+---+\n O  |\n/|\\ |\n/   |\n   ===", // 5 wrong guesses
            "\n+---+\n O  |\n/|\\ |\n/ \\ |\n   ==="  // 6 wrong guesses
        };

        if (wrongGuessCount >= 0 && wrongGuessCount < gallows.Length)
        {
            Console.WriteLine(gallows[wrongGuessCount]);
        }
        else
        {
            Console.WriteLine("Invalid wrong guess count.");
        }
    }
}
