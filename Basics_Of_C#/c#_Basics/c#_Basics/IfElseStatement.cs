using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Basics
{
    public static class IfElseStatement
    {
        public static void EligibleForVoting()
        {
            Console.WriteLine("Hi, Kindly enter your age to know whether you are eligible for voting:");
            int age =int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Eligible for voting");
                if (age == 18)
                {
                    Console.WriteLine("First time voters: Vote responsibly");
                }
            }
            else if (age == 17)
            {
                Console.WriteLine("Wait for just one year");
            }
            else
            {
                Console.WriteLine("Not eligible for voting");
            }
            Console.ReadKey();
        }
    }
}
