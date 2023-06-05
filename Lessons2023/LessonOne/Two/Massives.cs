using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2023.LessonOne.Two
{
    internal class Massives
    {

        double[] massiveDouble = { 2.2, 3.1, 4.5, 2.7 };


        public void getMassiveDouble()
        {
            System.Console.WriteLine(massiveDouble[2]);
        }

        double[,] massiveDoubleSecond = {
        { 2.2, 3.4, 8.1 },
        { 1.2, 2.4, 2.7 },
        { 3.2, 1.7, 5.8 },
        };

        public void getMassiveDoubleSecond()
        {
            System.Console.WriteLine(massiveDoubleSecond[2,2]);
        }




    }
}
