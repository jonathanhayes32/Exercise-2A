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
            int numberOfTestScores;
            Console.WriteLine("Please enter the number of tests");
            numberOfTestScores = int.Parse(Console.ReadLine());
            
            int number1;
            int number2;
            int number3;
            int number4;
            int number5;
            int number6;
            int number7;
            int number8;
            int number9;
            int number10;
            Console.WriteLine("Enter value 1");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 2");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 3");
            number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 4");
            number4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 5");
            number5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 6");
            number6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 7");
            number7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 8");
            number8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 9");
            number9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 10");
            number10 = int.Parse(Console.ReadLine());
            int avg;
            avg = ((number1 + number2 + number3 + number4 + number5 +
                      number6 + number7 + number8 + number9 + number10) / 10);
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
