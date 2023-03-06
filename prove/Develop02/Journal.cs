using System;

class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was something that made you laugh today?",
            "What is something you did today that you are proud of?",
            "What is one thing you could have done better today?",
            "What is one thing you wish you had more time for?",
            "What is one thing that challenged you today?"
        };
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int _index = _random.Next(prompts.Count);
        return prompts[_index];
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                
                // writer.WriteLine(entry.ToString());
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
{
    entries.Clear();

    using (StreamReader reader = new StreamReader(fileName))
    {
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] parts = line.Split('|');

            Entry entry = new Entry(parts[1], parts[2], parts[0]);
            entries.Add(entry);
        }
    }
}
}