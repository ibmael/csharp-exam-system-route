using System;
using System.Collections.Generic;
using System.Text;

using ExamSystem.Models;

namespace ExamSystem.Exams
{
    internal class FinalExam : Exam
    {
        #region Constructors

        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        #endregion

        #region Methods

        public override void ShowExam()
        {
            Console.WriteLine(" Final Exam");
            Console.WriteLine($"Exam Time: {Time} Minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(Questions[i]);

                foreach (Answer answer in Questions[i].AnswerList)
                {
                    Console.WriteLine(answer);
                }

                Console.WriteLine();
            }
        }

        #endregion
    }
}