using System;
using System.Collections.Generic;
using System.IO;

public class Lab9T1
{
    public void Run()
    {
        Console.WriteLine("\n\nЗавдання 1:");

        string filePath = "text.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл \"{filePath}\" не знайдено. Створюємо тестовий файл...");
            File.WriteAllLines(filePath, new string[]
            {
                "Привіт, світ!",
                "Це другий рядок.",
                "C# — чудова мова програмування."
            });
        }

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in line)
            {
                stack.Push(ch);
            }

            Console.Write("Рядок у зворотному порядку: ");
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
