using CSharpFundamentals.Helpers;

namespace CSharpFundamentals
{
    static class Classes
    {
        public static void Practice()
        {
            Person daisuke = new Person();
            daisuke.FirstName = "Daisuke";
            daisuke.LastName = "Niwa";
            daisuke.Introduce(); // My name is Daisuke Niwa

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
