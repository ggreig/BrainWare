namespace Api.Tests
{
    using FluentAssertions;

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