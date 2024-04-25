namespace CSharpFundamentals
{
    static class ListMethods
    {
        public static void Practice()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var n in numbers)
                Console.WriteLine(n);
            /*
                1
                2
                3
                4
                1
                5
                6
                7
             */

            // search in beginning of list
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // Index of 1: 0

            // search at end of list
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1)); // Last Index of 1: 4

            Console.WriteLine("Count: " + numbers.Count); // Count: 8

            Console.WriteLine("Remove 1:");
            numbers.Remove(1);
            foreach (var n in numbers)
                Console.WriteLine(n);
            /*
                2
                3
                4
                1
                5
                6
                7
            */

            Console.WriteLine("Remove all 1:");
            // remove all ones 1 in list
            numbers.Remove(1);
            foreach (var n in numbers)
            {
                if (n == 1)
                {
                    numbers.Remove(n);
                }
            }
            foreach (var n in numbers)
                Console.WriteLine(n);
            /*
                2
                3
                4
                5
                6
                7

            OR it's throwing an error: "Collection was modified: enumeration operation may not execute"
            note: in c#, we're not allowed to modify collection in foreach loop. You can avoid this using for loop.
            */

            // remove all ones 1 in list (to avoid console error)
            Console.WriteLine("Remove all 1:");
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var n in numbers)
                Console.WriteLine(n);
            /*
                2
                3
                4
                5
                6
                7
            */

            // this removes all elements from list
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count); // Count: 0
        }
    }
}
