﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class loopex3
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            Console.WriteLine("do while");
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
            Console.WriteLine("While loop");
            while(j<5)
            {
                Console.WriteLine(i);
                i++;
            }j++;
            Console.Read();
        }
    }
}
