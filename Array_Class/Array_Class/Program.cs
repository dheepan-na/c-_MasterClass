namespace Array_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create an array with the length of 5");

            int[] arrayOfNumbers = new int[5];

            Console.WriteLine("Assign values to the array.");

            arrayOfNumbers[0] = 25;
            arrayOfNumbers[1] = 14;
            arrayOfNumbers[4] = 22;
            Console.WriteLine("Iterating to array using for loop");
            int length = arrayOfNumbers.Length;
            Console.WriteLine("The length of the array :" + length);
            for(int i=0;i<length;i++)
            {
                Console.WriteLine($"Number at index{i} is {arrayOfNumbers[i]}");
            }

            Console.WriteLine("Iterating to array using foreach loop");

            foreach(int i in arrayOfNumbers)
            {
                Console.WriteLine($"Number is {i}");
            }

            Console.WriteLine("Dec and setting array elements in a single line without assiging each variable.\nCreating a string array for tha challenge");

            string[] weekdays = ["Mon", "tues", "wed", "thurs", "fri", "sat", "sun"];

            foreach(string day in weekdays)
            {
                Console.WriteLine($"The days in a week {day}day");
            }
            TwodArray.TwodimArray();
            Console.ReadKey();
        }
    }
}
