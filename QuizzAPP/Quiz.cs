using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzAPp
{
    internal class Quiz
    {
        Questions[] questions;
        public Quiz(Questions[] questions)
        {
            this.questions = questions;
        }

        public void DisplayQuestions(Questions question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question.QuestionText);
            Console.ResetColor();

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"    {i + 1}. ");
                Console.ResetColor();
                Console.WriteLine(question.Answers[i]);
            }

        }
    }
}
