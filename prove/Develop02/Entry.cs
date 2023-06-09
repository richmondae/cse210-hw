using System;

class Entry
{
    string date, prompt, response;

    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine("Date: {0}\nPrompt: {1}\nResponse: {2}", date, prompt, response);
    }

    public string GetEntryAsCsv()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }
}
