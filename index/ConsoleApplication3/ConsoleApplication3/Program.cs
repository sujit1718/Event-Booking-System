﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("A is greater");
                Console.ReadLine();
            }
            else if(b > a && b > c)
            {
              Console.WriteLine("B is greater");
              Console.ReadLine();
            }
            else if(c > a && c > b)
            {
                Console.WriteLine("C is greater");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
