using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class PracticalExam : ExamBase
    {
        public PracticalExam(TimeOnly examTime, int numberOfQuestions) : base(examTime, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            for (int i = 0; i < NumberOfQuestions; i++) 
            {
                Questions[i].PrintQuestionWithAnswers();
                Console.WriteLine("--------------------------------------");
                ExamValidation.ReturnValidAnswerLabel(Questions[i].ChoicesNumber);
                Console.WriteLine("================================================\n");
            }
            Console.WriteLine();
            Console.WriteLine("The Right Answers Of The Exam: ");
            ShowExamWithRightAnswers();
        }

        private void ShowExamWithRightAnswers()
        {
            for(int i = 0;i < NumberOfQuestions; i++) 
            {
                Console.WriteLine($"Q{i + 1})  {Questions[i].Body}: {Questions[i].CorrectAnswer.AnswerText}");
            }
        }
    }
}
