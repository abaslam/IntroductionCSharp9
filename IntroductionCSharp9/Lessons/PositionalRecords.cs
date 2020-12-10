using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class PositionalRecords
    {
        public static void Run()
        {
            var person = new PersonRecord3("Joe", "Bloggs");
            Console.WriteLine($"person={person}");            
        }
    }

    public record PersonRecord3(string FirstName, string LastName);
}
