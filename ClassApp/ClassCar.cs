using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    // this is an interanll class this can be called anywhere in the assembly ClassApp
    internal class ClassCar
    {
        public ClassCar() {
            Console.WriteLine("Here we have created a constructor. It will be called whenever the object of the class is created.");
        }
    }
}
