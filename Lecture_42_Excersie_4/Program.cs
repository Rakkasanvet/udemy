using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_42_Excersie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit of the area the photo will be taken place");
            var speedlimit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the vehicle that will be driving in the photo");
            var carspeed = Int32.Parse(Console.ReadLine());
            var overage = (carspeed-speedlimit);
            var demeritpts = (overage/5);


            if (speedlimit>carspeed)
            {
                Console.WriteLine("The picture is OK to take and you are a safe driver");
            }
            else if (carspeed>speedlimit)
            {
                if (overage<5)
                {
                    Console.WriteLine("your still speeding but not enough to earn any demerit's slow down mister");
                }
                else if (overage==5)
                {
                    Console.WriteLine("You are not speeding by that much but you did earn 1 Demerit");
                }
                else if (overage>=5)
                {
                    Console.WriteLine("You were going over the speedlimit by");
                    Console.WriteLine(overage); //if i wanted to add MPH here how could i make that work? I tried and it failed.
                    Console.WriteLine("The following demerit points will be added to your license");
                    Console.WriteLine(demeritpts);
                }
                

                if (demeritpts>12)
                {
                    Console.WriteLine("YOUR LICENSE HAS BEEN SUSPENDED GOOD LUCK GETTING A DATE.");
                }
               
            }

        }
    }
}
