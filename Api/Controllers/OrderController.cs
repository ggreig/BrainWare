namespace Api.Controllers
{
    using Infrastructure;
    using Microsoft.AspNetCore.Mvc;
    using Models;

    [ApiController]
    [Route("api")]
    public class OrderController(IOrderService inOrderService) : ControllerBase
    {
        [HttpGet]
        [Route("order/{id}")]
        public IEnumerable<Order> GetOrders(int id = 1)
        {
            return inOrderService.GetOrdersForCompany(id);
        }
    }
}