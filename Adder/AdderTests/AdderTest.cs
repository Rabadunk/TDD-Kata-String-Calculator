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
        
        
    }
}