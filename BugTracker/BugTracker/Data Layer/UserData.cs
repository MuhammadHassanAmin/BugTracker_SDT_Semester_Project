using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using BugTracker.Business_Layer;
using BugTracker.Common;

namespace BugTracker.Data_Layer
{
    public class UserData
    {
        DBConnection dbCon;
        public UserData()
        {
            dbCon = new DBConnection();
        }

        public User registerUser(User u)
        {
            dbCon.SqlQuery("register");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;
            dbCon.cmd.Parameters.AddWithValue("@Name", u.name);
            dbCon.cmd.Parameters.AddWithValue("@Email", u.email);
            dbCon.cmd.Parameters.AddWithValue("@Password", u.password);

            dbCon.cmd.ExecuteNonQuery();

            return u;
        }

        public User userLogin(User u)
        {
            dbCon.SqlQuery("userLogin");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;

            dbCon.cmd.Parameters.AddWithValue("@Email", u.email);
            dbCon.cmd.Parameters.AddWithValue("@Password", u.password);

            if (dbCon.cmd.ExecuteScalar() == null)
            {
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbCon.ExQuery();
                DataRow dr = dbCon.dt.Rows[0];
                User temp = new User();
                temp.id = (int)dr["id"];
                temp.email = dr["Email"].ToString();
                temp.password = dr["Password"].ToString();
                temp.role = dr["role"].ToString();
                return temp;
            }
        }

        public User changePassword(User u)
        {
            dbCon.SqlQuery("changePassword");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;
            dbCon.cmd.Parameters.AddWithValue("@Email", u.email);
            dbCon.cmd.Parameters.AddWithValue("@Password", u.password);

            dbCon.cmd.ExecuteNonQuery();

            return u;
        }

        public User getUserDetails(string email, string pass)
        {
            dbCon.SqlQuery("userLogin");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;
            dbCon.cmd.Parameters.AddWithValue("@Email", email);
            dbCon.cmd.Parameters.AddWithValue("@Password", pass);

            if (dbCon.cmd.ExecuteScalar() == null)
            {
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbCon.ExQuery();
                DataRow dr = dbCon.dt.Rows[0];
                User temp = new User();
                temp.id = (int)dr["id"];
                temp.name = dr["Name"].ToString();
                temp.email = dr["Email"].ToString();
                temp.password = dr["Password"].ToString();
                temp.name = dr["role"].ToString();

                return temp;
            }
        }

        public int CheckExistingEmail(string email)
        {
            dbCon.SqlQuery("checkExistingEmail");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;
            dbCon.cmd.Parameters.AddWithValue("@Email", email);

            if (dbCon.cmd.ExecuteScalar() == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public User getUsers(int count)
        {
            dbCon.SqlQuery("getUsers");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;
            dbCon.cmd.Parameters.AddWithValue("@id", count);

            if (dbCon.cmd.ExecuteScalar() == null)
            {
                User temp = new User();
                temp.id = 999;

                return temp;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbCon.ExQuery();
                DataRow dr = dbCon.dt.Rows[0];
                User temp = new User();
                temp.id = (int)dr["id"];
                temp.name = dr["name"].ToString();
                return temp;
            }
        }
        public DataTable getUsers()
        {
            dbCon.SqlQuery("select * from users");
            DataTable dt = new DataTable();
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(dbCon.cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dt);
            return dt;
       
        }

        public int getUsersCount()
        {
            dbCon.SqlQuery("getUsersCount");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;

            int count = (int)dbCon.cmd.ExecuteScalar();

            return count;
        }

        public void assignRole(int uID, string role)
        {
            dbCon.SqlQuery("assignUserRole");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;
            dbCon.cmd.Parameters.AddWithValue("@uID", uID);
            dbCon.cmd.Parameters.AddWithValue("@role", role);

            dbCon.cmd.ExecuteNonQuery();
        }
    }
}
