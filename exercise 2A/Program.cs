using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfNumbers = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int number;
                bool condition = true;
                do
                {
                    Console.WriteLine($"Enter number {i}: ");
                    number = int.Parse(Console.ReadLine());
                    if (number < 0 || number > 100)
                    {
                        Console.WriteLine("number must be between 0 and 100");
                    }
                    else
                    {
                        condition = false;
                    }
                } while (condition);
                listOfNumbers[i] = number;
            }
            for (int i = 0; i < 10; i++)
            {
                sum = sum + listOfNumbers[i];
            }
            Console.WriteLine("Thes sum of your numbers is : {0}", sum);
            Console.ReadLine();
        }
    }
}
