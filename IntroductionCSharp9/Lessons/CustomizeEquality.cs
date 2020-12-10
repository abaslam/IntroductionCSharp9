using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
	public class CustomizeEquality
	{
		public static void Run()
		{
			var person1 = new PersonRecord2 { FirstName = "Joe", LastName = "Bloggs" };
			var person2 = new PersonRecord2 { FirstName = "JOE", LastName = "BLOGGS" };

			Console.WriteLine(person1.Equals(person2));
			Console.WriteLine(person1 == person2);
		}
	}

	public record PersonRecord2
	{
		public string FirstName { get; init; }
		public string LastName { get; init; }

		// Note the signature (virtual rather than override, and Person rather than object):	
		public virtual bool Equals(PersonRecord2 other) =>
			string.Equals(FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase) &&
			string.Equals(LastName, other.LastName, StringComparison.OrdinalIgnoreCase);

		// Overriding GetHashCode is the same as with a class or struct:
		public override int GetHashCode() => (FirstName.ToUpper(), LastName.ToUpper()).GetHashCode();

	}
}
