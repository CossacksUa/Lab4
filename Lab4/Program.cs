using System;
using System.Threading.Tasks;

class MainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберiть завдання:");
        Console.WriteLine("Завдання 1");
        Console.WriteLine("Завдання 2");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1.Execute();
                break;
            case 2:
                Task2.Execute();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }
}
