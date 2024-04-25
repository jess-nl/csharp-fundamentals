namespace CSharpFundamentals
{
    static class StringMethods
    {
        public static void Practice()
        {
            var fullName = "Jay Domingos ";
            Console.WriteLine("Trim:: '{0}'", fullName.Trim()); // Trim: 'Jay Domingos'
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper()); // ToUpper: 'JAY DOMINGOS'

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);

            var lastName = fullName.Substring(index + 1);
            //same as: var lastName = fullName.Substring(index);

            Console.WriteLine("FirstName: " + firstName); // FirstName: Jay
            Console.WriteLine("LastName: " + lastName); // LastName: Domingos

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]); // FirstName: Jay
            Console.WriteLine("LastName: " + names[1]); // LastName: Domingos

            Console.WriteLine(fullName.Replace("Domingos", "Mina")); // Jay Mina

            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid"); // this prints

            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid"); // this prints

            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid"); // this DOES NOT print

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid"); // this prints
            // same as (the following is the newest version):
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid"); // this prints

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age); // 25

            float price = 29.95f;
            Console.WriteLine(price.ToString()); // 29.95
            Console.WriteLine(price.ToString("C")); // $29.95
            Console.WriteLine(price.ToString("C0")); // $30.00
            Console.WriteLine(price.ToString("C1")); // $30.0
        }
    }
}