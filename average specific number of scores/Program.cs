using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average_specific_number_of_scores
{
    class Program
    {
        static void Main(string[] args)

        {

            int sum = 0;
            Console.WriteLine("Please enter the number of tests");
            var numberOfTestScores = int.Parse(Console.ReadLine());
            int[] num = new int[numberOfTestScores];

            for (int i = 0; i < numberOfTestScores; i++)
                do
                {
                    Console.WriteLine("Enter Score between 0 and 100: ");
                   num[i] = int.Parse(Console.ReadLine());
                } while (num [i] < 0 || num [i] > 100);

            for (int i = 0; i < numberOfTestScores; i++)
            {
                sum += num[i];
            }
            int avg;
            avg = sum / numberOfTestScores;
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
