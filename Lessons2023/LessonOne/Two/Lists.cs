using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2023.LessonOne.Two
{
    internal class Lists
    {

        List<string> peoples = new List<string>() { "Tom", "Bob", "Sam", "Nil", "John" };

        public void ListPeoples()
        {
            Console.WriteLine($"Name one: {peoples[1]}");
        }

    };

 
}
