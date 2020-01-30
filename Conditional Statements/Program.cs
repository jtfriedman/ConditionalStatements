using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the grade you hope to get in ISM4300");

            try
            {
                string input = Console.ReadLine();
                int grade = int.Parse(input);

                if (grade > 96)
                {
                    Console.WriteLine("Your grade will be an A+");
                }
                else if ((grade > 92) && (grade < 97))
                {
                    Console.WriteLine("Your grade will be an A");
                }
                else if ((grade > 90) && (grade < 91))
                {
                    Console.WriteLine("Your grade will be an A-");
                }
                else if ((grade > 88) && (grade < 89))
                {
                    Console.WriteLine("Your grade will be an B+");
                }
                else if ((grade > 82) && (grade < 87))
                {
                    Console.WriteLine("Your grade will be an B");
                }
                else if ((grade > 80) && (grade < 81))
                {
                    Console.WriteLine("Your grade will be an B-");
                }
                else if ((grade > 78) && (grade < 79))
                {
                    Console.WriteLine("Your grade will be an C+");
                }
                else if ((grade > 72) && (grade < 77))
                {
                    Console.WriteLine("Your grade will be an C");
                }
                else if ((grade > 70) && (grade < 71))
                {
                    Console.WriteLine("Your grade will be an C-");
                }
                else if ((grade > 68) && (grade < 69))
                {
                    Console.WriteLine("Your grade will be an D+");
                }
                else if ((grade > 62) && (grade < 67))
                {
                    Console.WriteLine("Your grade will be an D");
                }
                else if ((grade > 60) && (grade < 61))
                {
                    Console.WriteLine("Your grade will be an D-");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Your grade will be an F");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numerical value");
                Console.WriteLine("Please try again");
                Console.ReadKey(true);
            }
        }
    }
}
