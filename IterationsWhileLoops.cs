namespace CSharpFundamentals
{
    static class IterationsWhileLoops
    {
        public static void Practice()
        {
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }

            /*
            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                Console.WriteLine("@Echo: " + input);
            }

            same as:
            */

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; // this continue keyword means that it will continue the looping again by not continuing what's forward, but starting with the while (true) again

                }

                break;
            }
        }
    }
}