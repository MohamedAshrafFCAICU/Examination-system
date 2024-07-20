using System.Diagnostics;

namespace Exam
{
     class Program
    {
        static void Main()
        {
            #region Exam Creation 
            Subject Sub = new Subject(ExamValidation.ReturnValidSubjectId(), ExamValidation.ReturnValidSubjectName());
            Sub.CreateExam();
            Console.Clear();
            #endregion

            #region Exam Start
            char Choice = ExamValidation.StartExam();
            if (Choice == 'Y' || Choice == 'y')
            {
                Console.Clear();
                Sub.SubjectExam.ShowExam();

            } 
            #endregion

        }
    }
}
