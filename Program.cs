using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld15
{
    class Program
    {
       /*
        * 
        * Program to introduce people to C#
        * Uses string and integer variables
        * It introduces the if statement
        */
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            System.Console.Write("Please Enter your name: ");
            string sName = System.Console.ReadLine();
            System.Console.WriteLine("Hello " + sName);
            System.Console.Write("How old are you " + sName + ": ");
            int age = 0;
            string s = System.Console.ReadLine();
            // If the string entered contains a . then its not an integer
            if (s.Contains("."))
            {
                //The Double.Parse will return a double so if we want an integer
                double d = Double.Parse(s);
                //we need to cast it as an int - (int)
                age = (int) System.Math.Round(d);
            }
            else //So if it doesn't contain . assume it is an integer
            {
                age = Int16.Parse(s);
            }           
            System.Console.WriteLine("Are you really " + age + " " + sName);
            System.Console.ReadLine();
        }
    }
}
