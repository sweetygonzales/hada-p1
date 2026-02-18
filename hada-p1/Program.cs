using System;

namespace hada_p1
{
    /// <summary>
    /// Main class of the program that handles user input and calls conversion methods.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        /// <param name="args">Command-line arguments (not used)</param>
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter unit (seconds/minutes):");
                string unit = Console.ReadLine().Trim().ToLower();

                Console.WriteLine("Enter value:");
                double value = double.Parse(Console.ReadLine());

                if (unit == "seconds")
                    Console.WriteLine($"{value} seconds = {HadaP1.Seconds2Minutes(value)} minutes");
                else if (unit == "minutes")
                    Console.WriteLine($"{value} minutes = {HadaP1.Minutes2Seconds(value)} seconds");
                else
                    Console.WriteLine("Invalid unit");

                Console.WriteLine("Do you want to continue? (y/n)");
                choice = Console.ReadLine().Trim().ToLower();
            } while (choice == "y");
        }
    }
}
