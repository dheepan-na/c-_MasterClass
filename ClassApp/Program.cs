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

            Console.WriteLine("\nDefault contructor are used to assign default value to the class. Even whec the values are not passed to the constructor.");
            ClassCar classCar = new ClassCar();
            Console.WriteLine("Enter the brand of the car");
            classCar.BrandOfCar = Console.ReadLine();
            Console.WriteLine("Enter the model of the car");
            classCar.ModelOfCar = Console.ReadLine();
            Console.WriteLine("Is the car Luxury");
            classCar.IsLuxery= bool.Parse(Console.ReadLine());
            Console.WriteLine($"The {classCar.ModelOfCar} of {classCar.BrandOfCar} brand is it luxury: {classCar.IsLuxery}");

            Console.WriteLine("\nThe method are function that is declared inside of the class. Method execute action w.r.t the properties or values of the object.");
            classCar.Drive();
            bmw.Drive();
            
            Customer customer = new Customer();
            customer.SetDetails("Dheepan", "Vellakoil", 79948459);
            Console.WriteLine($"customer name is {customer.Name} , Address: {customer.Address} , Phonenumber: {customer.PhoneNumber}");
            Console.WriteLine("\n Experrsion bodied members if the members , properties , constructor, finalizers and indexces contains only one single expression this can be used.");
            Console.WriteLine("Expression bodied members is using => lamba operator insted of {}");
            customer.SetName("Yamuna");
            Console.WriteLine($"customer name is {customer.Name} , Address: {customer.GetAddress()} , Phonenumber: {customer.PhoneNumber}");

            Customer customer2 = new Customer("Yamuna2");
            Console.WriteLine($"customer name is {customer2.Name}");

            Console.WriteLine("\nDefault parameter or optional parameter is the value that can be given to the parameter of the members or contructor. It can be used when the value is not provided.");
            Console.WriteLine("\nNamed parameter is the method used to tag the parameter of the method. In the real world example if the class or method have lot of parameter then using named paramter can be used for the readability.");
            customer2.SetDetails(name: "Yamuna3");
            Console.WriteLine($"customer name is {customer2.Name} , Address: {customer2.GetAddress()} , Phonenumber: {customer2.PhoneNumber}");
            Customer customer3 = new Customer("Latha", address: "Vellakovil");
            Console.WriteLine($"customer name is {customer3.Name} , Address: {customer3.Address} , Phonenumber: {customer3.PhoneNumber}");
            Console.WriteLine("\nComputed property is the type of property in which the values of the property is dependented on the other property or values.");
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 5;
            Console.WriteLine("The area of the rectangle is" + rectangle.Area);





            Console.ReadKey();
        }
    }
}
