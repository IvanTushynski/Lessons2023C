using Lessons2023.LessonOne.One;
using Lessons2023.LessonOne.Two;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

internal class MainProg
{
    private static void Main(string[] args)
    {


        double weight = 3.3;
        decimal testOneDecimal = 22345.345634m;




        int sum = 1700 * 3;
        Console.WriteLine($"XRP SUM: {sum}");
        Console.WriteLine($"-----------------------------------------");

        //-------------------------------MASSIVE-ONE-------------------------------------
        Massives massives = new Massives();

        massives.getMassiveDouble();
        massives.getMassiveDoubleSecond();

        int[] terstMassive = { 1, 2, 3 };
        string[] testMassive2 = { "asd", "asdasd", "asdasd" };

        //-------------------------------MASSIVE-DOUBLE-------------------------------------
        int[,] testTeoMerMassive = new int[2, 3];
        testTeoMerMassive[1, 2] = 3;
        Console.WriteLine($"Massive1.2: {testTeoMerMassive[1, 2]}");


        int[,] array3D = new int[,] {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };


        Console.WriteLine($"test massive3d {array3D[1, 1]}");



        Console.WriteLine(terstMassive.GetType());
        Console.WriteLine(testMassive2.GetType());
        Console.WriteLine($"test massive {terstMassive[2]}");
        Console.WriteLine($"test massive {testMassive2[2]}");

        Console.WriteLine($"Вес: {weight}");
        Console.WriteLine($"Test Decimal: {testOneDecimal}");

        //-----------------------------CALL--METHODS--GET--SET----------------------------------
        Console.WriteLine($"-----------------------------------------");
        GetSet test = new GetSet();
        test.SetTestInt(3);
        Console.WriteLine(test.GetTestInt());
        Console.WriteLine($"-----------------------------------------");
        Console.WriteLine($"-------------------BOOLEAN----------------------");
        Bool testbool = new Bool();
        testbool.GetTestAttack();
        testbool.GetTestAttack();
        testbool.GetTestAttack();
        testbool.GetTestAttack();
        testbool.GetTestAttack();
        testbool.GetTestAttack();

        //Random----------------------------
        Random dice = new Random();//--------call----random-------
        int rollOne = dice.Next( 2, 20 );
        Console.WriteLine(rollOne);

        //Save save = new Save();

        //save.saveDataLevel();
        //save.loadDataLevel();


    }
}