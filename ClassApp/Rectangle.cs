using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        private static int area;

        public int Area => Height * Width;

        public int SetArea => area= Height * Width;

        public static void DisplaySetArea()
        {
            Console.WriteLine("The set Area is " + area);
        }
    }
}
