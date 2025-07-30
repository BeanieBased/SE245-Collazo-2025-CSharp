// Justyn Collazo 7.30.25
using System;
using System.Collections.Generic;

namespace _5LabGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize all the super cool variables
            int numStudents = 3;
            int numLabs = 5;
            string[] studentNames = new string[numStudents];
            double[,] grades = new double[numStudents, numLabs]; //Arrays to store
            double[] labSums = new double[numLabs];

            // Put in student names and lab grades
            for (int i = 0; i < numStudents; i++) //While the student youre on is less than 3 students keep going
            {
                Console.Write($"Enter the name of student #{i + 1}: "); // Count student
                studentNames[i] = Console.ReadLine(); //save to the list

                for (int j = 0; j < numLabs; j++)  //Second list to count for lab grades under 5
                {
                    Console.Write($"Enter grade #{j + 1} for {studentNames[i]}: "); //Enter grade number for student
                    while (!double.TryParse(Console.ReadLine(), out grades[i, j]) || grades[i, j] < 0 || grades[i, j] > 100) //Makes sure that the grade is within 0-100
                    {
                        Console.Write("Invalid input. Please enter a valid grade (0–100): "); //Error otherwise
                    }
                    labSums[j] += grades[i, j]; //Adds it to lab total
                }

                Console.WriteLine(); //Spacing between students "\n"
            }
            Console.WriteLine("Perfect! Calculating...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Almost done...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Done!");

            //Output every student
            Console.WriteLine("\n-=- Student Grades and Letter Averages -=-\n");
            for (int i = 0; i < numStudents; i++) //Goes through so it goes through all students
            {
                Console.WriteLine($"Student: {studentNames[i]}"); //Student 1-3

                double total = 0;
                Console.Write("Lab Grades: "); 
                for (int j = 0; j < numLabs; j++)
                {
                    Console.Write(grades[i, j] + (j < numLabs - 1 ? ", " : "")); //Shows all their lab grades individually
                    total += grades[i, j];
                }

                double avg = total / numLabs;
                string letter = GetLetterGrade(avg);

                Console.WriteLine($"\nAverage Letter Grade: {letter}\n"); //Gets an average of all their lab grades, and turns it into a letter grade after calling function
            }

            // Output lab averages
            Console.WriteLine("-=- Class Lab Averages -=-\n");
            for (int j = 0; j < numLabs; j++) 
            {
                double labAvg = labSums[j] / numStudents;
                Console.WriteLine($"Lab #{j + 1} Average: {labAvg:F2}"); //Class average Grades 2 decimal places
            }
        }

        static string GetLetterGrade(double avg) //Function to get letter grades
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
    }
}
