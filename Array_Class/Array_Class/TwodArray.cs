using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array_Class
{
    public static class TwodArray
    {
        public static void TwodimArray()
        {
            Console.WriteLine("Creating an array and assigning each value");
            int[,] array2d = new int[2,2];
            array2d[0, 0] = 22;
            array2d[1, 1] = 14;
            Console.WriteLine("Displaying array numbers using for loop");
            DisplayArrayUsingForLOop(array2d);
            Console.WriteLine("Creating an array and assigning value directly");

            int[,] array2dDir = { { 22, 14 }, { 14, 22 } };
            Console.WriteLine("Displaying array numbers using for each loop");

            DisplayArrayUsingForEachLOop(array2dDir);


        }

        private static void DisplayArrayUsingForLOop(int[,] arrayToDisplay)
        {
            int length = arrayToDisplay.Length/2;
            for(int i=0;i<length;i++)
            {
                for(int j = 0; j < arrayToDisplay.GetLength(i);j++)
                {
                    Console.Write(arrayToDisplay[i,j]+" ");
                }
                Console.Write("\n");
            }
        }

        private static void DisplayArrayUsingForEachLOop(int[,] arrayToDisplay)
        {
           foreach(var i in arrayToDisplay)
            {
                Console.WriteLine(i);
            }
        }
    }
}
