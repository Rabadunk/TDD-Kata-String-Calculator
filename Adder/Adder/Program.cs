using System;

namespace Adder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Add(string NumString)
        {
            if (NumString == "")
            {
                return 0;
            }
            
            if(NumString.Length == 1 && int.TryParse(NumString, out var singleDigit))
            {
                return singleDigit;
            }

            return 1;
        }
    }
}