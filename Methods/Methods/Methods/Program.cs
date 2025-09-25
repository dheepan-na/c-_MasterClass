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
        }
    }
}
