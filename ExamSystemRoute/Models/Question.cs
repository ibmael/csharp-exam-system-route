using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystem.Models
{
    internal abstract class Question : IComparable<Question>, ICloneable
    {
        #region Properties

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        #endregion

        #region Constructors

        protected Question(
            string header,
            string body,
            int mark,
            Answer[] answerList,
            Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        #endregion

        #region Methods

        #region Methods

        public override string ToString()
        {
            return $"{Header}\n{Body}\nMark: {Mark}";
        }

        public int CompareTo(Question? other)
        {
            if (other == null)
                return 1;

            return Mark.CompareTo(other.Mark);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion

        #endregion
    }
}
