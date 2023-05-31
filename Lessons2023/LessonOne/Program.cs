using Lessons2023.LessonOne;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {

        Test test = new Test();


        string name = "Володя";
        bool isEmployed = false;
        double weight = 78.65;

        Console.WriteLine($"Имя: {name}");
        Console.WriteLine("Имя: " + name);
        Console.WriteLine(test.setTest(5));
        Console.WriteLine(test.getTestInt());
        Console.WriteLine($"Вес: {weight}");
        Console.WriteLine($"Работает: {isEmployed}");

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine("+Test+");
            Thread.Sleep(1000);
        }
    }
}