using System;
using System.Collections.Generic;
using System.Text;

public class PrintLines
{
    public void GetLines(string randomWord)
    {
        Console.Write("\r");
        foreach (char c in randomWord)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("\u005f "); // Unicode Character "_" (U+005F) - Low Line
        }
    }
}
