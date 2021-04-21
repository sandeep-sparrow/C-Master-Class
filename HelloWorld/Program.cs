using HelloWorld.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,     // by default = 0
        RegisteredAirMain = 2,  // by default = 1
        Express = 3             // by default = 2
    }
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

            string path = @"c:\projects\sandeep\files"; // verbatim string
            Console.WriteLine(path);


            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString());

            // we have string -> enum

            var methodName = "Express";
            // parsing
            var shippingmethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),methodName);
            Console.WriteLine(shippingmethod);

            //copying value type and reference type
            var a = 10;         // integers are value type
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0} & b: {1}", a, b));

            var array1 = new int[] { 1, 2, 3 }; // array are object in C#, hence they are called reference type
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine("array1[0]: {0} & array2[0]: {1}", array1[0], array2[0]);

            int number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person1 = new Person() { Age = 30 };
            Console.WriteLine(person1.Age);
            AgeNumber(person1);
            Console.WriteLine(person1.Age);

            Console.Read();

        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void AgeNumber(Person person)
        {
            person.Age += 20;
        }

    }
}
