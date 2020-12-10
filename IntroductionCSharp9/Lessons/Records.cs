using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class Records
    {
        public static void Run()
        {
            var person = new PersonRecord { FirstName = "Joe", LastName = "Bloggs" };

            var otherPerson = person with { FirstName = "Josephine" };

            var anotherPerson = person with { };


            var result = new
            {
                person,
                otherPerson
            };

            Console.WriteLine($"Person:{person}");
            Console.WriteLine($"otherPerson:{otherPerson}");
            Console.WriteLine($"result:{result}");
        }
    }

    public record PersonRecord
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }    
}
