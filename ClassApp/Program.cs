namespace ClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class is a blueprint of methods and variable that is most specific to the class.");
            Console.WriteLine("Object or instance can be created by using the new keyword.");
            Console.WriteLine("New keyword allocates space in the memory for the class when it is created.");
            Console.WriteLine("\nInstance of the class is created. ");
            ClassCar car = new ClassCar();
            Console.WriteLine("\nHere we have created a custom constructor with the member variable.");
            Console.WriteLine("A member variable is the field or variable that is created inside the class and outside of all the membersof the class.");
            Console.WriteLine("General rule for member variable is it should start with _ and it should be private.");
            Console.WriteLine("Being private it is not accessible outside of the class using the object or instance.");
            ClassCar audi = new ClassCar("Audi", "A3");
            ClassCar bmw = new ClassCar("BMW", "i7");

            Console.ReadKey();
        }
    }
}
