using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public enum ShippingMethodDefault
    {
        RegularAirMail,
        RegisteredAirMail,
        Express
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method); // Express
            // cast it to an integer
            Console.WriteLine((int)method); // 3

            Console.WriteLine((ShippingMethod)3); // Express
            var methodId = 3;
            // convert an integer to a shipping method
            Console.WriteLine((ShippingMethod)methodId); // Express

            // explicitly tell it to convert to string
            Console.WriteLine(method.ToString()); // Express
            // the following still makes it into string
            Console.WriteLine(method); // Express

            var methodName = "Express";

            /* 
                this returns an object, and we don't want that:
                Enum.Parse(typeof(ShippingMethod), methodName);

                we actually want the return type to be ShippingMethod
                and so we do the following, we cast it:
             */
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod); // Express

            // --------------------------------------------------------

            var method_ = ShippingMethodDefault.Express;
            // cast it to an integer
            Console.WriteLine((int)method_); // 2
        }
    }
}
