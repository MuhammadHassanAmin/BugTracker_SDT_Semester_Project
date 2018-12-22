﻿using System;
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

        public bool createTeam(Team t)
        {
            try
            {
                dbCon.SqlQuery("insert into teams (name,category) values (@title,@category)");
                dbCon.cmd.Parameters.AddWithValue("@title", t.name);
                dbCon.cmd.Parameters.AddWithValue("@category", t.category);
                dbCon.ExQuery();
                return true;
            }

            catch (Exception)
            {
                return false;

                throw;
            }

        }
    }
}