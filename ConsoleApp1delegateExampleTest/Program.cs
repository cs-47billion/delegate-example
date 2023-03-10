﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1delegateExampleTest
{

    delegate int addition(int x, int y);
    class myclass
    {
        public int add(int p, int q)
        {
            return p + q;
        }
        public int mul(int p, int q)
        {
            return p * q;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass m = new myclass();

            addition a = m.add;
            addition b = m.mul;
            addition tot = a + b;
            int r = tot(3, 5);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
} 
