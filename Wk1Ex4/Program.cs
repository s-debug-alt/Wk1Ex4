using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // take user input for length
            Console.WriteLine("What is the length of the rectangle: ");
            // delcare a double varable to hold user input
            double length = Convert.ToDouble(Console.ReadLine());
            // take user input for width
            Console.WriteLine("What is width of rectangle: ");
            // delcare a double varable to hold user input
            double width = Convert.ToDouble(Console.ReadLine());
            // message for results input
            Console.WriteLine("Results:");
            // calculate area 
            Console.WriteLine("Area of the rectangle: " + length * width);
            // calculate perimeter
            Console.WriteLine("Perimeter of the rectangle: " + 2 * ( length + width));
        }
    }
}
