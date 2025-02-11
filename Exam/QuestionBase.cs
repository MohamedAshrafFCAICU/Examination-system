﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class QuestionBase
    {


        #region Properties
        public QuestionTypes QuestionHeader { get; set; }

        public string Body { get; set; }

        public double Mark { get; set; }

        public int ChoicesNumber { get; set; }

        public Answer[] Answers { get; set; }

        public Answer CorrectAnswer { get; set; }
        #endregion

        #region Constructors
        public QuestionBase(QuestionTypes questionHeader, string body, double mark, int choicesNumber, int correctAnswerId)
        {
            QuestionHeader = questionHeader;
            Body = body;
            Mark = mark;
            ChoicesNumber = choicesNumber;
            Answers = new Answer[ChoicesNumber];
            CorrectAnswer = new Answer();
            CorrectAnswer.AnswerId = correctAnswerId;
        }

        #endregion

        #region Methods
        public abstract void PrintQuestionWithAnswers(); 
        #endregion
    }
}
