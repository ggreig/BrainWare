namespace Api.Infrastructure
{
    using System.Data.Common;

    public interface IDatabase
    {
        DbDataReader ExecuteReader(string query);
        int ExecuteNonQuery(string query);
    }
}