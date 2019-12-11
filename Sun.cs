using System;
using System.Text;

namespace SunSingleton
{
    // Singleton
    public class Sun
    {
        public static readonly Sun sun = new Sun(); // The ONLY Sun instance
        public readonly string Color;
        public readonly int RadiusInKm;
        public readonly double AgeInBillionYears;

        // private makes sure that a Sun object will NOT be created outside this class
        // Namely, there is ONLY ONE Sun object = Singleton
        private Sun()
        {
            Color = "Yellow";
            RadiusInKm = 696342;
            AgeInBillionYears = 4.6;
        }

        /// <summary>
        /// Prints a yellow sunshine message
        /// </summary>
        public void Shine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The Sun is shining! :){Environment.NewLine}");
            Console.ResetColor();
        }

        /// <summary>
        /// Prints the Sun ONLY instance's details
        /// </summary>
        public void PrintDetails()
        {
            var details = new StringBuilder();
            details.AppendLine($"Color: {Color}");
            details.AppendLine($"Radius: {RadiusInKm} km");
            details.AppendLine($"Age: {AgeInBillionYears} billion years");
            Console.WriteLine(details.ToString());
        }
    }
}
