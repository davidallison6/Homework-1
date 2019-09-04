using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double output = 0;
            Dictionary<string, double> dict = new Dictionary<string, double>();
            dict.Add("apples", 0.99);
            dict.Add("oranges", 0.50);
            dict.Add("bananas", 0.50);
            dict.Add("grapes", 2.99);
            dict.Add("blueberries", 1.99);

            Console.Write("Enter the desired item to display the price (apples, oranges, bananas, grapes, blueberries): ");
            userInput = Console.ReadLine();

            if (dict.TryGetValue(userInput, out output))
            {
                Console.WriteLine($"The price of {userInput} is {output:C}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.ReadKey();
        }
    }
}
