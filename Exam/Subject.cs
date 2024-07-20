using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    enum ExamType : byte 
    {
        Practical = 1 , Final = 2 
    }
    class Subject
    {


        #region Properties  
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public ExamBase SubjectExam { get; set; }

        public ExamType ExamType { get; set; }

        #endregion

        #region Constructors
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;

        }
        #endregion

        #region Methods
        public void CreateExam()
        {
            ExamType = ExamValidation.ReturnValidExamType();

            if (ExamType == ExamType.Practical)
                SubjectExam = new PracticalExam(ExamValidation.ReturnValidExamTime(), ExamValidation.ReturnNumberOfQuestions());
            else
                SubjectExam = new FinalExam(ExamValidation.ReturnValidExamTime(), ExamValidation.ReturnNumberOfQuestions());

            Console.Clear();
            EnterExamQuestions();

        }

        private void EnterExamQuestions()
        {
            for (int i = 0; i < SubjectExam.NumberOfQuestions; i++)
            {
                if (ExamType == ExamType.Final)
                {
                    if (ExamValidation.ReturnValidQuestionTypeForFinalExams(i + 1) == QuestionTypes.TrueOrFalse)
                        SubjectExam.Questions[i] = new TFQuestion(QuestionTypes.TrueOrFalse, ExamValidation.ReturnValidBody(), ExamValidation.ReturnValidMark(), ExamValidation.ReturnValidCorrectAnswerIdForTFQ(2));
                    else
                    {
                        int ChoicesNumber;
                        SubjectExam.Questions[i] = new MCQQuestion(QuestionTypes.Choose, ExamValidation.ReturnValidBody(), ExamValidation.ReturnValidMark(), ExamValidation.ReturnValidChoicesNumber(out ChoicesNumber), ExamValidation.ReturnValidCorrectAnswerId(ChoicesNumber));
                    }
                }
                else if (ExamType == ExamType.Practical)
                {
                    int ChoicesNumber;
                    SubjectExam.Questions[i] = new MCQQuestion(QuestionTypes.Choose, ExamValidation.ReturnValidBody(), ExamValidation.ReturnValidMark(), ExamValidation.ReturnValidChoicesNumber(out ChoicesNumber), ExamValidation.ReturnValidCorrectAnswerId(ChoicesNumber));
                }
                Console.Clear();
            }

        } 
        #endregion
    }
}
