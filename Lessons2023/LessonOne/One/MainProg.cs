using Lessons2023.LessonOne.One;
using Lessons2023.LessonOne.Two;
using System.Diagnostics.CodeAnalysis;

internal class MainProg
{
    private static void Main(string[] args)
    {


        double weight = 3.3;
        decimal testOneDecimal = 22345.345634m;

        int[] terstMassive = { 1, 2, 3};
        string[] testMassive2 = {"asd", "asdasd", "asdasd"};

        Console.WriteLine(terstMassive.GetType());
        Console.WriteLine(testMassive2.GetType());
        Console.WriteLine($"test massive {terstMassive[2]}");
        Console.WriteLine($"test massive {testMassive2[2]}");

        Console.WriteLine($"Вес: {weight}");
        Console.WriteLine($"Test Decimal: {testOneDecimal}");

        //---------------------------------------------------------------------

        Test test = new Test();

        Save save = new Save();

        save.saveDataLevel();
        save.loadDataLevel();


    }
}