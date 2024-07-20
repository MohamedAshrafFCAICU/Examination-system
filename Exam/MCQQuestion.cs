using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class MCQQuestion : QuestionBase
    {
        public MCQQuestion(QuestionTypes questionHeader, string body, double mark, int choicesNumber, int correctAnswerId) : base(questionHeader, body, mark, choicesNumber, correctAnswerId)
        {
            for (int i = 0; i < ChoicesNumber; i++)
            {
                Answers[i] = new Answer();
                Answers[i].AnswerId = i + 1;
                FillAnswersText(i);
            }
            CorrectAnswer.AnswerText = Answers[CorrectAnswer.AnswerId - 1].AnswerText;
        }

        public override void PrintQuestionWithAnswers()
        {
            Console.WriteLine($"Choose One Answer Question \t\t\tMark({Mark})\n{Body}");
            for (int i = 0;i < ChoicesNumber;i++) 
            {
                Console.Write($"{Answers[i].AnswerId}. {Answers[i].AnswerText}\t\t");
            }
            Console.WriteLine();
        }

        private void FillAnswersText(int AnswerOrder)
        {
            Console.Write($"Please , Enter The Choice Number {AnswerOrder + 1}: ");
            Answers[AnswerOrder].AnswerText = Console.ReadLine();
        }
    }
}
