using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PermissionSystem.Core
{
    public class DapperManager
    {
        public static IDbConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }
    }
}
