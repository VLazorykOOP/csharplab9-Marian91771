using System;
using System.Collections;

public class MusicCatalog
{
    private Hashtable catalog = new Hashtable(); // ключ — назва диска, значення — ArrayList пісень

    public void AddDisk(string diskName)
    {
        if (!catalog.ContainsKey(diskName))
            catalog[diskName] = new ArrayList();
    }

    public void RemoveDisk(string diskName)
    {
        if (catalog.ContainsKey(diskName))
            catalog.Remove(diskName);
    }

    public void AddSong(string diskName, Song song)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            songs.Add(song);
        }
    }

    public void RemoveSong(string diskName, string songTitle)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            ArrayList toRemove = new ArrayList();
            foreach (Song s in songs)
            {
                if (s.Title == songTitle)
                    toRemove.Add(s);
            }

            foreach (Song s in toRemove)
            {
                songs.Remove(s);
            }

        }
    }

    public void PrintDisk(string diskName)
    {
        if (catalog.ContainsKey(diskName))
        {
            ArrayList songs = (ArrayList)catalog[diskName];
            foreach (Song song in songs)
            {
                Console.WriteLine(song);
            }
        }
        else
        {
            Console.WriteLine($"Диск \"{diskName}\" не знайдено.");
        }
    }

    public void PrintAll()
    {
        foreach (DictionaryEntry entry in catalog)
        {
            Console.WriteLine($"\nДиск: {entry.Key}");
            foreach (Song song in (ArrayList)entry.Value)
            {
                Console.WriteLine("  " + song);
            }
        }
    }

    public void SearchByArtist(string artist)
    {
        foreach (DictionaryEntry entry in catalog)
        {
            string disk = (string)entry.Key;
            ArrayList songs = (ArrayList)entry.Value;
            foreach (Song song in songs)
            {
                if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"[{disk}] {song}");
                }
            }
        }
    }
}
