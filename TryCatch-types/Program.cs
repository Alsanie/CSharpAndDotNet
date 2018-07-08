using System;

namespace TryCatch_types
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new NullReferenceException("name can't be null");
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                person.Name = null;
            }
            catch(NullReferenceException nullRef)
            {
                Console.WriteLine("Null reference exception");
                Console.WriteLine(nullRef);
                // you may need to do this if you want the caller of Main() to catch the exception as well
                throw; // (Optional) Used to proxy chain the exception to upper level (caller)
            }
            catch(Exception ex)
            {
                Console.WriteLine("All other exceptions");
                Console.WriteLine(ex);
                throw; // Optional
            }
        }
    }
}
