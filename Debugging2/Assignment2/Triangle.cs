using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging2.Assignment2
{
    internal class Triangle
    {
        /*
         * The expected output of this program should look like 
         * 
         * For n=5 for example
         * 
         *     *
              ***
             *****
            *******
           *********
         * 
         * However the program contains some bugs. Debug and fix the program.
         * To run create a project and change the name of "ChangeToMain" method to Main
         * 
         */
        public static void PrintEquilateralTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int spaces = n - i - 1;

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        /* The following program tries to calculate the factorial of a number.
         * But it contains some bugs. Fix the bugs using debugging
         * 
         * A factorial of a non negative number is defined as
         * for n >0 n! = n*(n-1)*(n-2)....*3*2*1
         * for n=0 n! = 1
         * Example 5! = 5*4*3*2*1 = 120
         */
        public static int CalculateFactorial(int n)
        {
            if (n < 0)
            {
                return 0;
            }

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result - i;
            }
            return result;
        }


        public static void ChangeToMain(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            PrintEquilateralTriangle(rows);

            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());

            int factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }
    }
}
