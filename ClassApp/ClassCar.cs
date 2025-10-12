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
        //backing field for the property.
        private string _modelOfCar;
        private string _brandOfCar;

        public string ModelOfCar
        {
            get {
                Console.WriteLine(" This is get in the property. Get is used to retrive the value whenever the property is called.");
                return _modelOfCar; 
            } set {
                Console.WriteLine("This is set in the property. Whenver the value is passed to the property the set is called and and assign value to it.");
                _modelOfCar = value; }
        }

        public string BrandOfCar
        {
            get
            {
                if (IsLuxery)
                {
                    return _brandOfCar+ " - Is Luxary barnd";
                }
                else
                {
                    return _brandOfCar;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The value is empty so assigning the default value.");
                    _brandOfCar = "car Brand";
                }
                else
                {
                    _brandOfCar = value;
                }
            }
        }

        public bool IsLuxery { get ; set ; }
        
        //default constructor.
        public ClassCar() {
            Console.WriteLine("Here we have created a constructor. It will be called whenever the object of the class is created.");
        }

        //Custom Constructor
        public ClassCar(string modelOfCar, string brandOfCar, bool isLuxery)
        {
            Console.WriteLine("\nHere we have created a custom constructor with some variable.");
            ModelOfCar = modelOfCar;
            _brandOfCar = brandOfCar;
            Console.WriteLine($"{_brandOfCar} has a model of {ModelOfCar} ");
            IsLuxery = isLuxery;
        }

        public void Drive()
        {
            Console.WriteLine($"I am driving the car of model {ModelOfCar} of {BrandOfCar}");
        }
    }
}
