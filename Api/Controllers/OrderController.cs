namespace Api.Controllers
{
    using Infrastructure;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    /// <summary>
    /// An API responsible for managing order information.
    /// </summary>
    /// <param name="inOrderService">A service that will give access to the data.</param>
    [ApiController]
    [Route("api")]
    public class OrderController(IOrderService inOrderService) : ControllerBase
    {
        /// <summary>
        /// Returns a collection of orders associated with the company identified by the provided numerical ID.
        /// </summary>
        /// <response code="200">Returns a collection of orders associated with the company </response>
        /// <param name="id">The numerical ID of the company for which to retrieve orders.</param>
        [HttpGet]
        [Route("order/{id}")]
        public IEnumerable<Order> GetOrders(int id = 1)
        {
            return inOrderService.GetOrdersForCompany(id);
        }
    }
}