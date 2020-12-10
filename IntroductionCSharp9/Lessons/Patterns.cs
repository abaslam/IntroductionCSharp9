using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class Patterns
    {
        public static void Run()
        {
            // Relational pattern
            Console.WriteLine(GetWeightCategory(16.5m));
            Console.WriteLine(GetWeightCategory(22.3m));

            // Pattern combinations
            int x = 150;
            if (x > 100 && x < 200)
            {

            }
            if (x is > 100 and < 200)
            {
                Console.WriteLine($"{x} is between 100 and 200");
            }

            char c = 'e';
            //if(c=='a' || c=='e' ||)

            if (c is 'a' or 'e' or 'i' or 'o' or 'u')
            {
                Console.WriteLine($"{c} is a vowel");
            }

            // 'and' has higher precedence than 'or'. You can use parentheses to override precedence.

            // Combinators are also useful in switches:

            Console.WriteLine(GetWeightJudgement(16.5m));
            Console.WriteLine(GetWeightJudgement(22.3m));

            // Relational patterns and types

            // The relational pattern implicitly tests for type.

            object obj = 100.0;
            Console.WriteLine(obj.GetType());   // n is a double.

            // The following prints true because n is a double and less than 200:
            if (obj is < 200.0)
            {
                Console.WriteLine($"{obj} is less than (double)200.0");
            }

            // The following prints false because n is not an int:
            if (obj is < 200)
            {
                Console.WriteLine($"{obj} is less than (int)200");
            }

            // The following prints true because we first test the type:
            if (obj is double and < 200)
            {
                Console.WriteLine($"{obj} is less than (double)200");
            }

            // The following also prints true:
            if (obj is < 200 or < 200.0)
            {
                Console.WriteLine($"{obj} is less than (int)200 or less than (double)200");
            }

            //Not pattern

            // The 'not' pattern is a great way to test for an object (not) being a type:

            var s = new object();

            if (s is not string)
            {
                Console.WriteLine("Not a string");
            }

            // Looks nicer than:

            if (!(s is string))
            {
                Console.WriteLine("Not a string");
            }

            // Lamda discard

            // The underscore can now be used as a 'discard' in lambda expressions:

            Console.WriteLine(string.Join("", "Password".Select(_ => "*")));

            // (This feature is more useful when there are multiple parameters, because they can all be _)

        }

        private static string GetWeightCategory(decimal bmi) => bmi switch
        {
            < 18.5m => "underweight",
            < 25m => "normal",
            < 30m => "overweight",
            _ => "obese"
        };

        private static string GetWeightJudgement(decimal bmi) => bmi switch
        {
            >= 18.5m and < 25m => "healthy",
            < 15m or > 30m => "very unhealthy",
            _ => "somewhat unhealthy"
        };
    }
}
