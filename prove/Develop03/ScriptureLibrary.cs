using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> Scriptures { get; set; } = new List<Scripture>();

    public void AddScripture(Scripture scripture)
    {
        Scriptures.Add(scripture);
    }

    public Scripture GetRandomScripture()
    {
        Random rand = new Random();
        return Scriptures[rand.Next(Scriptures.Count)];
    }
}
