using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Class
{
    public static class PrintTwoRows
    {
        public static void PrintTwoRow()
        {
            int[,] twoDarray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += twoDarray[i,j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
