using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class SmallFeatures
    {
        public static void Run()
        {
            // Stativ lambdas
            var capitals = "This is a test".Select(static c => char.ToUpper(c));
            Console.WriteLine(string.Join("", capitals));


            // The following fails to compile, because we're attempting to capture someLocalVariable:
            //string someLocalVariable = ".";
            //var capitals1 = "This is a test".Select(static c => char.ToUpper(c) + someLocalVariable);


            // Attributes to local functions
            [MyAttribute]
            void SomeLocalFunction()
            {
                Console.WriteLine("I am using attribute");
            }

            SomeLocalFunction();

            // functions pointers
            FunctionPointer();
        }

        public unsafe static void FunctionPointer()
        {
            delegate*<string, int> functionPointer = &GetLength;

            // Here's how to invoke it:
            int length = functionPointer("Hello, world");
            Console.WriteLine(length);

            // A function pointer is a pointer, not an object:
            Console.WriteLine(((nuint)functionPointer));

            static int GetLength(string s) => s.Length;
        }
    }

    public class MyAttribute : Attribute { }

    [System.Runtime.CompilerServices.SkipLocalsInit]
    struct Foo
    {
        public int X, Y, Z;
    }

}
