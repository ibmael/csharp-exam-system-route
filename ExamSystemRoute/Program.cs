using ExamSystem.Models;
using ExamSystem.Exams;
namespace ExamSystemRoute
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Test Answer Class

            //Answer answer1 = new Answer(1, "C#");
            //Answer answer2 = new Answer(2, "JS");

            //Console.WriteLine(answer1);
            //Console.WriteLine(answer2);

            #endregion

            #region Test Question Types

            //            Answer[] mcqAnswers =
            //            {
            //    new Answer(1, "C#"),
            //    new Answer(2, "Java"),
            //    new Answer(3, "Python")
            //};

            //            MCQQuestion mcqQuestion = new MCQQuestion(
            //                "MCQ Question",
            //                "Which language are we using?",
            //                5,
            //                mcqAnswers,
            //                mcqAnswers[0]
            //            );

            //            Console.WriteLine(mcqQuestion);
            //            Answer[] trueFalseAnswers =
            //{
            //    new Answer(1, "True"),
            //    new Answer(2, "False")
            //};

            //            TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion(
            //                "True / False Question",
            //                "C# is an object-oriented programming language.",
            //                5,
            //                trueFalseAnswers,
            //                trueFalseAnswers[0]
            //            );

            //            Console.WriteLine();
            //            Console.WriteLine(trueFalseQuestion);
            #endregion

            #region Test Practical Exam

            //            Answer[] practicalAnswers =
            //            {
            //    new Answer(1, "HTML"),
            //    new Answer(2, "C#"),
            //    new Answer(3, "CSS")
            //};

            //            MCQQuestion practicalQuestion = new MCQQuestion(
            //                "MCQ Question",
            //                "Which of the following is a programming language?",
            //                5,
            //                practicalAnswers,
            //                practicalAnswers[1]
            //            );

            //            PracticalExam practicalExam = new PracticalExam(60, 1);

            //            practicalExam.Questions[0] = practicalQuestion;

            //            practicalExam.ShowExam();

            #endregion

            #region Test Final Exam

            //            Answer[] finalMcqAnswers =
            //            {
            //    new Answer(1, "HTML"),
            //    new Answer(2, "C#"),
            //    new Answer(3, "CSS")
            //};

            //            MCQQuestion finalMcqQuestion = new MCQQuestion(
            //                "MCQ Question",
            //                "Which of the following is a programming language?",
            //                5,
            //                finalMcqAnswers,
            //                finalMcqAnswers[1]
            //            );


            //            Answer[] trueFalseAnswers =
            //            {
            //    new Answer(1, "True"),
            //    new Answer(2, "False")
            //};

            //            TrueFalseQuestion finalTrueFalseQuestion = new TrueFalseQuestion(
            //                "True / False Question",
            //                "C# is an object-oriented programming language.",
            //                5,
            //                trueFalseAnswers,
            //                trueFalseAnswers[0]
            //            );


            //            FinalExam finalExam = new FinalExam(60, 2);

            //            finalExam.Questions[0] = finalMcqQuestion;
            //            finalExam.Questions[1] = finalTrueFalseQuestion;

            //            finalExam.ShowExam();

            #endregion

            #region Test Subject And Create Exam

            Subject subject = new Subject(1, "C#");

            subject.CreateExam();

            subject.Exam.ShowExam();

            #endregion
        }
    }
}
