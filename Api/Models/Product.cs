namespace Api.Models
{
    /// <summary>
    /// A class representing a product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The name of the product.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The unit price of the product.
        /// </summary>
        public decimal Price { get; set; }
    }
}