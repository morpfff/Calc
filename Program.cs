﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipiska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultadd;
            Console.WriteLine("vvedite pervoe pislo");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("vvedite vtoroe 4islo");
            b = Convert.ToInt32(Console.ReadLine());
            resultadd = a + b;
            Console.WriteLine("Summa = "+resultadd);
            Console.ReadKey();
        }
    }
}