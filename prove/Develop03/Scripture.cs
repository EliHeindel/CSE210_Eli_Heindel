using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words.Select(w => w.ToString())));
    }

    public void HideWords(int count = 1)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        Random rand = new Random();
        for (int i = 0; i < Math.Min(count, visibleWords.Count); i++)
        {
            visibleWords[rand.Next(visibleWords.Count)].Hide();
        }
    }

    public bool AreAllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}
