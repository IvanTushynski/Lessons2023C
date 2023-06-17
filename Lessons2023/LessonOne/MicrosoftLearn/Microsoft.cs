using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2023.LessonOne.MicrosoftLearn
{
    public class MicrosoftOne
    {
        public void MicrosoftLearn()
        {
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            //fraudulentOrderIDs[3] = "D000";

            Console.WriteLine($"Order ID One {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Order ID Two {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Order ID Three {fraudulentOrderIDs[2]}");
        }
    }
}
