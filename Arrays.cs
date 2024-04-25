namespace CSharpFundamentals
{
    static class Arrays
    {
        public static void Practice()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;

            // the first one is initialized to 1. The others are initialized to 0 by default.
            Console.WriteLine(numbers[0]); // 1
            Console.WriteLine(numbers[1]); // 0
            Console.WriteLine(numbers[2]); // 0

            var flags = new bool[3];
            flags[0] = true;

            // if you have an array of booleans, all elements in that array would be initialized to false.
            Console.WriteLine(flags[0]); // True
            Console.WriteLine(flags[1]); // False
            Console.WriteLine(flags[2]); // False

            var names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
