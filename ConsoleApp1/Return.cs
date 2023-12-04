using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Return
    {
        static void Main(string[] args)
        {
            //int zebra =  addition(4, 7);
            //Console.WriteLine(zebra);
            addition(4, 7);
        }

        static int addition( int a, int b)
        {
            //int r = a + b;
            return a + b;
        }
    }
}
