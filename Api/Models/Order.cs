namespace Api.Models
{
    /// <summary>
    /// A class representing an Order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The numerical ID of the order.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// The name of the company that placed the order.
        /// </summary>
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// A description of the order.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The total price of the order.
        /// </summary>
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// A collection of the items included in the order.
        /// </summary>
        public List<OrderProduct> OrderProducts { get; set; } = [];
    }
}