using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Common;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace BugTracker.Data_Layer
{
    public class BugData
    {
        DBConnection dbCon = new DBConnection();
        public BugData() { }
        public bool createBug(Bug bBug) {
            try
            {
                dbCon.SqlQuery("insert into bugs (title,description,deadline,status,assignTime,priority,userID_FK) values (@title,@description,@deadline,@status,@assignTime,@priority,@userID_FK)");
                dbCon.cmd.Parameters.AddWithValue("@title", bBug.title);
                dbCon.cmd.Parameters.AddWithValue("@deadline", bBug.deadline);
                dbCon.cmd.Parameters.AddWithValue("@description", bBug.description);
                dbCon.cmd.Parameters.AddWithValue("@status", "Open");
                dbCon.cmd.Parameters.AddWithValue("@assignTime", bBug.assignTime);
                dbCon.cmd.Parameters.AddWithValue("@priority", bBug.priority);
                dbCon.cmd.Parameters.AddWithValue("@userID_FK", bBug.userID_FK);

                dbCon.ExQuery();
                return true;
            }

            catch (Exception)
            {
                return false;

                throw;
            }
        }

        public int getCurrentBugsCount()
        {
            dbCon.SqlQuery("getBugsCount");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;

            int count = (int)dbCon.cmd.ExecuteScalar();

            return count;
        }

        public Bug getBugs(int count)
        {
            dbCon.SqlQuery("getBugs");
            dbCon.cmd.CommandType = CommandType.StoredProcedure;
            dbCon.cmd.Parameters.AddWithValue("@id", count);

            if (dbCon.cmd.ExecuteScalar() == null)
            {
                Bug temp = new Bug();
                temp.id = 999;

                return temp;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dbCon.ExQuery();
                DataRow dr = dbCon.dt.Rows[0];
                Bug temp = new Bug();
                temp.id = (int)dr["id"];
                temp.title = dr["title"].ToString();
                temp.priority = dr["priority"].ToString();
                temp.status = dr["status"].ToString();
                return temp;
            }
        }
    }
}