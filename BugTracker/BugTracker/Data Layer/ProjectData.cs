using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Common;
using BugTracker.Data_Layer;

namespace BugTracker.Data_Layer
{
    public class ProjectData
    {
        DBConnection dbCon = new DBConnection();
        public ProjectData() { }

        public bool createProject(Project dProject)
        {
            try
            {
                dbCon.SqlQuery("insert into projects (title,category,description,postDate) values (@title,@category,@description,@postDate)");
                dbCon.cmd.Parameters.AddWithValue("@title", dProject.title);
                dbCon.cmd.Parameters.AddWithValue("@category", dProject.category);
                dbCon.cmd.Parameters.AddWithValue("@description", dProject.description);
                dbCon.cmd.Parameters.AddWithValue("@postDate", dProject.postDate);
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
