using System;

namespace Operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b); // 3.333333

            var c = 1;
            var d = 2;
            var e = 3;

            //on a mathetimatical perspective, b should multiply by c first and then added to a
            Console.WriteLine(c + d * e); // 7  (C# behaves as expected)

            Console.WriteLine((c + d) * e); // in this case the result is 9
            Console.WriteLine(c > d); // False
            Console.WriteLine(c == d); // False
            Console.WriteLine(c != d); // True
            Console.WriteLine(!(c != d)); // False (this code isn't to understand. Avoid it)
            Console.WriteLine(e > d && d > c); // True
            Console.WriteLine(e > d && d == c); // False
            Console.WriteLine(e > d || d == c); // True
            Console.WriteLine(!(e > d || d == c)); // False
        }
    }
}
