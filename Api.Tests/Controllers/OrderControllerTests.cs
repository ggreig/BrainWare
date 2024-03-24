namespace Api.Tests.Controllers
{
    using Api.Controllers;
    using FluentAssertions;
    using Infrastructure;
    using Microsoft.Extensions.Configuration;
    using Models;
    using NSubstitute;

    [TestFixture]
    [TestOf(typeof(OrderController))]
    public class OrderControllerTests
    {
        [Test]
        public void GetOrders_ShouldContainExpectedNumber()
        {
            // Arrange
            var mockConfiguration = Substitute.For<IConfiguration>();
            mockConfiguration.GetSection("ConnectionStrings")["DefaultConnection"] = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=BrainWare;Integrated Security=SSPI;";
            
            var database = new Database(mockConfiguration);
            var orderService = new OrderService(database);
            var orderController = new OrderController(orderService);

            // Act
            IEnumerable<Order> result = orderController.GetOrders();

            // Assert
            result.Should().HaveCount(3, "because 3 orders have been placed");
        }
    }
}