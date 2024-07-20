using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class FinalExam : ExamBase
    {
        #region Properties
        public Answer[] UserAnswers { get; set; }
        #endregion

        #region Constructors
        public FinalExam(TimeOnly examTime, int numberOfQuestions) : base(examTime, numberOfQuestions)
        {
            UserAnswers = new Answer[NumberOfQuestions];
        }
        #endregion

        #region Methods
        public override void ShowExam()
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].PrintQuestionWithAnswers();
                Console.WriteLine("-------------------------------------------");

                UserAnswers[i] = new Answer();
                UserAnswers[i].AnswerId = ExamValidation.ReturnValidAnswerLabel(Questions[i].ChoicesNumber);
                UserAnswers[i].AnswerText = Questions[i].Answers[(UserAnswers[i].AnswerId) - 1].AnswerText;

                Console.WriteLine("================================================\n");
            }

            ShowExamWithUserAnswers();
            Console.WriteLine($"Your Exam Grade is: {CalcUserGrades()}/{CalcTotalExamGrades()}");
            Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
        }

        private void ShowExamWithUserAnswers()
        {
            Console.WriteLine("Your Answers: ");
            for (int i = 0; i < UserAnswers.Length; i++)
            {
                Console.WriteLine($"Q{i + 1})  {Questions[i].Body}: {UserAnswers[i].AnswerText}");
            }
        }
        private double CalcUserGrades()
        {
            double UserGrades = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                if (UserAnswers[i].AnswerId == Questions[i].CorrectAnswer.AnswerId)
                    UserGrades += Questions[i].Mark;
            }
            return UserGrades;
        }

        private double CalcTotalExamGrades()
        {
            double ExamGrades = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                ExamGrades += Questions[i].Mark;
            }
            return ExamGrades;
        } 
        #endregion

    }
}
