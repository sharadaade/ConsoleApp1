using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Method
    {
        static void Main(string[] args)
        {
            // Method => performs a section of code,
            //           whenever it's called 'invoked'.

            //String name = "sharad aade";
            //int age = 24;
            // function call
            //sayMyName(name,age);


            int m = multiplication(2, 5, 5);
            Console.WriteLine(m);

        }

        //static void sayMyName(String myname, int old)
        //{
        //    Console.WriteLine("my name is " + myname + " " + old + " old");
        //}

        static int multiplication(int a, int b)
        {
            return a * b;
        }
        static int multiplication(int a, int b,int c)
        {
            return a * b * c;
        }
    }
}
