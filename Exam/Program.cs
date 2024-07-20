using System.Diagnostics;

namespace Exam
{
     class Program
    {
        static void Main()
        {
            Subject Sub = new Subject(ExamValidation.ReturnValidSubjectId(), ExamValidation.ReturnValidSubjectName());
            Sub.CreateExam();
            Console.Clear();
            
            char Choice = ExamValidation.StartExam();
            if(Choice == 'Y' || Choice == 'y')
            {
                Console.Clear() ;              
                Sub.SubjectExam.ShowExam();
               
            }
           
        }
    }
}
