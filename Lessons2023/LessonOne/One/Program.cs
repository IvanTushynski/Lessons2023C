using Lessons2023.LessonOne.One;
using Lessons2023.LessonOne.Two;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {

        Test test = new Test();

        Save save = new Save();

        save.saveDataLevel();
        save.loadDataLevel();


        //string name = "Володя";
        //bool isEmployed = false;
        //double weight = 78.65;

        //Console.WriteLine($"Имя: {name}");
        //Console.WriteLine("Имя: " + name);
        //Console.WriteLine(test.setTest(5));
        //Console.WriteLine(test.getTestInt());
        //Console.WriteLine($"Вес: {weight}");
        //Console.WriteLine($"Работает: {isEmployed}");


    }
}