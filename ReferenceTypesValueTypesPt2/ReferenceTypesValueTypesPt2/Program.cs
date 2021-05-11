using System;

namespace ReferenceTypesValueTypesPt2
{

    public class Person
    {
        public int Age;
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var number = 1;
            Increment(number);

            // not affected by Increment number because of scoping
            Console.WriteLine(number); // 1

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); // 30
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
