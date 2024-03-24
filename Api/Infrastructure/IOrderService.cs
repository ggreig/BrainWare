namespace Api.Infrastructure
{
    using Models;

    /// <summary>
    /// An interface for a service that retrieves details of a company's orders.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Gets a collection of the orders associated with the company identified by the provided <paramref name="companyId"/>.
        /// </summary>
        /// <param name="companyId">The numerical ID of the company for which to retrieve the orders.</param>
        /// <returns>A collection of the orders associated with the company.</returns>
        IEnumerable<Order> GetOrdersForCompany(int companyId);
    }
}