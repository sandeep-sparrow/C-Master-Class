using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Sandeep";
            person.Introduce();

            Console.Read();

        }
        public class Person
        {
            public string Name;
            public void Introduce()
            {
                Console.Beep();
                Console.WriteLine("Hi, My name is: {0}", Name);
            }
        }
    }
}
