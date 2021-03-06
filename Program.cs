﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> checkPrimeNumber = x =>
             {
                 bool isPrime = false;
                 int i;
                 for (i = 2; i <= x - 1; i++)
                 {
                     if (x % i == 0)
                     {
                         isPrime = false;
                         break;
                     }
                 }
                 if (i == x)
                 {
                     isPrime = true;
                 }
                 return isPrime;
             };

            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrimeNumber = checkPrimeNumber(number);
            Console.WriteLine($"{number} is {(isPrimeNumber ? "" : "not")} prime number");
            Console.ReadKey();
            

        }
    }
}
