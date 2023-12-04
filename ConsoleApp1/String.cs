using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    internal class String
    {
        static void Main(string[] args)
        {
            //string s = "Namaste";
            //Console.WriteLine(s.Length);
            //Console.WriteLine(s.ToLower());
            //Console.WriteLine(s.ToUpper());

            // String Concatenation

            //string name = "sharad";
            //string sName = " aade";
            //Console.WriteLine(name + sName);

            // Another way of string Concatenation
            //string full = string.Concat(name, sName);
            //Console.WriteLine(full);

            //int x = 10;
            //int y = 20;
            //int z = x + y;
            //Console.WriteLine(z);


            //string i = "10";
            //string j = "20";
            //string k = i + j;
            //Console.WriteLine(k);


            // String Interpolation

            //string firstName = "Sharad";
            //string midName = "S.";
            //string lastName = "Aade";
            //string allName = $"your name is {firstName} {midName} {lastName}";
            //Console.WriteLine(allName);

            //string this_is_string = "Sharad S. Aade";
            //Console.WriteLine(this_is_string.Length);
            //Console.WriteLine(this_is_string[8]);
            //Console.WriteLine(this_is_string.IndexOf("e"));


            // Substring => it extract the string from assigned string onword to end 


            //string name = "John Doe";

            // Location of the letter n
            //int charPos = name.IndexOf("n");

            // Get last name
            //string lName = name.Substring(charPos);

            // Print the result
            //Console.WriteLine(lName);

            // Escape sequence =>
            // \'   => '
            // \"   => "
            // \\   => \
            // \n   =>new line
            // \t   => tab
            // \b   => backspace

            string myName = "It\'s me sharad aade";
            Console.WriteLine(myName);








        }
    }
}
