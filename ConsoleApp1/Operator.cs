using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operator
    {
        static void Main(string[] args)
        {
            // assignment operator
            //int n; // declaration
            //n = 12; // initialization

            //int m = 23; // initialization  + declaration

            //int z = n + m;
            //double d = 2334.34d;
            //float f = 2423.34f;
            //bool b = true;
            //char symbol = '@';
            //string username = "sharad";
            //String password = "aade";


            //Console.WriteLine(n);
            //Console.WriteLine(m);
            //Console.WriteLine(z);
            //Console.WriteLine(d);
            //Console.WriteLine(f);
            //Console.WriteLine(b);
            //Console.WriteLine(symbol);         
            //Console.WriteLine("username is " + username);         
            //Console.WriteLine("password is " + password);

            //Constant 
            //const int i = 25;
            //const char c_const = 'a';
            //const double dd = 23.45d;
            //const float pi = 3.14f;



            // type casting 

            //double z = 3.345;
            //int zfinal = Convert.ToInt32(z);
            //Console.WriteLine(zfinal);
            //string st = Convert.ToString(z);

            //Console.WriteLine(z.GetType());
            //Console.WriteLine(zfinal.GetType());
            //Console.WriteLine(st.GetType());

            //bool boo = true;
            //string bo1 = Convert.ToString(boo);

            //Console.WriteLine(bo1.GetType());

            // Math

            double m = 9.99;
            int i = 20;
            int j = 23;

            double res = Math.Pow(m,2);
            double res1 = Math.Ceiling(m);
            double res2 = Math.Floor(m);
            double res3 = Math.Sqrt(m);
            double res4 = Math.Round(m);
            int maximun = Math.Max(i, j);
            int minimum = Math.Min(i, j);

            //Console.WriteLine(res);
            //Console.WriteLine(res1);
            //Console.WriteLine(res2);
            //Console.WriteLine(res3);
            //Console.WriteLine(res4);
            //Console.WriteLine(maximun);
            //Console.WriteLine(minimum);


            // assignment operator

            //int first = 30;
            //first += 1;
            //Console.WriteLine(first);

            //first /= 5;
            //Console.WriteLine(first);

            // Escape sequence
            string jack = "It's sharad aade";
            string jack1 = "It\'s sharad aade";
            Console.WriteLine(jack);
            Console.WriteLine(jack1);

            string zebra = "it\"s sharad aade";
            Console.WriteLine(zebra);
        }
    }
}
