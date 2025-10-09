using System.Reflection.Metadata;

namespace Methods
{
    internal class Program
    {
        // This is denoted as field or local instance which can used as global variable accross the class.
          static int resultAsField;
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
                resultAsField = result;
                return result;
            }

            Console.WriteLine("Enter two numbers to add");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The result of the method is "+AddTwoNumbers(num1,num2));

            Console.WriteLine(" Here we learn about the scope of the variable.");
            Console.WriteLine("Global variable it will be access by the method that are outside the variable");
            int globalVariable=0;
            int SubTwoNumbers(int num1, int num2)
            {
                Console.WriteLine("Here the variable is used from ouside the method. Global variable");
                globalVariable = num1 - num2;
                Console.WriteLine("Here the local variable is declared inside the method this can be accessed only within the scope.");
                int localVariable = globalVariable-10;
                return localVariable;
            }
            int result = SubTwoNumbers(num1, num2);
           

            Console.WriteLine("Result of globalVariable " + globalVariable);
            Console.WriteLine("Result of local Variable "+ result);

            Console.WriteLine("\n Argument promotion is techniques used to covert the small type of variable to larger type of variable in function.");
            Console.WriteLine("This can be used instead of explicit conversion");
            Console.WriteLine(" I have created a method with double type parameter (Large one) and passing int type argument(small type)");
            Console.WriteLine("Here the argument is being promoted int to double");

            Console.WriteLine("The result is here: "+ ArgumentPromotions.MultiplyTwoNumbers(num1, num2));

            ModuloTwoNumbers(num1, num2);
            Console.WriteLine("Using of Field or instance variable."+resultAsField);    

            Console.ReadKey();
        }
        static int ModuloTwoNumbers(int num1, int num2)
        {
            Console.WriteLine("Here the variable is used from ouside the method. Global variable");
            resultAsField = num1 % num2;
            Console.WriteLine("Here the local variable is declared inside the method this can be accessed only within the scope.");
            int localVariable = resultAsField % 10;
            return localVariable;
        }
    }
}
