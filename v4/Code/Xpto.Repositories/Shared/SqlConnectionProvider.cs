namespace Xpto.Repositories.Shared
{
    public class SqlConnectionProvider
    {
        public string connectionString { get; }
        public SqlConnectionProvider(string connectionString)
        {
            connectionString = connectionString;
        }
    }
}

//private readonly string connectionString = "server=.;database=db_xpto;user=xpto;password=123456";