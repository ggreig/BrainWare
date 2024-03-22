namespace Api.Tests.Controllers
{
    using Api.Controllers;
    using FluentAssertions;
    using Models;

    [TestFixture]
    [TestOf(typeof(OrderController))]
    public class OrderControllerTests
    {
        [Test]
        public void GetOrders_ShouldSucceed()
        {
            // Arrange
            var orderController = new OrderController();

            // Act
            IEnumerable<Order> result = orderController.GetOrders();

            // Assert
            result.Should().HaveCount(3, "because 3 orders have been placed");
        }
    }
}