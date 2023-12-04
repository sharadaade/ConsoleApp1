using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Function
    {
        static int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a = add(3, 5);
            Console.WriteLine(a);
        }
    }
}
