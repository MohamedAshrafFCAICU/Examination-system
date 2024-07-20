using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class TFQuestion : QuestionBase
    {
        #region Constructors
        public TFQuestion(QuestionTypes questionHeader, string body, double mark, int correctAnswerId) : base(questionHeader, body, mark, 2, correctAnswerId)
        {
            Answers[0] = new Answer();
            Answers[0].AnswerId = 1;
            Answers[0].AnswerText = "true";

            Answers[1] = new Answer();
            Answers[1].AnswerId = 2;
            Answers[1].AnswerText = "false";

            CorrectAnswer.AnswerText = Answers[CorrectAnswer.AnswerId - 1].AnswerText;
        }

        #endregion

        #region Methods
        public override void PrintQuestionWithAnswers()
        {
            Console.WriteLine($"True | False \tMark({Mark})\n{Body}\n{Answers[0].AnswerId}. {Answers[0].AnswerText} \t\t\t {Answers[1].AnswerId}. {Answers[1].AnswerText}");
        } 
        #endregion
    }
}
