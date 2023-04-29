using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Richmond Akpama's Journal!");

        Journal journal = new Journal();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nRichmond's Jounal Menu:");
            Console.WriteLine("1. Display");
            Console.WriteLine("2. Write");
            Console.WriteLine("3. Save ");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What Would you Like to do?");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    journal.DisplayJournalEntries();
                    break;

                case 2:
                    journal.CreateJournalEntry();
                    break;

                case 3:
                    journal.SaveToCsv();
                    break;

                case 4:
                    journal.LoadFromCsv();
                    break;

                case 5:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid input. Please Put in a number from 1 - 5.");
                    break;
            }
        }
    }
}
