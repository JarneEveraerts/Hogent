using System;
using Xunit;

namespace Palindroom.XTests
{
    public class PalindroomTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("a")]
        public void IsPalindroomTest_LegeString_ArgumentException(string s)
        {
            Assert.Throws<ArgumentException>(() => Palindroom.Domain.Palindroom.IsPalindroom(s));
        }
    }
}