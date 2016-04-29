namespace AbstractFactory
{
    public class MongoFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }
}