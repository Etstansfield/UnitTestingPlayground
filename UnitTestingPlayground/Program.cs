using System;

namespace UnitTestingPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Person test = new Person { FirstName = "Ed", LastName = "Big Dolla" };
            DummyCsv.AddPerson(test);
        }
    }
}
