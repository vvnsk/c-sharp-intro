using System;
// using System.Speech.Synthesis;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // SpeechSynthesizer synth = new SpeechSynthesizer();
            // synth.Speak("Hello! This is the grade book program");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            // GradeBook book2 = new GradeBook();
            // book2.AddGrade(75);

            // GradeBook book3 = book;
            // book3.AddGrade(75);
        }
    }
}
