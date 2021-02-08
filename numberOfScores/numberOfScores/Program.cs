using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateGrade();

        }

        private static void CalculateGrade()
        {

            float score, sum = 0, avg = 0; int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter your :{0} Score", i);
                score = float.Parse(Console.ReadLine());
                sum = sum + score;
            }
            avg = sum / (i - 1);
            Console.WriteLine("Average:" + avg);
            if (avg >= 90 && avg <= 100)
                Console.WriteLine(" Grade: A");
            else if (avg >= 80 && avg <= 89)
                Console.WriteLine(" Grade: B");
            else if (avg >= 70 && avg <= 79)
                Console.WriteLine(" Grade: C");
            else if (avg >= 60 && avg <= 69)
                Console.WriteLine(" Grade: D");
            else
                Console.WriteLine(" Grade: F");
            Console.Read();
        }
    }
}