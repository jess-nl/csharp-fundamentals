using System;
using Classes.Math;

namespace Classes
{
    class MainClass
    {
        public static void Main(string[] args)
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
