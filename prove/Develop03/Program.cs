using System;

namespace RetentionTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Develop03 World!");
            Reference reference = new Reference("1Nephi", 3, 7);
            string scriptureWords = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
            Scripture scripture = new Scripture(reference, scriptureWords);

            while (scripture.HasWordsLeft())
            {
                scripture.DisplayScripture();
                Console.Write("Press Enter to continue or type 'q' to quit(Finish): ");
                var key = Console.ReadKey();

                if (key.KeyChar == 'q' || key.KeyChar == 'Q')
                {
                    break; // Exit the while loop if the user presses Q
                }

                Console.WriteLine();
                scripture.RemoveWord();
            }

            if (!scripture.HasWordsLeft())
            {
                Console.WriteLine("Congratulations Richmond, you have memorized the entire scripture!");
            }

            Console.ReadKey();
        }
    }
}        