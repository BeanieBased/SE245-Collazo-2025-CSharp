using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



//Duncan and Justyn
namespace Week1_ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiating Variables
            String strFirst, strOperand, strNum1, strNum2;
            Double intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dblResult;

            // Saying hi
            Console.WriteLine("Hello There!");

            // Getting user input for first name to save to strFirst
            Console.WriteLine("Please enter your first name: ");
            strFirst = Console.ReadLine();

            // Using the user first name to say lets do math
            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");

            // Entering num1
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            // What operation does the user want to do and save that to strOperand to use later
            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): "); //Multiply never happens !! :)
            strOperand = Console.ReadLine().ToUpper();

            // Second Number to save to num2
            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            //Parsing num1 and convering num2 to int
            intNum1 = Convert.ToDouble(strNum1);

            intNum2 = Convert.ToDouble(strNum2); 


            //Switch statement for operation picked to do what the operation is
            switch (strOperand)
            {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    intResult = intNum1 - intNum2;                          
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
                case "MULTIPLY":
                    intResult = intNum1* intNum2;
                    break;
            }
            //If its a decimal, convert it to a double to show the decimal
            dblResult = (Double)intResult;

            //Telling you the answer
            if (strOperand == "PLUS")
            {
                Console.WriteLine("\n\nThe Sum of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);

            }
            else if (strOperand == "MINUS")
            {
                Console.WriteLine($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            }
            else if (strOperand == "DIVIDE")
            {
                Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals:{dblResult}");

            }
            else if (strOperand == "MULTIPLY")
            {
                Console.WriteLine($"\n\nThe result of {intNum1} and {intNum2} equals: {dblResult}");
            }
        

                // Continue?
                Console.WriteLine("\n\nPress any Key to Continue"); //Useless!!
            Console.ReadKey();
        }
    }
}