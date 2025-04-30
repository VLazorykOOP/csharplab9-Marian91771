using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Послідовний запуск:
        Console.WriteLine("Послідовне виконання:");
        new Lab9T1().Run();
        new Lab9T2().Run();
        new Lab9T3().Run();
        new Lab9T4().Run();

    }
}
