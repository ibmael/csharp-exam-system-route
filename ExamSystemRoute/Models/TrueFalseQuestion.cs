using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystem.Models
{
    internal class TrueFalseQuestion : Question
    {
        #region Constructors

        public TrueFalseQuestion(
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