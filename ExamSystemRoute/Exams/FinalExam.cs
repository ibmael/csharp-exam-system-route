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
            int grade = 0;
            int totalMarks = 0;

            Answer[] userAnswers = new Answer[Questions.Length];

            Console.WriteLine("Final Exam");
            Console.WriteLine($"Exam Time: {Time} Minutes");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine();

            #region Show Questions And Get Answers

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine(Questions[i]);

                foreach (Answer answer in Questions[i].AnswerList)
                {
                    Console.WriteLine(answer);
                }

                Console.Write("Your Answer: ");

                int userAnswerId;

                while (!int.TryParse(Console.ReadLine(), out userAnswerId)
                       || userAnswerId < 1
                       || userAnswerId > Questions[i].AnswerList.Length)
                {
                    Console.Write("Invalid Answer, Enter Again: ");
                }

                userAnswers[i] = Questions[i].AnswerList[userAnswerId - 1];

                totalMarks += Questions[i].Mark;

                if (userAnswers[i].AnswerId == Questions[i].RightAnswer.AnswerId)
                {
                    grade += Questions[i].Mark;
                }

                Console.WriteLine();
            }

            #endregion

            #region Show Final Result

            Console.WriteLine("Exam Result");
            Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");
                Console.WriteLine($"Your Answer: {userAnswers[i]}");
                Console.WriteLine();
            }

            Console.WriteLine($"Grade: {grade} / {totalMarks}");

            #endregion
        }

        #endregion
    }
}