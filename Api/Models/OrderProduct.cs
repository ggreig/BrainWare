namespace Api.Models
{
    /// <summary>
    /// A class representing an iterm line in an <see cref="Order"/>.
    /// </summary>
    public class OrderProduct
    {
        /// <summary>
        /// The numerical ID of the <see cref="Order"/>.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// The numerical ID of the <see cref="Product"/> included in the line.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// An object representing the details of the <see cref="Product"/>.
        /// </summary>
        public Product Product { get; set; } = new();

        /// <summary>
        /// The quantity of the <see cref="Product"/> ordered.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The unit price of the <see cref="Product"/>.
        /// </summary>
        public decimal Price { get; set; }
    }
}