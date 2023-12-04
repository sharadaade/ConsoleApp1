using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ternary
    {
        static void Main(string[] args)
        {
            double temp = 25.00d;
            string str;

            str = (temp >= 20) ? "worm outside" : "cold outside";
            Console.WriteLine(str);

            // Type casting

            //int _i = 24;
            //double d = 9.78;
            //int dfinal = (int)d;
            //Console.WriteLine(dfinal.GetType());
            //Console.WriteLine(_i.GetType());


            // Take inpute from user

            //Console.WriteLine("Enter your name :");
            //string s = Console.ReadLine();
            //Console.WriteLine("Your name is " + s);


            // take inpute and convert into int  

            //Console.WriteLine("Enter your age :");
            //int i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is " + i );
        }
    }
}
