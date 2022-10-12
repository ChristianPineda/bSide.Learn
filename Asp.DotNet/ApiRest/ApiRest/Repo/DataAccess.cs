namespace ApiRest.Repo
{
    public class DataAccess
    {
        public string ConnectionStringSql { get; }

        public DataAccess(string connectionString) // public DataAccess(string connectionString,another connnectionString)
        {
            ConnectionStringSql = connectionString;
        }
    }
}
