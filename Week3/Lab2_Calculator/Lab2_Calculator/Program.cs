// Jake Platt
// SE245
// 1/17/2026
// This program aims to calculate a student's average grade and corresponding letter grade based on four input grades.
//Using For and foreach loops, conditional statements, and arrays.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!, This is my Student Grade Calculator");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("For each student, please enter their first and last name, followed by five grades (0-100).");
            Console.WriteLine();

// Store all student data

            List<string> studentNames = new List<string>();
            List<double[]> allGrades = new List<double[]>();

            int numStudents = GetStudentCount();

// collect data for each student

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"\n--- Student {i + 1} of {numStudents}:");
                Console.WriteLine("Please enter the students first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter the students last name: ");
                string lastName = Console.ReadLine();

                //validate input grades (numeric and within range)

                double[] gradeInput = GetValidGrades(5, 0, 100);

                // Grade curve
                Console.WriteLine("Enter a curve amount to apply to these grades (0 or none): ");
                if (double.TryParse(Console.ReadLine(),out double curve))
                {
                    for (int j = 0; j < gradeInput.Length; j++)
                    {
                        // using ref keyword to update the array element directly
                        CurveGrade(ref gradeInput[j], curve);
                    }
                }
// Store student data

            studentNames.Add($"{firstName} {lastName}");
            allGrades.Add(gradeInput);
            }

// Display results for each student

            Console.WriteLine("\n--- Student Grade Results ---");
            for (int i = 0; i < numStudents; i++)
            {
                double average = allGrades[i].Average();
                string letterGrade = GetLetterGrade(average);
                Console.WriteLine($"Student Name: {studentNames[i]}");
                Console.Write("Lab Grades: ");

                // Display each grade
                foreach (var grade in allGrades[i])
                {
                    Console.Write($"{grade} ");
                }
                Console.WriteLine($"\nLetter Grade: {letterGrade} Average: {average}\n");
                }

// Display lab average for all students

            Console.WriteLine("--- Lab Average for All Students ---");

            for (int labNum = 0; labNum < 5; labNum++)
            {             
                double labAverage = allGrades.Average(grades => grades[labNum]);
                string letterGrade = GetLetterGrade(labAverage);

                foreach (double[] grades in allGrades)
                {
                    labAverage += grades[labNum];
                }
                labAverage /= numStudents;

                Console.WriteLine($"Lab {labNum + 1} Average: {labAverage:F2}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


// Get and validate the number of students
        private static int GetStudentCount()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of students to process: ");
                string input = Console.ReadLine();
                int count;
                if (int.TryParse(input, out count) && count >= 5)
                {
                    return count;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
        }

        // Reads and validates `count` grades from console, ensuring numeric and within [min, max]

        private static int getStudentCount()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of students to process: ");
                string input = Console.ReadLine();
                int count;
                if (int.TryParse(input, out count) && count > 5)
                {
                    return count;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number 5 or greater");
                }
            }
        }

// Reads and validates `count` grades from console, ensuring numeric and within [min, max]

        private static double[] GetValidGrades(int count, double min, double max)
        {
            while (true)
            {
                Console.WriteLine($"Please enter {count} lab grades separated by spaces (between {min} and {max}): ");
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

        private static void CurveGrade(ref double grade, double curveAmount)
        {
            grade += curveAmount;
            
            // Kep the grade within range (0-100)
            if (grade > 100) grade = 100;
            if (grade < 0) grade = 0;
        }
    }
}
