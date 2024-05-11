using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.AddScripture(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        library.AddScripture(new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        library.AddScripture(new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."));
        library.AddScripture(new Scripture(new Reference("Alma", 32, 21), "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."));
        
        Scripture currentScripture = library.GetRandomScripture();

        while (!currentScripture.AreAllWordsHidden())
        {
            Console.Clear();
            currentScripture.Display();

            Console.WriteLine("\nPress ENTER to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
                break;

            currentScripture.HideWords();
        }

        Console.WriteLine("\nAll words are hidden. Memorization complete!");
        Console.ReadLine(); // Wait for user to acknowledge before closing
    }
}
