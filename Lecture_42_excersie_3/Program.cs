using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_42_excersie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of your image");
            var width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enther the height of your image");
            var height = Int32.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Your picture will be printed as Landscape");
            }
            else if (height > width)
            {
                Console.WriteLine("Your picture will be printed as Portrait");
            }
            else if (height == width)
            {
                Console.WriteLine("Your picture will be printed in standard format");
            }
            {
               
            }
        }
    }
}
