using System;
using System.Collections.Generic;
using System.IO;

public class Lab9T2
{
    public void Run()
    {
        Console.WriteLine("\n\nЗавдання 2:");

        string filePath = "text2.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл \"{filePath}\" не знайдено. Створюємо тестовий файл...");
            File.WriteAllText(filePath, "Олена і Андрій працюють у офісі. Гарна погода надворі, всі поспішають на прогулянку.");
        }

        Queue<string> vowelsQueue = new Queue<string>();
        Queue<string> consonantsQueue = new Queue<string>();
        char[] vowels = new[] { 'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я',
                                'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };

        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '—' },
                                            StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    if (word.Length > 0 && Array.Exists(vowels, v => v == word[0]))
                    {
                        vowelsQueue.Enqueue(word);
                    }
                    else
                    {
                        consonantsQueue.Enqueue(word);
                    }
                }
            }
        }

        Console.WriteLine("- Слова, що починаються на голосну:");
        foreach (var word in vowelsQueue)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine("\n- Слова, що починаються на приголосну:");
        foreach (var word in consonantsQueue)
        {
            Console.Write(word + " ");
        }

        Console.WriteLine();
    }
}
