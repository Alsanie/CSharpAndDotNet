using System;

namespace TryCatch_Filtering
{
    // Custom exception
    class PersonException : Exception
    {
        public PersonException(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new PersonException("Kim");
                throw new PersonException("Jim");
            }
            catch (PersonException ex) when(ex.Name == "Kim")
            {
                Console.WriteLine("This is Kim exception");
            }
            catch (PersonException ex) when (ex.Name == "Jim")
            {
                Console.WriteLine("This is Jim exception");
            }
        }
    }
}
