using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace GradeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Initiate Variables
            String firstName;
            String grade1, grade2, grade3, grade4;
            Double gradeTotal = 0, avgGrade = 0;
            Double grade1Dbl = 0, grade2Dbl = 0, grade3Dbl = 0, grade4Dbl = 0;


            //Enter Name
            Console.WriteLine("Hello, please enter your name: ");


            firstName = Console.ReadLine();
            //Enter grade 1
            Console.WriteLine($"Hello {firstName}, please enter your first number grade. ");
            grade1 = Console.ReadLine();
            //Grade 2
            Console.WriteLine($"Your first number is {grade1}. Please enter your second number grade. ");
            grade2 = Console.ReadLine();
            //Grade 3
            Console.WriteLine($"Your second number is {grade2}. Please enter your third number grade. ");
            grade3 = Console.ReadLine();
            //Grade 4
            Console.WriteLine($"Your third number is {grade3}. Please enter your fourth number grade. ");
            grade4 = Console.ReadLine();
            //Show all grades
            Console.WriteLine($"\nThank you {firstName}. Your four number grades are {grade1}, {grade2}, {grade3}, {grade4}. Averaging out your grades...");
            //Gotta make it accurate
            Console.WriteLine("\nAveraging...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nAlmost Done...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nDone!");


            //Convert to Doubles
            grade1Dbl = Convert.ToDouble(grade1);
            grade2Dbl = Convert.ToDouble(grade2);
            grade3Dbl = Convert.ToDouble(grade3);
            grade4Dbl = Convert.ToDouble(grade4);


            //Make a grade total
            gradeTotal = grade1Dbl + grade2Dbl + grade3Dbl + grade4Dbl;


            //Get the average
            avgGrade = gradeTotal / 4;

            if (avgGrade >= 90)
            {
                Console.WriteLine($"\n{firstName}, your average letter grade is an A. Congrats!");
            } else if (avgGrade >= 80)
            {
                Console.WriteLine($"\n{firstName}, your average letter grade is a B.");
            } else if (avgGrade >= 70)
            {
                Console.WriteLine($"\n{firstName}, your average letter grade is a C.");
            } else if (avgGrade >= 65)
            {
                Console.WriteLine($"\n{firstName}, your average letter grade is a D.");
            } else
            {
                Console.WriteLine($"\nSorry, {firstName}, your average letter grade is an F. You failed.");
            }
        }
    }
}
