using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class ExamBase
    {

        #region Properties
        public TimeOnly ExamTime { get; set; }

        public int NumberOfQuestions { get; set; }

        public QuestionBase[] Questions { get; set; }

        #endregion

        #region Constructors
        protected ExamBase(TimeOnly examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
            Questions = new QuestionBase[NumberOfQuestions];
        }
        #endregion

        #region Method
        public abstract void ShowExam(); 
        #endregion

    }
}
