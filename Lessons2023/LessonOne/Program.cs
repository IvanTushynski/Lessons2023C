using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {

        string name = "Володя";
        int age = 33;
        bool isEmployed = false;
        double weight = 78.65;

        Console.WriteLine($"Имя: {name}");
        Console.WriteLine("Имя: " + name);
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Вес: {weight}");
        Console.WriteLine($"Работает: {isEmployed}");
    }
}