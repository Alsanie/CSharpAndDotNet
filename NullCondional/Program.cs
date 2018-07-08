using System;

namespace NullCondional
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = null;

            // Option 1: old way
            if(person != null)
                Console.WriteLine(person.Name);

            // Option 2: new way
            Console.WriteLine(person?.Name);

            // Option 3: combined with null coalescing
            Console.WriteLine(person?.Name ?? "Name is null");
        }
    }
}
