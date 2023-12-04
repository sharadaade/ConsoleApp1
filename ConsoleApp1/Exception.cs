using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exception
    {
        static void Main(string[] args)
        {
            // try => try some code that is considered "dangerous"
            // catch => catches and handles exception when they occur
            // finally => always execute regardless if exception is caught or not
            double x;
            double y;
            double result;

            try
            {
                Console.WriteLine("Enter first number :");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number :");
                y = Convert.ToDouble(Console.ReadLine());

                result = x + y;
                Console.WriteLine(result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter Number only");
            }
            finally
            {
                Console.WriteLine("Thank you");
            }
        }
    }
}
