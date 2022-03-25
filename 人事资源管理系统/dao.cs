using System.Data.SqlClient;
namespace 人事资源管理系统
{
    class dao
    {
            public SqlConnection connect()
            {
                string str = "Data Source=xxx;Initial Catalog=xxx;User ID=xxx;Pwd=xxx";
                SqlConnection sc = new SqlConnection(str);
                sc.Open();//打开数据库链接
                return sc;
            }
            public SqlCommand command(string sql)
            {
                SqlCommand cmd = new SqlCommand(sql, connect());
                return cmd;
            }
            //用于delete update insert
            public int Execute(string sql)
            {
                return command(sql).ExecuteNonQuery();
            }
            //用于select
            public SqlDataReader read(string sql)
            {
                return command(sql).ExecuteReader();
            }
    }
}
