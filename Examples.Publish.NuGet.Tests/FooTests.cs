using Xunit;

namespace Examples.Publish.NuGet.Tests
{
    public sealed class FooTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(5, 5, 10)]
        public void AdditionTest(int argument1, int argument2, int result)
        {
            var res = Foo.Addition(argument1, argument2);
            Assert.Equal(res, result);
        }
    }
}
