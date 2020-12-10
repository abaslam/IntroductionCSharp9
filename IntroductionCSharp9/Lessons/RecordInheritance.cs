using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class RecordInheritance
    {
        public static void Run()
        {
            var student1 = new Student("Joe", "Bloggs", 123);
            var student2 = student1 with { FirstName = "Josephine" };

            Console.WriteLine(new { student1, student2 });
        }
    }

    public record PersonRecord4(string FirstName, string LastName);

    public record Student(string FirstName, string LastName, int StudentID) : PersonRecord4(FirstName, LastName);
}
