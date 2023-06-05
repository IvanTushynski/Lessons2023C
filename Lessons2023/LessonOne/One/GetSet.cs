using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2023.LessonOne.One
{
    internal class GetSet
    {

        private int testInt;

        public void SetTestInt(int testInt)
        {
            this.testInt = testInt;
        }

        public int GetTestInt()
        {
            return testInt;
        }

    }
}
