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
            Console.ReadKey();
        }
    }
}
