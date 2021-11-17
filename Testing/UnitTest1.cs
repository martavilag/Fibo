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
            int expected = 3;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NegativeNumber()
        {
            void TestCode()
            {
                Sequence(-2);
            }

            Exception ex = Record.Exception((Action) TestCode);

            Assert.NotNull(ex);
            Assert.IsType<ArgumentException>(ex);
        }

    }
}
