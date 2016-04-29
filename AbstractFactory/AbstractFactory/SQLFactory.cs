namespace AbstractFactory
{
    /* Concret Factory */
    public class SqlFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            /* A classe aqui ficou encapsulada */
            return new SqlConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }
}