using ExamSystem.Models;
namespace ExamSystemRoute
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Test Answer Class

            Answer answer1 = new Answer(1, "C#");
            Answer answer2 = new Answer(2, "JS");

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);

            #endregion
        }
    }
}
