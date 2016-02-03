using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_42_excersie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number any number will do.");
            var x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter different number than the one you already entered.");
            var a = Int32.Parse(Console.ReadLine());

            if (x > a)
            {
                Console.WriteLine("The greater number is");
                Console.WriteLine(x);
            }
            else if (a > x)
            {
                Console.WriteLine("The greater number is");
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("You obivously can't read instructions enter two DIFFERENT numbers and try again");
            }
        }
    }
}
