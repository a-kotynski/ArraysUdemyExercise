using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2159178#content
namespace ArraysUdemyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf() // method accessible on the class itself like Array
                         // that means it's a static method

            //Array.     // methods accessible after a class (dot) are static
            //numbers.   // methods accessible after an object (dot) are instanced, not static
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 2 is: "+ index); //index of 9 is 2, because it's counted from 0

            // Clear()
            Array.Clear(numbers, 0, 2); // Array.Clear(array, starting_index, length)

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);
            Console.WriteLine("Effects of Copy(): ");
            foreach (var n in anotherArray)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effects for Sort(): ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effects of Reverse(): ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}