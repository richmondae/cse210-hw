using System;
class SaveLoadCsv
{
    public static void SaveToCsv(string filePath, List<Entry> entries)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.GetEntryAsCsv());
            }
        }
    }

    public static List<Entry> LoadFromCsv(string filePath)
    {
        List<Entry> entries = new List<Entry>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string[] fields = reader.ReadLine().Split('│');
                string date = fields[0];
                string prompt = fields[1];
                string response = fields[2];

                Entry entry = new Entry(date, prompt, response);
                entries.Add(entry);
            }
        }

        return entries;
    }
}
