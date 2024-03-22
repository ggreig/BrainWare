using FluentAssertions;

namespace Api.Tests
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            true.Should().BeTrue();
        }
    }
}