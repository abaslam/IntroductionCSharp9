using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class InitOnlySetters
    {
        public static void Run()
        {
            var person = new Person { FirstName = "Ahamed", LastName = "Aslam" };
            //person.FirstName = "testc";
        }
    }

    public class Person
    {
       
        public string FirstName { get;  init; }
        public string LastName { get; init; }
    }

    public class AnotherPerson
    {
        public AnotherPerson()
        {

        }
        public AnotherPerson(string firstName)
        {
            this.FirstName = firstName;
        }

        public string FirstName { get; init; }
        public string LastName { get; init; }

        public void Set()
        {
            //this.FirstName = "testc";
        }

    }

    public class OldPerson
    {
        public OldPerson(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; } = "Default";
        public string LastName { get; }
    }

}
