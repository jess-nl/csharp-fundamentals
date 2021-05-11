using System;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string firstName = "Jay";
            string lastName = "Lo";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName); // Jay Lo

            var myFullName = string.Format("My name is {0} {1}.", firstName, lastName);
            Console.WriteLine(myFullName); // My name is Jay Lo.

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames); // John, Jack, Mary

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            /*
                Hi John
                Look into the following paths
                c:\folder1\folder2
                c:\folder3\folder4
            */

            var text2 =
@"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text2);
            /*
                Hi John
                Look into the following paths
                c:\folder1\folder2
                c:\folder3\folder4
            */
        }
    }
}