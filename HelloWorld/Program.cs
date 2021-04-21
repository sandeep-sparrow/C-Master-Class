using HelloWorld.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Person();
            person.FirstName = "Mistu";
            person.SecondName = "Pratikbhai Prajapati";
            person.Introduce();

            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 2);
            Console.WriteLine("Add method Result is: " + result);

            // int[] Numbers = new int[3];
            var Numbers = new int[3];
            Numbers[0] = 10;
            Console.WriteLine(Numbers[0]);
            Console.WriteLine(Numbers[1]);
            Console.WriteLine(Numbers[2]);

            var Flags = new bool[3];
            Flags[0] = true;
            Console.WriteLine(Flags[0]);
            Console.WriteLine(Flags[1]);
            Console.WriteLine(Flags[2]);

            Console.Read();

        }
        
    }
}
