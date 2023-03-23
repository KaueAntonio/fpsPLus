using System.Data;

namespace fpsPlus.fpsPlus.Database
{
    public interface IDatabase
    {
        IDbConnection connection();
    }
}
