using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
                         // Container For Helper Method [For Defensive Code]

    static class ExamValidation
    {
        public static int ReturnValidAnswerLabel(int NumberOfChoices)
        {
            int ValidAnswerId;
            do
            {
                Console.Write("Enter The Answer: ");

            } while (!int.TryParse(Console.ReadLine(), out ValidAnswerId) || ValidAnswerId <= 0 || ValidAnswerId > NumberOfChoices);
            return ValidAnswerId;
        }

        public static ExamType ReturnValidExamType()
        {
            int ValidExamType;
            do
            {

                Console.Write("Please, Enter The Type Of Exam You Want To Create (1 For Practical and 2 For Final): ");

            } while (!int.TryParse(Console.ReadLine(), out ValidExamType) || (ValidExamType != 1 && ValidExamType != 2));

            return (ExamType)ValidExamType;
        }

        public static TimeOnly ReturnValidExamTime()
        {
            int validMinutes;
            do
            {
                Console.Write("Please, enter the time of the exam in minutes: ");
            } while (!int.TryParse(Console.ReadLine(), out validMinutes) || validMinutes <= 0);

            int hours = validMinutes / 60;
            int minutes = validMinutes % 60;

            return new TimeOnly(hours, minutes);
        }

        public static int ReturnNumberOfQuestions()
        {
            int NumberOfQuestions;
            do
            {
                Console.Write("Please, Enter The Number Of Questions You Wanted To Create: ");
            } while (!int.TryParse(Console.ReadLine() ,out NumberOfQuestions) || NumberOfQuestions <= 0);
            
            return NumberOfQuestions;   
        }

        public static QuestionTypes ReturnValidQuestionTypeForFinalExams(int QuestionOrder)
        {
            int ValidQuestionType;
            do
            {
                Console.Write($"Please , Choose The Type Of Question Number ({QuestionOrder}) (1 For True OR False || 2 For MCQ):  ");

            } while (!int.TryParse(Console.ReadLine() , out ValidQuestionType) || (ValidQuestionType != 1 && ValidQuestionType != 2));
            
            return (QuestionTypes)ValidQuestionType;
        }

        public static string ReturnValidBody()
        {
            int FakeNum = 0;
            string ValidBody;
            do
            {
                Console.Write("Please , Enter The Body Of Question: ");
                ValidBody = Console.ReadLine()!;

            } while (int.TryParse(ValidBody , out FakeNum));
            return ValidBody;
        }

        public static double ReturnValidMark()
        {
            double ValidMark;
            do
            {
                Console.Write("Please , Enter The Marks Of The Question: ");

            } while (!double.TryParse(Console.ReadLine() , out ValidMark) || ValidMark < 0 );

            return ValidMark;
        }

        public static int ReturnValidCorrectAnswerIdForTFQ(int NumberOfChoices)
        {
  
            int AnswerId;
            do
            {
                Console.Write("Please Enter The Right Answer Of The Question(1 for True | 2 for false): ");

            } while (!int.TryParse(Console.ReadLine(), out AnswerId) || AnswerId <= 0 || AnswerId > NumberOfChoices);

            return AnswerId;
           
        }
        public static int ReturnValidCorrectAnswerId(int NumberOfChoices)
        {

            int AnswerId;
            do
            {
                Console.Write($"Please Enter The Right Answer Of The Question(Between 1 And {NumberOfChoices}): ");

            } while (!int.TryParse(Console.ReadLine(), out AnswerId) || AnswerId <= 0 || AnswerId > NumberOfChoices);

            return AnswerId;

        }
        public static int ReturnValidChoicesNumber(out int ValidChoicesNumber)
        {
            
            do
            {
                Console.Write("Please , Enter The Number Of Choices You Want in This Question: ");

            } while (!int.TryParse(Console.ReadLine() , out ValidChoicesNumber) || ValidChoicesNumber <= 1);

            return ValidChoicesNumber;
        }

        public static int ReturnValidSubjectId()
        {
            int ValidSubjectId;
            do
            {
                Console.Write("Please , Enter The Subject Id: ");

            } while (!int.TryParse(Console.ReadLine() , out ValidSubjectId) || ValidSubjectId <= 0);

            return ValidSubjectId;
        }
        public static string ReturnValidSubjectName()
        {
            int FakeNum = 0;
            string ValidSubjectName;
            do
            {
                Console.Write("Please , Enter The Subjec Name: ");
                ValidSubjectName = Console.ReadLine()!;

            } while (int.TryParse(ValidSubjectName, out FakeNum));

            return ValidSubjectName;
        }

        public static char StartExam()
        {
            char Choice;
            do
            {
                Console.Write("Do You Want To Start The Exam (Y | N): ");

            } while (!char.TryParse(Console.ReadLine() , out Choice) || (Choice != 'Y' && Choice != 'y' && Choice != 'N' && Choice != 'n') );

            return Choice;
        }

    }
}
