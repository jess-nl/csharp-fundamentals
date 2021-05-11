using System;

namespace ReferenceTypesValueTypesPt1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a: 10, b: 11

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); // array1[0]: 1, array2[0]: 1
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0])); // array1[0]: 0, array2[0]: 0
        }
    }
}
