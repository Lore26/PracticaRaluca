using Microsoft.Data.SqlClient;
using System.Data;

namespace BookStore.Data
{
    public class BookStoreContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? connectionstring;
        public BookStoreContext(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionstring = _configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(connectionstring);
    }
}