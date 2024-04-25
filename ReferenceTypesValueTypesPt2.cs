namespace CSharpFundamentals
{

    public class Person2
    {
        public int Age;
    }

    static class ReferenceTypesValueTypesPt2
    {
        public static void Practice()
        {
            var number = 1;
            Increment(number);

            // not affected by Increment number because of scoping
            Console.WriteLine(number); // 1

            var person2 = new Person2() { Age = 20 };
            MakeOld(person2);
            Console.WriteLine(person2.Age); // 30
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person2 person)
        {
            person.Age += 10;
        }
    }
}
