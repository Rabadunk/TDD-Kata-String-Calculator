using System;
using System.Linq;

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

            string[] stringNumArray = CustomDelimiterSplit(NumString);
            return GetSumFromStringArray(stringNumArray);
        }

        private static string[] StringSplitter(string StringToBeSplit, string[] delimiters)
        {
            var stringArray = StringToBeSplit.Split(delimiters, StringSplitOptions.None);
            return stringArray;
        }
        
        private static string[] CustomDelimiterSplit(string StringToCheckAndSplit)
        {
            string[] stringNumArray = StringSplitter(RemoveDelimiterSection(StringToCheckAndSplit), GetDelimiter(StringToCheckAndSplit));
            return stringNumArray;
        }

        private static string[] GetDelimiter(string StringWithDelimiter)
        {
            string[] defaultDelimiters = {",", "\n"};
            if (!StringWithDelimiter.Contains("//")) return defaultDelimiters;
            
            var endOfDelimiterIndex = StringWithDelimiter.IndexOf('\n', 0);
            string[] customDelimiters = {StringWithDelimiter.Substring(2, endOfDelimiterIndex - 2)};
            return customDelimiters;
        }

        private static string RemoveDelimiterSection(string OldString)
        {
            var endOfDelimiterIndex = OldString.IndexOf('\n', 0);
            var lengthOfNewString = OldString.Length - endOfDelimiterIndex;
            return OldString.Substring(endOfDelimiterIndex, lengthOfNewString);
        }

        private static int[] GetIntArrayFromStringArray(string[] StringArray)
        {
            return StringArray.Select(int.Parse).ToArray();
        }

        private static int GetSumFromStringArray(string[] NumStringArray)
        {
            var sum = 0;   
            foreach (var element in NumStringArray)
            {
                int.TryParse((string) element, out var num);
                sum += num;
            }
            return sum;
        }

    }
}
