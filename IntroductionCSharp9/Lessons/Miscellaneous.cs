using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCSharp9.Lessons
{
    public class Miscellaneous
    {
        public static void Run()
        {
            var p1 = new Point(10, 3, "xx");

            // Traget typed new expression
            Point p2 = new Point(10, 2, "xx");
            Point p = new(3, 5, "Inch");
            Console.WriteLine(p);

            // Covariant return types
            Console.WriteLine(new B().Clone());

            //Extended partial methods
            Console.WriteLine(new A1().Test1());
            new A1().Test2(out var s); 
            
            Console.WriteLine(s);


            // GetEnumerator extension
            foreach (int i in 10)
            {
                Console.WriteLine(i);
            }
        }
    }

    class A
    {
        public virtual A Clone() => new A();
    }

    class B : A
    {
        public override B Clone() => new B();
    }

    class C
    {

    }

    partial class A1
    {
        public partial string Test1();
        public partial string Test1(string name);
        public partial string Test2(out string s);
    }

    partial class A1
    {
        public partial string Test1() => "Hello, world";

        public partial string Test2(out string s) => s = "Hello, world";
    }

    partial class A1
    {
        public partial string Test1(string name) => "Hello";
    }

    
    static class Extensions
    {
        public static IEnumerator<int> GetEnumerator(this int x) =>
            Enumerable.Range(0, x).GetEnumerator();
    }
}
