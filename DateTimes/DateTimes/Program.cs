using System;

namespace DateTimes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            // it was 5:19PM when I ran the app:
            Console.WriteLine("Hour: " + now.Hour); // Hour: 17
            Console.WriteLine("Minute: " + now.Minute); // Minute: 19

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString()); // April 15, 2021
            Console.WriteLine(now.ToShortDateString()); // 2021 - 04 - 15
            Console.WriteLine(now.ToLongTimeString()); // 5:29:18 PM
            Console.WriteLine(now.ToShortTimeString()); // 5:29 PM
            Console.WriteLine(now.ToString()); // 2021-04-15 5:30:20 PM
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); // 2021-04-15 17:34
        }
    }
}
