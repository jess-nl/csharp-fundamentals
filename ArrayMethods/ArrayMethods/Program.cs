using System;

namespace ArrayMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 }; same as:
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length); // 6

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index); // Index of 9: 2

            // Clear() – set range of elements to default value
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effects of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            /*
                0
                0
                9
                2
                14
                6
             */

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effects of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);
            /*
                0
                0
                9
            */

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effects of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            /*
                0
                0
                2
                6
                9
                14
            */

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effects of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            /*
                14
                9
                6
                2
                0
                0
            */
        }
    }
}