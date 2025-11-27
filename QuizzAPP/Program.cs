namespace QuizzAPp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions[] questions = new Questions[] { new Questions("Who acted in leo", new string[] { "Ajith", "Vijay", "Diwager", "Lokesh" }, 2),
                new Questions("Who acted in gbu", new string[] { "Ajith", "Vijay", "Diwager", "Lokesh" }, 1),
                new Questions("Who acted in dc", new string[] { "Ajith", "Vijay", "Diwager", "Lokesh" }, 3)
            };

            Quiz quiz = new Quiz(questions);
            quiz.DisplayQuestions(questions[0]);
            
        }
    }
}
