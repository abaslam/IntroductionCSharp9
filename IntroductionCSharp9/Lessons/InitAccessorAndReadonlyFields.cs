using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class InitAccessorAndReadonlyFields
    {
		public static void Run()
        {
			var person = new ReadOnlyPerson { FirstName = "What", LastName = "Is this?" };
			//person.FirstName = "Another";

		}
    }

	public class ReadOnlyPerson
	{
		readonly string _firstName;
		readonly string _lastName;

		public string FirstName
		{
			get => _firstName;
			init => _firstName = value;
		}

		public string LastName
		{
			get => _lastName;
			init => _lastName = value;
		}
	}
}
