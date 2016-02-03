using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_42_Excersie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10. Thanks for your cooperation");
            var x = Int32.Parse(Console.ReadLine());
            if (x <=10)
            {
                Console.WriteLine("The number is valid");
            }
            else
            {
                Console.WriteLine("The number is invalid please try again");
            }
        }
    }
}
