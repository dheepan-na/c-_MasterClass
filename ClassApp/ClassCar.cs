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
        private string _modelOfCar;
        private string _brandOfCar;
        public ClassCar() {
            Console.WriteLine("Here we have created a constructor. It will be called whenever the object of the class is created.");
        }

        public ClassCar(string modelOfCar, string brandOfCar)
        {
            Console.WriteLine("\nHere we have created a custom constructor with some variable.");
            _modelOfCar = modelOfCar;
            _brandOfCar = brandOfCar;
            Console.WriteLine($"{_brandOfCar} has a model of {_modelOfCar} ");
        }
    }
}
