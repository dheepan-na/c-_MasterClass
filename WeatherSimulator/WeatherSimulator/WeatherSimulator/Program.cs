using System.Collections;

namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to get weather");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] condition = { "Sunny", "Rainy", "Cloudy", "Windy", "Foggy" };
            string[] dailyCondition = new string[days];

            Random random = new Random();


            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                dailyCondition[i] = condition[random.Next(condition.Length)];
            }
            Console.WriteLine("Displaying the temperature for the days");
            DisplayWithObjectsMethod(temperature.Cast<Object>().ToArray());
            DisplayWithGenericMethod(temperature);
            DisplayWithIenumerableMethod(temperature);
            Console.WriteLine("Displaying the weather condition for the days");
            DisplayWithGenericMethod(dailyCondition);
            Console.WriteLine("Calculating the avearage tempearture as double");
            Console.WriteLine("Displaying avearage temperature "+AveargeTemperature(temperature));



            Console.ReadKey();
        }

        static void DisplayWithObjectsMethod(object[] arr)
        {
            Console.WriteLine("Displaying with the objects method.");
            foreach (object item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayWithGenericMethod<T>(T[] arr)
        {
            Console.WriteLine("Displaying with the Generics method.");
            foreach (object item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayWithIenumerableMethod(IEnumerable arr)
        {
            Console.WriteLine("Displaying with the Ienumerable method. This type of displaying is mostly recommended.");
            foreach (object item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static double AveargeTemperature(int[] temperature)
        {
            int sum = 0;
            Console.WriteLine("Getting avearge with nothing double");
            foreach(int item in temperature)
            {
                sum += item;
            }
            Console.WriteLine("Avearge with no double:"+ sum/temperature.Length);

            double orgSum = 0;
            foreach(int item in temperature)
            {
                orgSum += item;
            }
            return orgSum/temperature.Length;
        }

    }
}
