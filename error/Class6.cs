﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.error
{
    class Class6
    {
        static void Main(string[] args)
        {
            checked
            {
                int m = int.MaxValue;
                Console.WriteLine(m + 2);

            }
            Console.Read();
        }
    }
}
