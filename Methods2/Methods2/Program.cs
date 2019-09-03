using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        class factorial
        {
            public int value (int num = 0)
            {
                int num2 = 1;
                while (num != 1)
                {
                    num2 = num2 * num;
                    num = num - 1;
                }
                return num2;
            }
        }
        static void Main(string[] args)
        {
            int userInput = 0, factorial = 0;

            factorial calc = new factorial();

            Console.Write("Enter a number to calculate its factorial: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            factorial = calc.value(userInput);

            Console.WriteLine($"Factorial of {userInput} is {factorial}");
            Console.ReadKey();
        }
    }
}
