﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld15
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            System.Console.Write("Please Enter your name: ");
            string s = System.Console.ReadLine();
            System.Console.WriteLine("Hello " + s);
            System.Console.ReadLine();
        }
    }
}