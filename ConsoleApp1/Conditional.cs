using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    internal class Conditional
    {
        static void Main(string[] args)
        {
            //string Name = "Tech";
            //if(Name == Class1.Name)
            //{
            //    Console.WriteLine("It's working");
            //}
            //else
            //{
            //    Console.WriteLine("Condition is not matched");
            //}

            //int num = 7;

            //if(num == 25)
            //{
            //    Console.WriteLine("num is equal to 25 ");
            //}
            //else if(num == 50)
            //{
            //    Console.WriteLine(" num is equal to 50");
            //}
            //else if (num == 70)
            //{
            //    Console.WriteLine("num is  equal to 70");
            //}
            //else if(num == 75)
            //{
            //    Console.WriteLine("num is equal to 75");
            //}
            //else
            //{
            //    Console.WriteLine("num is not matched");
            //}



            //int ok = 40;
            //if (ok >= 30)
            //{
            //    Console.WriteLine("first condition");
            //    int okin = 10;
            //    if(okin == 70)
            //    {
            //        Console.WriteLine("Is equal to 70");
            //    }
            //    else
            //    {
            //        Console.WriteLine("OK");
            //    }
            //}

            // Switch case =>

            //string name = "sharad";
            //string name = "ganesh";

            //switch(name)
            //{
            //    case "sharad":
            //        Console.WriteLine("this is sharad");
            //        break;

            //    case "dattu":
            //        Console.WriteLine("this is dattu");
            //        break;

            //    case "ganesh":
            //        Console.WriteLine("this is ganesh");
            //        break;

            //    case "vinod":
            //        Console.WriteLine("this is vinod");
            //        break;

            //    case "jack":
            //        Console.WriteLine("this is jack");
            //        break;

            //    default:
            //        Console.WriteLine("Not match any condition");
            //        break;

            //}


            int i = 5;

            switch(i)
            {
                case 0:
                    Console.WriteLine("i am zero");
                    break;

                case 1:
                    Console.WriteLine("i am one");
                    break;

                case 2:
                    Console.WriteLine("i am two");
                    break;

                case 3:
                    Console.WriteLine("i am three");
                    break;

                case 4:
                    Console.WriteLine("i am four");
                    break;

                case 5:
                    Console.WriteLine("i am five");
                    break;

                default:
                    Console.WriteLine("Not match any number");
                    break;
            }




        }
    }
}
