using ExamSystem.Models;
using ExamSystem.Exams;
namespace ExamSystemRoute
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject subject = new Subject(1, "C#");

            subject.CreateExam();

            Console.WriteLine();
            Console.WriteLine("Press Enter To Start Exam...");
            Console.ReadLine();

            Console.Clear();

            subject.Exam.ShowExam();

        }
    }
}
