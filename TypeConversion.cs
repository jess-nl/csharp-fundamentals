using System;

namespace CSharpFundamentals
{
    static class TypeConversion
    {
        public static void Practice()
        {
            byte a = 1;
            int i = a;
            Console.WriteLine(i);

            //int j = 1;
            //byte c = j; // Cannot implicitly convert type 'int' to 'byte'. An explicit conversion exists (are you missing a cast?)

            int k = 1000;
            byte d = (byte)k;
            Console.WriteLine(d); // 232

            var number = "1234";
            int l = Convert.ToInt32(number);
            Console.WriteLine(l); // 1234

            //var numb = "1234";
            //byte m = Convert.ToByte(numb);
            //Console.WriteLine(m); // System.OverflowException: Value was either too large or too small for an unsigned byte.

            // do as above but handle exception
            try
            {
                var numberr = "1234";
                byte n = Convert.ToByte(numberr);
                Console.WriteLine(n);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte."); // this gets executed
            }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b); // this gets executed
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


        }
    }
}
