using System;
using Xunit;
using static Fibo.Program;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void PositiveNumber()
        {
            int actual = Sequence(5);
            int expected = 5; // adjust 1 number ahead

            Assert.Equal(expected, actual);
        }
    }
}
