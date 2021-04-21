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

            // value data type int, float, double, char, bool
            // reference data types stores only the memmory location of data type
            // string, class, Array

            int num1 = 13;
            int num2 = 13;
            int sum = num1 + num2;
            Console.WriteLine("Sum of int types {0} + {1} = {2} ", num1, num2, sum);

            double d1 = 3.5;
            double d2 = 1.337;
            double sumd = d1 + d2;
            Console.WriteLine("Sum of double type {0} + {1} = {2} ", d1, d2, sumd);

            // type casting
            double myDouble = 13.27;
            int myInt;
            myInt = (int)myDouble;      // Explicit conversion
            Console.WriteLine(myInt);

            int num = 1234567856;
            long bigNum = num;          // implicit conversion
            Console.WriteLine(bigNum);

            // type conversion
            string myString = myDouble.ToString();
            Console.WriteLine(myString);

            float myFloat = 12.12f;
            string myFloatString = myFloat.ToString();
            Console.WriteLine(myFloatString);

            // String Parsing
            string str1 = "15";
            string str2 = "15";
            var sum1 = str1 + str2;
            Console.WriteLine("Sum: {0} + {1} = {2}", str1, str2, sum1);

            int int1 = Int32.Parse(str1);
            int int2 = Int32.Parse(str2);
            var sum2 = int1 + int2;
            Console.WriteLine("Sum: {0} + {1} = {2}", int1, int2, sum2);

            Console.ReadLine();
        }
    }
}
