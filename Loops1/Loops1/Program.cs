using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an application that will keep prompting the user to input all 3 of their exam grades
            //(using a For loop).  Calculate the average of their exam scores and output the result.
            //When you display the result, make sure to use a Format Specifier for percentages.

            double avgScore;
            double[] examScores = new double[3];

            for(int i = 0; i <= 2; i++)
            {
                Console.Write($"Enter Exam {i + 1} score: ");
                examScores[i] = Convert.ToDouble(Console.ReadLine());
            }

            avgScore = (examScores.Sum() / 3) / 100;

            Console.WriteLine($"Average Exam Score: {avgScore:P}");
            Console.ReadKey();


        }
    }
}
