using System;

namespace dlinden_BinaryNumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 42;
            Console.WriteLine(x);

            //Converts x to a number in base 2
            string x_binary = "0b" + Convert.ToString(x, 2);
            Console.WriteLine(x_binary);

            //Converts x to a number in base 16
            string x_hex = "0x" + Convert.ToString(x, 16);
            Console.WriteLine(x_hex);
        }
    }
}
