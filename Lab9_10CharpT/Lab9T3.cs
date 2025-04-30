using System;
using System.IO;

public class Lab9T3
{
    public void Run()
    {
        Console.WriteLine("\n\nЗавдання 3:");

        string filePath = "text2.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл \"{filePath}\" не знайдено. Створюємо тестовий файл...");
            File.WriteAllText(filePath, "Олена і Андрій працюють у офісі. Гарна погода надворі, всі поспішають на прогулянку.");
        }

        string text = File.ReadAllText(filePath);

        WordCollection original = new WordCollection();
        original.AddWords(text);

        Console.WriteLine("- Слова, що починаються з голосної:");
        foreach (string word in original.GetVowelWords())
        {
            Console.Write(word + " ");
        }

        Console.WriteLine("\n- Клонована та відсортована колекція (за довжиною слів):");
        WordCollection clone = (WordCollection)original.Clone();
        clone.Sort(new WordLengthComparer());

        foreach (string word in clone)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine();
    }
}
