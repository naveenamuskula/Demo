using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            double i, j;
            //accept the data in console application
            //implict conversion or boxing
            i = int.Parse(Console.ReadLine());
            int k, l;
            //explicit conversion or unboxing
            k = (int)double.Parse(Console.ReadLine());
            long m, n;
            m = (long)double.Parse(Console.ReadLine());
            l = (int)long.Parse(Console.ReadLine());
            Console.WriteLine(i);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine(l);
            Console.Read();

        }
    }
}
