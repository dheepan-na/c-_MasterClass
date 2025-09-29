namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating my first method an calling it.");
            void MyfirstMethod()
            {
                Console.WriteLine(" This is my first method");
                Console.WriteLine("Methods are used to execute block of code whenever it is called.");
            }
            MyfirstMethod();
            Console.WriteLine("Calling method for second time");
            MyfirstMethod();

            Console.WriteLine("A parameter is a value we are passing to the method for executing.");
            Console.WriteLine("Creating a method with a parameter");

            void MethodWithParameter(string param)
            {
                Console.WriteLine($"The parameter passed into the method {param}.");
            }

            string paramFromUser = Console.ReadLine();
            MethodWithParameter(paramFromUser);

            Console.WriteLine("AddOnly Calculator to learn methods with two parameters");
            Console.WriteLine("Methode created to add two values with return type int.");
            int AddTwoNumbers(int num1, int num2)
            {
                int result = num1 + num2;
                return result;
            }

            Console.WriteLine("Enter two numbers to add");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The result of the method is "+AddTwoNumbers(num1,num2));


            Console.ReadKey();
        }
    }
}
