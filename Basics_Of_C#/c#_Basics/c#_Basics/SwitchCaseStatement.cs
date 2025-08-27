using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Basics
{
    public static class SwitchCaseStatement
    {
        public static void PrintingMonth()
        {
            Console.WriteLine("Enter the number of month");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("this is January month");
                    break;
                case 2:
                    Console.WriteLine("this is February month");
                    break;
                case 3:
                    Console.WriteLine("this is march month");
                    break;

                default:
                    Console.WriteLine("This is no month");
                    break;
            }
            Console.ReadKey();
        }
    }
}
