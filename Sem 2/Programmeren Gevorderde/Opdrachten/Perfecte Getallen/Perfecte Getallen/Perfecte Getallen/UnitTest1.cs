using System;
using Xunit;

namespace Perfecte_Getallen
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void Test_FouteInput(int s)
        {
            Assert.Throws<ArgumentException>(() => PerfectGetal.IsPerfectGetal(s));
        }

        [Fact]
        public void Test_PerfectGetal()
        {
            Assert.Equal(true, PerfectGetal.IsPerfectGetal(6));
        }

        [Fact]
        public void Test_inPerfectGetal()
        {
            Assert.Equal(false, PerfectGetal.IsPerfectGetal(198));
        }
    }
}