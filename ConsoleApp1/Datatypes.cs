using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_notes
{
    internal class Datatypes
    {
        static void Main(string[] args)
        {
            // literals => 
            // 1. Only allow with A-Z, 0-9, Underscore
            // @ only at starting not use at the end.
            // Identifire should not start with number

            // Object datatype => we can store any type of data
            object @i23 = 25;
            object _s664 = "sharad";
            object t356 = true;

            int i = 24;
            string s = "Sharad";
            bool b = true;
            float f = 2.323f;
            double d = 677.6734823568d;


            Console.WriteLine(@i23.GetType());
            Console.WriteLine(_s664.GetType());
            Console.WriteLine(t356.GetType());


            // Initialization Variable

            int this_is_int; // declaration of variable
            this_is_int = 34; //  initialization of variable

            int m = 78; // declaration + initialization

            // Notes => All identifier are not variable.
            //          but all variable names are identifier.


            // Variable => Variable is used to name a memory location,
            //              which holds a value

            // Identifier => Identifier is used to name a variable , function,
            //              class, structure etc.

            // literals or Constant value =>

            int zebra = 2763;
            Console.WriteLine(zebra);

            // here 2763 is a literal or constant value

        }
    }
}
