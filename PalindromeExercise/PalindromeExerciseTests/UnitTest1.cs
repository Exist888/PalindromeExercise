using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("hello", false)]
        [InlineData("1483", false)]
        [InlineData("yay", true)]
        [InlineData("Yay", true)]
        [InlineData("12321", true)]
        [InlineData(null, false)]
        
        public void PalindromeTest(string input, bool expected)
        {
            //Arrange:
            var tryWord = new WordSmith();

            //Act:
            var actual = tryWord.IsAPalindrome(input);

            //Assert:
            Assert.Equal(expected, actual);
        }
    }
}
