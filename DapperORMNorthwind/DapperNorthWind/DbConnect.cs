
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DapperNorthWind
{
    public class DbConnect
    {
        private DbConnect()
        {

        }

        private static SqlConnection _connection;

        public static SqlConnection Connection
        {
            get
            {
                if (_connection==null)
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["northWind"].ConnectionString;
                    _connection = new SqlConnection(connectionString);
                }

                if (_connection.State!=ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }

        }

    }
}
