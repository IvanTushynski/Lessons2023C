using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2023.LessonOne.One
{
    internal class Bool
    {

        private bool testValue;

        public void GetTestValue()
        {
            testValue = true;
        }


        public void GetTestAttack()
        {
            GetTestValue();

            if (testValue == true)
            {
                Console.WriteLine("Attack!!!!");

            }else if (testValue == false)
            {
                Console.WriteLine("I dont have weapon.....");
            }
        }

    }
}
