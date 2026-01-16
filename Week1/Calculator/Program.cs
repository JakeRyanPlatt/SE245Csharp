// Jake Platt
// SE245
// 1/18/2026
// This program aims to calculate a student's average grade and corresponding letter grade based on four input grades. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!, This is my Student Grade Calculator");
            Console.WriteLine("Please enter the students first name: ");
            string First = Console.ReadLine();

            Console.WriteLine("Please enter the students last name: ");
            string Last = Console.ReadLine();

            // Validate input grades (numeric and within range)
            double[] grades = GetValidGrades(4, 0, 100);
            double average = grades.Average();
            string letterGrade = GetLetterGrade(average);

            Console.WriteLine($"Student Name: {First} {Last} Letter Grade {letterGrade} Average {average} ");
        }

        // Reads and validates `count` grades from console, ensuring numeric and within [min, max]

        private static double[] GetValidGrades(int count, double min, double max)
        {
            while (true)
            {
                Console.WriteLine($"Please enter {count} grades separated by spaces (between {min} and {max}): ");
                string gradesInput = Console.ReadLine();
                string[] gradesString = gradesInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (gradesString.Length != count)
                {
                    Console.WriteLine($"You must enter exactly {count} values. You entered {gradesString.Length}.");
                    continue;
                }

                try
                {
                    // Parse and validate using LINQ, C# very cool
                    double[] grades = gradesString
                        .Select(s =>
                        {
                            double parsed;
                            if (!double.TryParse(s, out parsed))
                            {
                                throw new FormatException($"Value '{s}' is not a valid number.");
                            }

                            if (parsed < min || parsed > max)
                            {
                                throw new ArgumentOutOfRangeException(nameof(parsed), $"Value {parsed} is out of range ({min} - {max}).");
                            }

                            return parsed;
                        })
                        .ToArray();

                    return grades;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("One or more values were invalid. Please try again.");
                }
            }
        }

        // Function that returns letter grade based on average
        private static string GetLetterGrade(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
   }
}
