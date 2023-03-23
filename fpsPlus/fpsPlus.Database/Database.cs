using fpsPlus.fpsPlus.Database;
using System.Data;
using System.Data.SqlClient;

namespace fpsPlus.Database;
public class Database : IDatabase
{
    public IDbConnection Connection()
    {
        return new SqlConnection("");
    }
}
