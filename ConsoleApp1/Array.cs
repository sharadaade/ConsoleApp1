using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Array
    {
        static void Main(string[] args)
        {
            // array => a variable that can store multiple values. fixed size
            //String[] cars = { "BMW", "Tata", "Hero", "Unicorn"};
            // indexing start from 0

            //cars[0] = "Mahindra";

            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);
            //Console.WriteLine(cars[3]);

            //String[] arr = new String[3];
            //arr[0] = "Mango";
            //arr[1] = "tomato";
            //arr[2] = "banana";

            //for(int j = 0; j < arr.Length; j++)
            //{
            //    Console.WriteLine(arr[j]);
            //}

            // foreach loop

            //foreach (var car in arr)
            //{
            //    Console.WriteLine(car);
            //}


            // Multi dimentinal array
            string[] arr1 = { "tomato", "cabbage", "carrot" };
            string[] arr2 = { "bmw", "hero", "unicorn" };
            string[] arr3 = { "sharad", "dattu", "ganesh" };

            string[,] final = { { "tomato", "cabbage", "carrot" },
                                { "bmw", "hero", "unicorn" },
                                { "sharad", "dattu", "ganesh" }
                              };

            final[0, 2] = "banana";

            foreach(string values in final)
            {
                Console.WriteLine(values);
            }
            

        }
    }
}
