using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be creating an application to help our sales associates sell our main products, cogs and gears.
            //Cogs have a whole sale price of $79.99 and gears have a whole sale price of $250.00. 
            //When our sales associates are selling to our customers on the floor, we have a standard 15% 
            //markup on our wholesale price for our sales price. 
            //However, if the customer purchases more than 10 of either item or a combined quantity of 16 items 
            //we only markup the items by 12.5%. 
            //On top of this, the sales tax for all sales is 8.9%.

            //Create a console application that will prompt the sales associate for the number of cogs 
            //as well as the number of gears for a sales order.  Create class level constant variables 
            //for the whole sale prices for the items as well as the markup percentages.  
            //Once the user has input all of the data, create a receipt and display the total cost for the 
            //items, the discount amount, the sales tax amount as well as the grand total. 
            //Format all values appropriately (e.g. percentages should have the appropriate format specifier, 
            //(same with currency)as well as make the receipt user friendly 
            //(e.g. do not just list all the values next to each other,
            //put on different lines and make sure to show what each value represents).

            int numCogs, numGears;
            double salesPrice, discount, gearSalesPrice = 0, cogSalesPrice = 0, salesTax, totalPrice, cogPrice = 79.99, gearPrice = 250.00, markup1 = .15, markup2 = .125, taxRate = .089;

            Console.Write("Enter the number of cogs sold: ");
            numCogs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of gears sold: ");
            numGears = Convert.ToInt32(Console.ReadLine());

            if (numCogs >= 15)
            {
                cogSalesPrice = cogPrice - cogPrice * markup1;
            }
            else if (numCogs >= 10 && numCogs < 15)
            {
                cogSalesPrice = cogPrice - cogPrice * markup2;
            }
            else
            {
                cogSalesPrice = cogPrice;
            }
       
            if (numGears >= 15)
            {
                gearSalesPrice = gearPrice - gearPrice * markup1;
            }
            else if (gearPrice >= 10 && gearPrice < 15)
            {
                gearSalesPrice = gearPrice - gearPrice * markup2;
            }
            else
            {
                gearSalesPrice = gearPrice;
            }

            if(numGears < 10 && numCogs < 10 && numGears + numCogs >= 16)
            {
                gearSalesPrice = gearPrice - gearPrice * markup2;
                cogSalesPrice = cogPrice - cogPrice * markup2;
            }

            salesPrice = numCogs * cogSalesPrice + numGears * gearSalesPrice;
            salesTax = salesPrice * taxRate;
            totalPrice = salesPrice + salesTax;
            discount = (numCogs * cogPrice + numGears * gearPrice) - salesPrice;

            Console.WriteLine($"Sales Price: {salesPrice:C} \nDiscount: {discount:C} \nTax: {salesTax:C}\nTotal Price: {totalPrice:C}");
            
            Console.ReadKey();
        }
    }
}
