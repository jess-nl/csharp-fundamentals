using CSharpFundamentals.Helpers;

namespace CSharpFundamentals
{
    static class Conditionals
    {
        public static void Practice()
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
                // this gets printed
                Console.WriteLine("It's morning.");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon.");
            else
                Console.WriteLine("It's evening");

            // ----------------------------------------------------

            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
            Console.WriteLine(price); // 19.95

            float price2 = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price2); // 19.95

            // ----------------------------------------------------

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    // this gets printed
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfet to go to the beach.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;

            }

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("You've got a promotion");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;

            }
        }
    }
}
