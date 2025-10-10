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
            Console.WriteLine("\nDisplaying the weather condition for the days");
            DisplayWithGenericMethod(dailyCondition);
            Console.WriteLine("\nCalculating the avearage tempearture as double");
            Console.WriteLine("Displaying avearage temperature "+AveargeTemperature(temperature));

            Console.WriteLine("\nDisplaying Min using inbuilt functions "+temperature.Min());
            Console.WriteLine("Displaying MaX using inbuilt functions " + temperature.Max());
            Console.WriteLine("Displaying Min using created functions " + MinTemperature(temperature));
            Console.WriteLine("Displaying Max using created functions " + MaxTemperature(temperature));
            Console.WriteLine("\nMost common temperature "+MostCommonWeatherCondition(dailyCondition));

            Console.ReadKey();
        }

        static void DisplayWithObjectsMethod(object[] arr)
        {
            Console.WriteLine("\nDisplaying with the objects method.");
            foreach (object item in arr)
            {
                Console.Write(item+" ");
            }
        }

        static void DisplayWithGenericMethod<T>(T[] arr)
        {
            Console.WriteLine("\nDisplaying with the Generics method.");
            foreach (object item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static void DisplayWithIenumerableMethod(IEnumerable arr)
        {
            Console.WriteLine("\nDisplaying with the Ienumerable method. This type of displaying is mostly recommended.");
            foreach (object item in arr)
            {
                Console.Write(item + " ");
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

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];
            foreach(int item in temperature)
            {
                if(item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        static int MaxTemperature(int[] temperature)
        {
            int max = temperature[0];
            for (int i = 1; i < temperature.Length; i++)
            {
                if (temperature[i] > max)
                {
                    max = temperature[i];
                }
            }
            return max;
        }

        static string MostCommonWeatherCondition(string[] condition)
        {
            int count = 0;
            string mostCommon = condition[0];

            foreach (string item in condition)
            {
                int tempCount = 0;
                foreach (string item2 in condition)
                {
                    if (item == item2)
                    {
                        tempCount++;
                    }
                }
                if (tempCount >= count)
                {
                    count = tempCount;
                    mostCommon = item;
                }
            }
            return mostCommon;
        }

    }


}
