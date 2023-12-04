using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Constructor
    {
     
        static void Main(string[] args)
        {
            // Constructor => A special method in class
            //                Same name as the class name
            //                Can be used to assign arguments to fields when creating an object

            Man obj1 = new Man();

        }
    }
    public class Man
    {
        public Man()
        {
            Console.WriteLine("Hello from Constructor");
        }
    }

}
