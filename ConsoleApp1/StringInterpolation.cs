using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringInterpolation
    {
        static void Main(string[] args)
        {
            // string interpolation => allow us to insert variables into
            //                        a string literal precede a string literal
            //                        with ${} are placeholder
            string firstName = "Sharad";
            string lastName = "Aade";
            //int age = 24;
            string con = $"your name is {firstName} {lastName}";
            Console.WriteLine(con);

            //Console.WriteLine($"Hello {firstName} {lastName}.");
            //Console.WriteLine($"you are {age} old");

            // IndexOf()
            // How to access the second same character in one string
            Console.WriteLine(firstName.IndexOf('a'));
            Console.WriteLine(lastName.IndexOf('A'));




        }
    }
}
