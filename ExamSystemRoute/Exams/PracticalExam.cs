using System;
using System.Collections.Generic;
using System.Text;

using ExamSystem.Models;

namespace ExamSystem.Exams
{
    internal class PracticalExam : Exam
    {
        #region Constructors

        public PracticalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        #endregion

        #region Methods

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
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

                Console.Write("Your Answer: ");
                int userAnswer;

                while (!int.TryParse(Console.ReadLine(), out userAnswer)
                       || userAnswer < 1
                       || userAnswer > Questions[i].AnswerList.Length)
                {
                    Console.Write("Invalid Answer, Enter Again: ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Right Answers:");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(
                    $"Question {i + 1}: {Questions[i].RightAnswer}"
                );
            }
        }

        #endregion
    }
}