using System;
using Xunit;
using Adder;

namespace AdderTests
{
    public class AdderTests
    {
        [Fact]
        public void TestAdderForEmptyString()
        {           
            Assert.Equal(0, Adder.Program.Add(""));
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void TestAdderForSingleDigitNumbers(string input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, Adder.Program.Add(input));
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("4,5", 9)]
        public void TestAdderForTwoValidNumbers(string input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, Adder.Program.Add(input));
        }

        [Theory]
        [InlineData("1,2,3,4", 10)]
        [InlineData("1,2,3,4,5", 15)]
        [InlineData("1,2,3", 6)]
        public void TestAdderForAnyLengthOfNumbers(string input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, Adder.Program.Add(input));
        }

        [Theory]
        [InlineData("1,2\n3", 6)]
        [InlineData("3\n5\n3,9", 20)]
        public void TestAdderForDelimiterWithCommasAndNewLines(string input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, Adder.Program.Add(input));
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        [InlineData("////\n1//2//3//4", 10)]
        public void TestAdderForCustomDelimiters(string input, int expectedOutput)
        {
            Assert.Equal(expectedOutput, Adder.Program.Add(input));
        }
        
//        [Theory]
//        [InlineData("-1,2,-3", "Negatives not allowed: -1, -3")]
//        public void TestAdderForNegativeInputsWhichWeDontProcess(string input, string expectedOutput)
//        {
//            Assert.Equal(expectedOutput, Adder.Program.Add(input));
//        }

    }
}