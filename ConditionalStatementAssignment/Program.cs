/*
 Author: Christopher Mejia
 Date: 1/24/2019
 Comments: This is my conditional statements assignment for the grading scale
*/

using System;

namespace ConditionalStatementAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInteger;
            string userInput;

            Console.WriteLine("What grade do expect to get in ISM 4300 (Please enter an integer value 0-100)?");

            
            try
            {
                userInput = Console.ReadLine();
                while (userInput != "EXIT")
                {
                    userInteger = int.Parse(userInput);

                    Calculate_Grade(userInteger);
                    Console.WriteLine("");
                    Console.WriteLine("Type 'EXIT' to close out program or enter another value to indicate new grade letter.");
                    userInput = Console.ReadLine();
                }

                Environment.Exit(0);
                
            }

            catch
            {
                Console.WriteLine(" ");
                Console.WriteLine("Error occurred... Please try again. Make sure a numerical value was typed!");
                Console.WriteLine(" ");

                Console.WriteLine("What grade do expect to get in ISM 4300 (Please enter an integer value 0-100)?");
                
                try
                {
                    userInput = Console.ReadLine();
                    while (userInput != "EXIT")
                    {
                        userInteger = int.Parse(userInput);

                        Calculate_Grade(userInteger);
                        Console.WriteLine("");
                        Console.WriteLine("Type 'EXIT' to close out program or enter another value to indicate new grade letter.");
                        userInput = Console.ReadLine();
                    }

                    Environment.Exit(0);
                }

                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Try again next time. Press any key to exit.");
                    Console.ReadKey(true);
                }
                
            }
        }

        private static void Calculate_Grade(int grade)
        {
            if ((grade >= 98) && (grade <= 100))
            {
                Console.WriteLine("Grade: A+");
            }

            else if ((grade >= 92) && (grade <= 97))
            {
                Console.WriteLine("Grade: A");
            }

            else if ((grade >= 90) && (grade <= 91))
            {
                Console.WriteLine("Grade: A-");
            }

            else if ((grade >= 88) && (grade <= 89))
            {
                Console.WriteLine("Grade: B+");
            }

            else if ((grade >= 82) && (grade <= 87))
            {
                Console.WriteLine("Grade: B");
            }

            else if ((grade >= 80) && (grade <= 81))
            {
                Console.WriteLine("Grade: B-");
            }

            else if ((grade >= 78) && (grade <= 79))
            {
                Console.WriteLine("Grade: C+");
            }

            else if ((grade >= 72) && (grade <= 77))
            {
                Console.WriteLine("Grade: C");
            }

            else if ((grade >= 70) && (grade <= 71))
            {
                Console.WriteLine("Grade: C-");
            }

            else if ((grade >= 68) && (grade <= 69))
            {
                Console.WriteLine("Grade: D+");
            }

            else if ((grade >= 62) && (grade <= 67))
            {
                Console.WriteLine("Grade: D");
            }

            else if ((grade >= 60) && (grade <= 61))
            {
                Console.WriteLine("Grade: D-");
            }

            else if ((grade >= 0) && (grade <= 60))
            {
                Console.WriteLine("Grade: F");
            }

            else
            {
                Console.WriteLine("Please enter a numerical value between 0-100");
            }
        }
    }
}
