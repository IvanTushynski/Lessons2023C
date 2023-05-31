using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2023.LessonOne
{
    internal class Test
    {

       int testInt;

        public int setTest(int testInt)
        {
            return testInt;
        }

        public int getTestInt() {
        
            this.testInt = 2;
            return testInt;
        }

    }
}
