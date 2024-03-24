namespace Api.Infrastructure
{
    using Models;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;

    internal class Database : IDatabase
    {
        private readonly SqlConnection _connection;

        public Database(IConfiguration configuration)
        {
            // Get the connection string from appsettings.
            var connectionString = configuration?.GetSection("ConnectionStrings")["DefaultConnection"];

#pragma warning disable S125 // Sections of code should not be commented out
            //
            // Usually commented-out code should be removed, but we've left these lines because they
            // contain previously hard-coded connection strings in case they need to be restored.
            //
            //var connectionString = "Data Source=LOCALHOST;Initial Catalog=BrainWare;Integrated Security=SSPI";
            //string mdf = @"C:\repos\BrainWare\Api\data\BrainWare.mdf";
            //string connectionString =
            //    $"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=BrainWAre;Integrated Security=SSPI;AttachDBFilename={mdf}";
#pragma warning restore S125 // Sections of code should not be commented out

            _connection = new SqlConnection(connectionString);

            _connection.Open();
        }

        public List<Order> GetOrders(int companyId)
        {
            var orders = new List<Order>();

            DbDataReader dataReader = ExecuteStoredProcedure("getcompanyorders", companyId);
            while (dataReader.Read())
            {
                IDataRecord record1 = dataReader;

                orders.Add(new Order
                {
                    CompanyName = record1.GetString(0),
                    Description = record1.GetString(1),
                    OrderId = record1.GetInt32(2),
                    OrderProducts = new List<OrderProduct>()
                });
            }
            dataReader.Close();

            return orders;
        }

        public List<OrderProduct> GetOrderDetails(int companyId)
        {
            var orderProducts = new List<OrderProduct>();

            DbDataReader dataReader = ExecuteStoredProcedure("getorderdetails", companyId);
            while (dataReader.Read())
            {
                IDataRecord record2 = dataReader;

                orderProducts.Add(new OrderProduct
                {
                    OrderId = record2.GetInt32(1),
                    ProductId = record2.GetInt32(2),
                    Price = record2.GetDecimal(0),
                    Quantity = record2.GetInt32(3),
                    Product = new Product { Name = record2.GetString(4), Price = record2.GetDecimal(5) }
                });
            }
            dataReader.Close();

            return orderProducts;
        }

        private DbDataReader ExecuteStoredProcedure(string name, int companyId)
        {
            var sqlQuery = new SqlCommand(name, _connection);
            sqlQuery.CommandType = CommandType.StoredProcedure;
            sqlQuery.Parameters.Add("@companyId", SqlDbType.Int).Value = companyId;
            return sqlQuery.ExecuteReader();
        }
    }
}