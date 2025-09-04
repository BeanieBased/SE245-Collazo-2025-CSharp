// Justyn Collazo 8.6.25
using System;

namespace Lab3MethodsGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStudents = 3;
            int numLabs = 5;
            string[] studentNames = new string[numStudents];
            double[,] grades = new double[numStudents, numLabs];
            double[] labSums = new double[numLabs];

            InputStudentData(studentNames, grades, labSums, numStudents, numLabs);

            Console.WriteLine("Perfect! Calculating...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Almost done...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Done!");

            //Display students and calculate averages
            Console.WriteLine("\n-=- Student Grades and Letter Averages -=-\n");

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student: {studentNames[i]}");

                Console.Write("Lab Grades: ");
                for (int j = 0; j < numLabs; j++)
                {
                    Console.Write(grades[i, j] + (j < numLabs - 1 ? ", " : ""));
                }

                //ref
                double studentAverage = 0;
                CalculateAverage(grades, i, numLabs, ref studentAverage);

                //return
                string letter = GetLetterGrade(studentAverage);
                Console.WriteLine($"\nAverage Grade: {studentAverage:F2}");
                Console.WriteLine($"Average Letter Grade: {letter}\n");
            }

            // Output lab averages
            Console.WriteLine("-=- Class Lab Averages -=-\n");
            for (int j = 0; j < numLabs; j++)
            {
                double labAvg = labSums[j] / numStudents;
                Console.WriteLine($"Lab #{j + 1} Average: {labAvg:F2}");
            }
        }

        //void
        static void InputStudentData(string[] studentNames, double[,] grades, double[] labSums, int numStudents, int numLabs)
        {
            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter the name of student #{i + 1}: ");
                studentNames[i] = Console.ReadLine();

                for (int j = 0; j < numLabs; j++)
                {
                    Console.Write($"Enter grade #{j + 1} for {studentNames[i]}: ");
                    while (!double.TryParse(Console.ReadLine(), out grades[i, j]) || grades[i, j] < 0 || grades[i, j] > 100)
                    {
                        Console.Write("Invalid input. Please enter a valid grade (0–100): ");
                    }
                    labSums[j] += grades[i, j]; //Add to overall lab totals
                }

                Console.WriteLine();
            }
        }

        //return
        static string GetLetterGrade(double avg)
        {
            if (avg >= 90)
                return "A";
            else if (avg >= 80)
                return "B";
            else if (avg >= 70)
                return "C";
            else if (avg >= 65)
                return "D";
            else
                return "F";
        }

        //ref
        static void CalculateAverage(double[,] grades, int studentIndex, int numLabs, ref double avg)
        {
            double total = 0;
            for (int j = 0; j < numLabs; j++)
            {
                total += grades[studentIndex, j];
            }
            avg = total / numLabs;
        }
    }
}
