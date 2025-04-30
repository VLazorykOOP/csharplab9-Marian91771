using System;
using System.Collections;

public class Lab9T4
{
    public void Run()
    {
        Console.WriteLine("\n\nЗавдання 4:\n");

        MusicCatalog catalog = new MusicCatalog();

        catalog.AddDisk("Best of 90s");
        catalog.AddSong("Best of 90s", new Song("Backstreet Boys", "I Want It That Way", 3.5));
        catalog.AddSong("Best of 90s", new Song("Nirvana", "Smells Like Teen Spirit", 5.0));

        catalog.AddDisk("Rock Hits");
        catalog.AddSong("Rock Hits", new Song("Queen", "Bohemian Rhapsody", 6.0));
        catalog.AddSong("Rock Hits", new Song("Nirvana", "Come As You Are", 4.0));

        Console.WriteLine("\n--- Весь каталог ---");
        catalog.PrintAll();

        Console.WriteLine("\n--- Пісні з диска 'Rock Hits' ---");
        catalog.PrintDisk("Rock Hits");

        Console.WriteLine("\n--- Пошук пісень виконавця 'Nirvana' ---");
        catalog.SearchByArtist("Nirvana");

        Console.WriteLine("\n--- Видалення пісні та диска ---");
        catalog.RemoveSong("Best of 90s", "I Want It That Way");
        catalog.RemoveDisk("Rock Hits");

        Console.WriteLine("\n--- Каталог після змін ---");
        catalog.PrintAll();
    }
}
