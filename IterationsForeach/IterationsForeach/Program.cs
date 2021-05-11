using System;

namespace IterationsForEach
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var name = "Joe Smith";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // same as:

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // ----------------------------------------

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
