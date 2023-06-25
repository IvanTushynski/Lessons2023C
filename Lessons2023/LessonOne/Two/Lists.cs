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
            //add new list directories
            peoples.Add("IVAN");
            peoples.Add("ANDREI");
            peoples.Add("GLEB");
            peoples.Add("EHOR");

            Console.WriteLine($"Name one: {peoples[1]}");
            Console.WriteLine($"Name two: {peoples[0]}");
            Console.WriteLine($"Name three: {peoples[2]}");
            Console.WriteLine($"Name four: {peoples[3]}");
            Console.WriteLine($"Name five: {peoples[4]}");
            Console.WriteLine($"Name added six: {peoples[6]}");
            Console.WriteLine($"Names List Count: {peoples.Count}");
        }

    };

 
}
