using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(string prompt, string response)
    {
        _entries.Add(new Entry("",prompt, response));
    }

    public void DisplayEntries()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using(StreamWriter writer = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        Console.WriteLine("Journal saved as text file successfully.");
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[]lines = File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[]parts =line.Split("|");
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0].Trim(),parts[1].Trim(),parts[2].Trim());
                
                _entries.Add(entry);
            }
        }
    }

    public void SaveToCsv(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // CSV Header
            writer.WriteLine("Date,Prompt,Entry");

            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine("Journal saved as CSV successfully.");
    }
}