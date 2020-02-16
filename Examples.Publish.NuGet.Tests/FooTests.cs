using Xunit;

namespace Examples.Publish.NuGet.Tests
{
    public sealed class FooTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(5, 5, 10)]
        public void AdditionTest(int op1, int op2, int result)
        {
            var res = Foo.Addition(op1, op2);
            Assert.Equal(res, result);
        }
    }
}
