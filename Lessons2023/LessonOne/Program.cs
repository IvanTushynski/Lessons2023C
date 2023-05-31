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

        //Console.WriteLine($"Имя: {name}");
        //Console.WriteLine("Имя: " + name);
        //Console.WriteLine(test.setTest(5));
        //Console.WriteLine(test.getTestInt());
        //Console.WriteLine($"Вес: {weight}");
        //Console.WriteLine($"Работает: {isEmployed}");

        for (int i = 1; i <= 10; i++)
        { if (i == 0)
            {
                Thread.Sleep(2000);
                Console.WriteLine("6!");
            }else if (i == 1)
            {
                Thread.Sleep(2000);
                Console.WriteLine("5!");
            }
            else if (i == 2)
            {
                Thread.Sleep(2000);
                Console.WriteLine("4!");
            }
            else if (i == 3)
            {
                Thread.Sleep(2000);
                Console.WriteLine("3!");
            }
            else if (i == 4)
            {
                Thread.Sleep(2000);
                Console.WriteLine("2!");
            }
            else if (i == 5)
            {
                Thread.Sleep(2000);
                Console.WriteLine("1!");
            }
            else if (i == 6)
            {
                Thread.Sleep(2000);
                Console.Write("Deleting System Files. Please Wait.");
            }
            else if (i == 7)
            {
                Thread.Sleep(2000);
                Console.Write(".");
            }
            else if (i == 8)
            {
                Thread.Sleep(4000);
                Console.WriteLine(".");
            }
            else if (i == 9)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Operation Complete.");
            }
            else if (i == 10)
            {
                Thread.Sleep(4000);
                Console.WriteLine("Bye!!!");
            }
        }
    }
}