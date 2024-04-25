using System;

namespace CSharpFundamentals
{
    static class TimeSpans
    {
        // TimeSpan represents a time interval, a duration
        public static void Practice()
        {
            // Creating
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(0, 1, 1);

            // interval of 1 hour
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration); // Duration: 00:02:00.0708940

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes); // Minutes: 2
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // Total Minutes: 62.05

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); // Add Example: 01:10:03
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); // Subtract Example: 01:00:03

            // ToString
            Console.WriteLine("ToString" + timeSpan.ToString()); // ToString01:02:03

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03")); // Parse: 01:02:03
        }
    }
}
