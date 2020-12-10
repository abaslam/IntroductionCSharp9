using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class StructuralEquality
    {
        public static void Run()
        {
            var person1 = new PersonRecord1 { FirstName = "Joe", LastName = "Bloggs" };
            var person2 = new PersonRecord1 { FirstName = "Joe", LastName = "Bloggs" };
            Console.WriteLine($"person1=persone2:{person1.Equals(person2)}");

            var person3 = person1 with { };

            Console.WriteLine($"person1=persone2=person3:{person1.Equals(person2) && person1.Equals(person3)}");

            var person4 = person3 with {LastName = "Changed" };

            Console.WriteLine($"person3=person4:{person3.Equals(person4)}");
        }
    }

    public record PersonRecord1
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
}
