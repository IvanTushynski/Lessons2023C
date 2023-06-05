using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2023.LessonOne.Two
{
    internal class Save
    {

        public void saveDataLevel()
        {
            try {
                Console.Write("Recording.");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                StreamWriter sw = new StreamWriter("D:\\IT\\С#\\projects\\Lessons2023\\Lessons2023\\LessonOne\\Two\\Text.txt");
                sw.WriteLine("Test write testOne!!");
                sw.WriteLine("Test write testtwo!!");
                sw.Close();
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }

        public void loadDataLevel()
        {
            try {
            StreamReader streamReader = new StreamReader("D:\\IT\\С#\\projects\\Lessons2023\\Lessons2023\\LessonOne\\Two\\Text.txt");
            string line = streamReader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = streamReader.ReadLine();
                Thread.Sleep(1000);
            }
            Console.WriteLine("Write ~end~ to end program!");
            String end = Console.ReadLine();
            if (end == "end")
            {
                Console.Write("Complete!");
                streamReader.Close();
            }
            else
            {
                Console.Write("Do not complete!");
                streamReader.Close();
            }
            }
            catch(Exception e) {
            Console.WriteLine(e.Message);
            }


        }

    }
}
