﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int y;
            double z;
            char w;
            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(w);
            Console.ReadLine();
        }
    }
}
