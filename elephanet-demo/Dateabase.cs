namespace elephanet_demo
{
    public class Database
    {
        public static string ConnectionString()
        {
            return "Server=127.0.0.1;Port=5432;Database=store;User Id=store_user;Password='my super secret password'";
        }
    }
}
