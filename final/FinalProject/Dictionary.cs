using System;
using System.Collections.Generic;
using System.IO;

public class Dictionary
{
    private List<string> _dictionary = new List<string>();

    public List<string> GetList(string fileName)
    {
        LoadWords(fileName);
        return _dictionary;
    }

    public void AddWord(string word)
    {
        _dictionary.Add(word);
    }

    public void LoadWords(string fileName)
    {
        try
        {
            string[] readText = File.ReadAllLines(fileName);

            foreach (string line in readText)
            {
                string entry = line.Trim();
                AddWord(entry);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found: " + fileName);
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file: " + fileName);
        }
    }
}
