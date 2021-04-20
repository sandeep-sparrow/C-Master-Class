using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = 13;
            int num2 = 13;
            int sum = num1 + num2;
            Console.WriteLine("Sum of int types {0} + {1} = {2} ", num1, num2, sum);
            double d1 = 3.5;
            double d2 = 1.337;
            double sumd = d1 + d2;
            // value data type int, float, double, char, bool
            // reference data types stores only the memmory location of data type
            // string, class, Array
            Console.WriteLine("Sum of double type {0} + {1} = {2} ", d1, d2, sumd);
            Console.ReadLine();
        }
    }
}
