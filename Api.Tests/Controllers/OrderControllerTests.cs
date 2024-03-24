namespace Api.Tests.Controllers
{
    using Api.Controllers;
    using FluentAssertions;
    using FluentAssertions.Execution;
    using Infrastructure;
    using Models;
    using NSubstitute;
                   
    [TestFixture]
    [TestOf(typeof(OrderController))]
    public class OrderControllerTests
    {
        [Test]
        public void GetOrders_WithSingleItem_ShouldContainExpectedItemOnly()
        {
            // Arrange
            var database = Substitute.For<IDatabase>();
            database.GetOrders(1).Returns(TestDataForOrder.Single);
            database.GetOrderDetails(1).Returns(TestDataForOrderItem.Single);
            
            var orderService = new OrderService(database);
            var orderController = new OrderController(orderService);

            // Act
            List<Order> result = orderController.GetOrders(1).ToList();

            // Assert
            using (new AssertionScope())
            {
                result.Should().ContainSingle("because 1 order has been placed");
                result.First().OrderProducts.Should().ContainSingle("because 1 item was included")
                    .Which.Product.Name.Should().Be("Test Product 1");
            }
        }
    }
}