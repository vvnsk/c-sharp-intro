using System;
// using System.Speech.Synthesis;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.Name = "Sai's Grade Book";
            book.Name = null; // Would be skipped by setter
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            // GradeBook book2 = new GradeBook();
            // book2.AddGrade(75);

            // GradeBook book3 = book;
            // book3.AddGrade(75);

            // SpeechSynthesizer synth = new SpeechSynthesizer();
            // synth.Speak("Hello! This is the grade book program");
        }

        // Method overloading by a different signature - name and params
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            // F2 is floating with 2 decimals
            // Console.WriteLine("{0} : {1: F2}", description, result);

            // C is currency
            // Console.WriteLine("{0} : {1: F2}", description, result);

            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}
