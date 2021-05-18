using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QLKhachSan.DAO
{
    public class DataProvider
    {
        private static DataProvider Instance;

        public static DataProvider Instance1 { get => Instance; set => Instance = value; }

        public DataTable ExecuteQuery(string query)
        {
            DataTable datatb = new DataTable();
            using (SqlConnection con = new SqlConnection(@"Data Source=RISU\SQLEXPRESS;Initial Catalog=QuanLiKhachSan;Integrated Security=True"))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(command);               
                da.Fill(datatb); 
                con.Close();
            }     
            return datatb;
        }
    }
}
