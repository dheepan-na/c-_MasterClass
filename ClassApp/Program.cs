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
            ClassCar audi = new ClassCar("Audi", "A3",true);
            ClassCar bmw = new ClassCar("BMW", "i7",false);

            Console.WriteLine("\n Here we are learning about encapsulation. Encapsulation is the important aspect in the Object oriented programming.");
            Console.WriteLine(" We can encapsulate methods, member variables , events, nested elements.");
            Console.WriteLine(" Here we have public access outside of the class whenever the object is created.\nPrivate this cannot been accessed outside of the class not even by the object.\nProtected this cannot be accessed outside of the class only the objects that is inherited can use this variable");
            Console.WriteLine("IN Class Car the model and brand member variable is hidden. The best way to access or modify the member variable is using properties");
            Console.WriteLine("Properties in encapsulation used to access and modify the member variable.");
            Console.WriteLine("\nThe property has been created. It should be always public. Name of the property should be in caps.");
            Console.WriteLine("Setting the value to the property of the class.");
            bmw.ModelOfCar = "Benz";
            Console.WriteLine("Getting the value of the property of the class.");
            Console.WriteLine(bmw.ModelOfCar);
            Console.WriteLine("\nNow we are going to add a condition to the setter of the brand. We can add conditions statement to the setter or getter.");
            bmw.BrandOfCar = Console.ReadLine();
            Console.WriteLine($"Brand of the {bmw.ModelOfCar} is {bmw.BrandOfCar}.");
            Console.WriteLine("\nNow we are going to add a condition to the getter of the brand/Property. We can add conditions statement to the setter or getter.");
            Console.WriteLine($"Brand of the {audi.ModelOfCar} is {audi.BrandOfCar}.");
            Console.WriteLine("\n The member variables declared and used are the backing field of the property created in the class. If we using condition and modifying the prop then we might need the backing field else it is not needed.\nFor example the is luxury doesn't need a backing filed.");
            





            Console.ReadKey();
        }
    }
}
