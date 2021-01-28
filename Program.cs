using System;

namespace GradeCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your expected garde for ISM4300");
            try
            {
                string input = Console.ReadLine();
                double grade = double.Parse(input);
                if (grade >= 90)
                {
                    Console.WriteLine("Your expected grade for ISM4300 is 'A' ");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Your expected grade for ISM4300 is 'B' ");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine("Your expected grade for ISM4300 is 'C' ");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Your expected grade for ISM4300 is 'D' ");
                }
                else
                {
                   Console.WriteLine ("Your expected grade for ISM4300 is 'F' ");
                   
                }
            }
            catch
            {
                Console.WriteLine("Please use an integer for your expected garde");
            }
        }
    }
}
