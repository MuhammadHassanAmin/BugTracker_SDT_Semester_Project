using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Common;
using BugTracker.Business_Layer;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace BugTracker.Data_Layer
{
    public class TeamData
    {
        DBConnection dbCon;
        public TeamData()
        {
            dbCon = new DBConnection();
        }

        public int createTeam(Team t)
        {
            try
            {
                DataTable dt = new DataTable();
                dbCon.SqlQuery("insert into teams (name,category) OUTPUT INSERTED.ID values (@title,@category)");
                dbCon.cmd.Parameters.AddWithValue("@title", t.name);
                dbCon.cmd.Parameters.AddWithValue("@category", t.category);
                Int32 newId = (Int32)dbCon.cmd.ExecuteScalar();
                //SqlDataAdapter da = new SqlDataAdapter(dbCon.cmd);
                // da.Fill(dt);
                //DataRow dr = dt.Rows[0];
                return newId;
            }

            catch (Exception)
            {
                return 0;

                throw;
            }

        }
        public void addMemberToTeam(int team_id, int user_id)
        {
            try
            {
                dbCon.SqlQuery("insert into user_team_junc (userID_FK,teamID_FK)  values (@userID_FK,@teamID_FK)");
                dbCon.cmd.Parameters.AddWithValue("@teamID_FK", team_id);
                dbCon.cmd.Parameters.AddWithValue("@userID_FK", user_id);
                dbCon.ExQuery();
            }

            catch (Exception)
            {
             

                throw;
            }
        }


        public DataTable getTeamMembers(int tID)
        {
            dbCon.SqlQuery("select * from users where id = (select userID_FK from user_team_junc where teamID_FK = tID)");
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(dbCon.cmd);
            da.Fill(dt);
            return dt;

        }
    }
}
