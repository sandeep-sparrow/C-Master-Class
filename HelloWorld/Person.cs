using System;

namespace HelloWorld
{
    partial class Program
    {
        public class Person
        {
            public string FirstName;
            public string SecondName;

            public void Introduce()
            {
                Console.Beep();
                Console.WriteLine("Hi, My name is {0} {1}", FirstName, SecondName);
            }
        }
        
    }
}
