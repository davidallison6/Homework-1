using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an application that asks the user for their exam score,
            //add their input to an accumulator and then ask the user if they have another score to enter.
            //If they do, ask for the exam score and repeat the process until they say no.  
            //Make sure that their answer is case insensitive 
            //(e.g. they can say Yes or yes and your code treats it the same). 
            //Once they say no, calculate the average of all of the exam scores based upon your accumulator 
            //and your counting variable.
            //Make sure that you use some sort of a While Loop, an accumulating variable
            //(to keep track of the total exam scores), and a counting variable
            //(to keep track of the number of scores they entered).

            double examScores = 0, newScore;
            double avgScore;
            char userInput;
            int cont = 0, numExams = 1;

            do
            {

                Console.Write($"Enter exam {numExams} score: ");
                newScore = Convert.ToDouble(Console.ReadLine());
                examScores = newScore + examScores;
                Console.Write("Press Y to enter another test score, press N to calculate the average score: ");
                userInput = Convert.ToChar(Console.ReadLine());
                userInput = char.ToLower(userInput);
                
                if (userInput == 'y')
                {
                    numExams++;
                    cont = 2;
                }
                else if (userInput == 'n')
                {
                    cont = 1;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            } while (cont != 1);

            avgScore = (examScores / numExams) / 100;

            Console.WriteLine($"Average Exam Score: {avgScore:P}");
            Console.ReadKey();
        }
    }
}
