using System;
using System.Text;

namespace SunSingleton
{
    public class Program
    {
        // Made by Guy Kaplan
        // Sun Singleton DP (Design Pattern) in C#
        static void Main(string[] args)
        {
            var msg = new StringBuilder();
            msg.AppendLine("---Made by Guy Kaplan---");
            msg.Append("This program is an example of the Singleton DP ");
            msg.AppendLine("(Design Pattern)");
            msg.AppendLine("(There is ONLY ONE Sun object in this program)");
            Console.WriteLine(msg.ToString());

            PrintCodeAndResult("var sun = new Sun();", false);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--Compilation error-- (Sun is a Singleton...)");
            Console.ResetColor();
            Console.WriteLine();

            PrintCodeAndResult("Sun.sun.Shine();");
            Sun.sun.Shine(); // The Singleton ONLY instance

            PrintCodeAndResult("Sun.sun.PrintDetails();");
            Sun.sun.PrintDetails(); // The Singleton ONLY instance

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }//end of main

        /// <summary>
        /// Prints the code tried and its result
        /// </summary>
        /// <param name="code">The code that has been executed</param>
        public static void PrintCodeAndResult(string code, bool addComment = true)
        {
            Console.Write($"Code: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{code}");
            if (addComment)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" // The Singleton ONLY instance");
            }
            else
            {
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine("Result:");
        }
    }
}
