using System.Data.SqlClient;

namespace PhanMemTraCuu.src.DAO
{
    public class ConnectDatabase
    {
        public SqlConnection Connect()
        {
            return new SqlConnection(
                @"Data Source=TOPXOAN\SQLEXPRESS;Initial Catalog=PhanMemTraCuuMonCTDL_GT1;User ID=sa;Password=0384974745"
            );
        }
    }
}
