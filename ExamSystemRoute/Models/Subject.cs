using System;
using System.Collections.Generic;
using System.Text;

using ExamSystem.Exams;

namespace ExamSystem.Models
{
    internal class Subject
    {
        #region Properties

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

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
            Console.WriteLine($"Subject: {SubjectName}");
            Console.WriteLine("Choose Exam Type:");
            Console.WriteLine("1. Practical Exam");
            Console.WriteLine("2. Final Exam");

            int examType;

            do
            {
                Console.Write("Enter your choice: ");
            }
            while (!int.TryParse(Console.ReadLine(), out examType)
                   || (examType != 1 && examType != 2));

            int time;

            do
            {
                Console.Write("Enter Exam Time: ");
            }
            while (!int.TryParse(Console.ReadLine(), out time) || time <= 0);

            int numberOfQuestions;

            do
            {
                Console.Write("Enter Number of Questions: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions)
                   || numberOfQuestions <= 0);

            if (examType == 1)
            {
                Exam = new PracticalExam(time, numberOfQuestions);

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enter Question {i + 1}");

                    Console.Write("Enter Question Header: ");
                    string header = Console.ReadLine();

                    Console.Write("Enter Question Body: ");
                    string body = Console.ReadLine();

                    Console.Write("Enter Question Mark: ");
                    int mark;

                    while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
                    {
                        Console.Write("Invalid Mark, Enter Again: ");
                    }

                    Answer[] answers = new Answer[3];

                    for (int j = 0; j < answers.Length; j++)
                    {
                        Console.Write($"Enter Answer {j + 1}: ");
                        string answerText = Console.ReadLine();

                        answers[j] = new Answer(j + 1, answerText);
                    }

                    Console.Write("Enter Right Answer Id: ");
                    int rightAnswerId;

                    while (!int.TryParse(Console.ReadLine(), out rightAnswerId)
                           || rightAnswerId < 1
                           || rightAnswerId > answers.Length)
                    {
                        Console.Write("Invalid Answer Id, Enter Again: ");
                    }

                    MCQQuestion question = new MCQQuestion(
                        header,
                        body,
                        mark,
                        answers,
                        answers[rightAnswerId - 1]
                    );

                    Exam.Questions[i] = question;
                }
            }
            else
            {
                Exam = new FinalExam(time, numberOfQuestions);

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enter Question {i + 1}");

                    Console.WriteLine("Choose Question Type:");
                    Console.WriteLine("1. MCQ");
                    Console.WriteLine("2. True / False");

                    int questionType;

                    while (!int.TryParse(Console.ReadLine(), out questionType)
                           || (questionType != 1 && questionType != 2))
                    {
                        Console.Write("Invalid Choice, Enter Again: ");
                    }

                    Console.Write("Enter Question Header: ");
                    string header = Console.ReadLine();

                    Console.Write("Enter Question Body: ");
                    string body = Console.ReadLine();

                    Console.Write("Enter Question Mark: ");
                    int mark;

                    while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
                    {
                        Console.Write("Invalid Mark, Enter Again: ");
                    }

                    if (questionType == 1)
                    {
                        Answer[] answers = new Answer[3];

                        for (int j = 0; j < answers.Length; j++)
                        {
                            Console.Write($"Enter Answer {j + 1}: ");
                            string answerText = Console.ReadLine();

                            answers[j] = new Answer(j + 1, answerText);
                        }

                        Console.Write("Enter Right Answer Id: ");
                        int rightAnswerId;

                        while (!int.TryParse(Console.ReadLine(), out rightAnswerId)
                               || rightAnswerId < 1
                               || rightAnswerId > answers.Length)
                        {
                            Console.Write("Invalid Answer Id, Enter Again: ");
                        }

                        Exam.Questions[i] = new MCQQuestion(
                            header,
                            body,
                            mark,
                            answers,
                            answers[rightAnswerId - 1]
                        );
                    }
                    else
                    {
                        Answer[] answers =
                        {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

                        Console.Write("Enter Right Answer Id (1 for True, 2 for False): ");
                        int rightAnswerId;

                        while (!int.TryParse(Console.ReadLine(), out rightAnswerId)
                               || (rightAnswerId != 1 && rightAnswerId != 2))
                        {
                            Console.Write("Invalid Answer Id, Enter Again: ");
                        }

                        Exam.Questions[i] = new TrueFalseQuestion(
                            header,
                            body,
                            mark,
                            answers,
                            answers[rightAnswerId - 1]
                        );
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Exam Created Successfully.");
        }

        #endregion
    }
}