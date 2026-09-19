using ExamSystem.Models;
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

            Answer[] mcqAnswers =
            {
    new Answer(1, "C#"),
    new Answer(2, "Java"),
    new Answer(3, "Python")
};

            MCQQuestion mcqQuestion = new MCQQuestion(
                "MCQ Question",
                "Which language are we using?",
                5,
                mcqAnswers,
                mcqAnswers[0]
            );

            Console.WriteLine(mcqQuestion);
            Answer[] trueFalseAnswers =
{
    new Answer(1, "True"),
    new Answer(2, "False")
};

            TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion(
                "True / False Question",
                "C# is an object-oriented programming language.",
                5,
                trueFalseAnswers,
                trueFalseAnswers[0]
            );

            Console.WriteLine();
            Console.WriteLine(trueFalseQuestion);
            #endregion
        }
    }
}
