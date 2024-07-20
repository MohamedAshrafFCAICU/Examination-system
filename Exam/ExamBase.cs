using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class ExamBase
    {

        public TimeOnly ExamTime { get; set; }

        public int NumberOfQuestions { get; set; }

        public QuestionBase[] Questions { get; set; }

        protected ExamBase(TimeOnly examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
            Questions = new QuestionBase[NumberOfQuestions];    
        }

        public abstract void  ShowExam();
       
    }
}
