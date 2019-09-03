using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Program
    {
        class ValueY
        {
            public double value (double slope, double xValue, double yIntercept)
            {
                return slope * xValue + yIntercept;
            }
        }
        static void Main(string[] args)
        {
            //The first method that you will need to create is to calculate the y value of a line,
            //given by the slope(m), the x value (x) and the y intercept (b).  
            //Your method should be named LineValueForY with a return type of double. 
            //Y.  Your method should accept 3 parameters, all of type double. 
            //The first parameter will be the slope of the line (name this parameter m),
            //the second parameter should be the x value (name this parameter x)
            //and the last parameter should be the y intercept (name this parameter b). 
            //The formula to calculate the Y value is Y = mx + b

            double m = 0, x = 0, b = 0, y = 0;

            ValueY calc = new ValueY();

            Console.Write("Enter the slope (m): ");
             m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the X Value (x): ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Y Intercept (b): ");
            b = Convert.ToDouble(Console.ReadLine());

            y = calc.value(m, x, b);

            Console.WriteLine($"Y Value: {y}");
            Console.ReadKey();

        }
    }
}
