using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Object
    {
        static void Main(string[] args)
        {
            // Object => An instance of a class
            // A class can be used as blueprint to create object(OOP)
            // Object can have field and method

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "sharad";
            human1.age = 24;

            human1.eat();
            human1.sleep();

            human2.name = "ganesh";
            human2.age = 23;

            human2.eat();
            human2.sleep();

        }
    }
    class Human
    {
        public string name;
        public int age;


        public void eat()
        {
            Console.WriteLine(name +" is eatinng");
        }
        public void sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }

}
