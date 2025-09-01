namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz app");
            int score = 0;
            string question1 = "Who directed Avengers Endgame";
            string answer1 = "Russo Brothers";

            string question2 = "Who directed No country for old man";
            string answer2 = "Coen Brothers";

            string question3 = "Who directed Retro";
            string answer3 = "Karthik subbaraj";

            Console.WriteLine($"Question :{question1}");
            string? userAnswer = Console.ReadLine();
            if(userAnswer == answer1)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong answer. The Correct answer is {answer1}");
            }

            Console.WriteLine($"Question :{question2}");
            string? userAnswer2 = Console.ReadLine();
            if (userAnswer2 == answer2)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong answer. The Correct answer is {answer2}");
            }

            Console.WriteLine($"Question :{question3}");
            string? userAnswer3 = Console.ReadLine();
            if (userAnswer3 == answer3)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"Wrong answer. The Correct answer is {answer3}");
            }
            Console.WriteLine("Your Total score is " + score);

            if(score ==3)
            {
                Console.WriteLine("Excellent");
            }
            else if(score >1)
            {
                Console.WriteLine("Good job. Try again");
            }
            else
            {
                Console.WriteLine("Keep learning and try again");
            }
            Console.ReadKey();
        }
    }
}
