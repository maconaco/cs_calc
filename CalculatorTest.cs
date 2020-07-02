using Xunit;
using Calculator;

namespace Test
{
    public class CalcTest
    {
        [Fact]
        public void 足し算の結果が正しく出てくること()
        {
            int result = Calc("1 - 2 * 3 + 4 + 5");
            Console.Write(result);
            Assert.Equal(6, result);
        }
    }
}

