using Microsoft.Data.SqlClient;

namespace UseDapper.DAL.Implemen
{
    public class DBcon
    {
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection("Data Source =.; Initial Catalog = DapperTest; Integrated Security = true; Trust Server Certificate= true ");
        }
    }
}
