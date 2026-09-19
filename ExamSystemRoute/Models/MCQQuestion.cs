using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystem.Models
{
    internal class MCQQuestion : Question
    {
        #region Constructors

        public MCQQuestion(
            string header,
            string body,
            int mark,
            Answer[] answerList,
            Answer rightAnswer)
            : base(header, body, mark, answerList, rightAnswer)
        {
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{base.ToString()}\nChoose one answer:";
        }

        #endregion
    }
}