using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalScore = 0, avgScore = 0;
            int cont = 0, numScores = 0;
            List<double> examScores = new List<double>();

            do
            {
                numScores++;
                Console.Write("Enter exam score to calculate average: ");
                examScores.Add(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Press 1 to enter another score, press 0 to calculate: ");
                cont = Convert.ToInt32(Console.ReadLine());
            } while (cont != 0);

            totalScore = examScores.Sum();
            avgScore = (totalScore / numScores) / 100;

            Console.WriteLine($"Average score: {avgScore:P}");
            Console.ReadKey();
        }
    }
}
