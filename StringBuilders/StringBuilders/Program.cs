using System;
using System.Text;

namespace StringBuilders
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // you don't need to add string as value in StringBuilder but you can
            var builder = new StringBuilder("Hello World");

            // we can chain all the methods or do eg. builder.Replace();
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
