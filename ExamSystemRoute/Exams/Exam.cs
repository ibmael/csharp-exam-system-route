using System;
using System.Collections.Generic;
using System.Text;

using ExamSystem.Models;

namespace ExamSystem.Exams
{
    internal abstract class Exam
    {
        #region Properties

        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        #endregion

        #region Constructors

        protected Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
        }

        #endregion

        #region Methods

        public abstract void ShowExam();

        #endregion
    }
}
