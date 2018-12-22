using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BugTracker.Data_Layer
{
    public class DBConnection
    {
		public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public DBConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-KAP2J5M;Initial Catalog=BugTracker;Integrated Security=True");
            con.Open();
        }
        public void SqlQuery(string query)
        {
            cmd = new SqlCommand(query, con);
        }
        public DataTable ExQuery()
        {
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ExNonQuery()
        {
            int value = cmd.ExecuteNonQuery(); // only operation (effect state)
            return value;
        }
    }
}
