using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application that prompts the user to enter the item they desire, 
            //and return the value / price of the item. Your console application should contain two parallel arrays, 
            //as well as an error if they enter or spell the item name incorrectly.

            //Array #1: should contain items apples, oranges, bananas, grapes, blueberries
            //Array #2: should contain prices for each item. Apples are 0.99, oranges are 0.50, bananas are 0.50,
            //grapes are 2.99, blueberries are 1.99.

            string[] items = new string[] {"apples", "oranges", "bananas", "grapes", "blueberries"};
            double[] price = new double[] { 0.99, 0.50, 0.50, 2.99, 1.99 };
            string userInput;
            double output = 0;

            Console.Write("Enter the desired item to display the price (apples, oranges, bananas, grapes, blueberries): ");
            userInput = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < items.Length - 1; i++)
            {
                if (items[i] == userInput.ToLower())
                {
                    output = price[i];
                    break;
                }
                else
                {
                    output = 0;
                    
                }
            }

            if(output > 0)
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
