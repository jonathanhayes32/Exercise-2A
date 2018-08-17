using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace non_specific_number_of_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testScores = new List<int>();
            Console.WriteLine("Please enter the number of test scores. Type -1 and the enter key to exit. ");
            var testGrades = int.Parse(Console.ReadLine());
            do
            {
                testGrades = int.Parse(Console.ReadLine());
                if (testGrades < -1 || testGrades > 100)
                {
                    Console.WriteLine("Error, please input a valid number. Type -1 and the enter key to exit.");
                }
                else if (testGrades == -1)
                {
                    break;
                }
                else
                {
                    testScores.Add(testGrades);
                }

            } while (testGrades != -1);
            int sum = 0;
            for (int i = 0; i < testScores.Count(); i++)
            {
                sum += testScores[i];
            }
            int avg;
            avg = sum / testScores.Count();
            Console.WriteLine("The average score is : {0}", avg);
            if ((avg >= 90) && (avg <= 100))
                Console.WriteLine("The letter grade is an A");
            else if ((avg >= 80) && (avg < 89))
                Console.WriteLine("The letter grade is a B");
            else if ((avg >= 70) && (avg < 79))
                Console.WriteLine("The letter grade is a C");
            else if ((avg >= 60) && (avg < 69))
                Console.WriteLine("The letter grade is a D");
            else
                Console.WriteLine("The letter grade is an F");
            Console.ReadLine();

        }
    }
}
