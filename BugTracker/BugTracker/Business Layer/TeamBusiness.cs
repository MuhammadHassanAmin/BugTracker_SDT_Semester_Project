using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Common;
using BugTracker.Business_Layer;
using BugTracker.Data_Layer;
using System.Data;

namespace BugTracker.Business_Layer
{
    public class TeamBusiness
    {
        TeamData tD = new TeamData();
        Team t;
        public TeamBusiness() 
        {

        }

        public bool createTeam(Team t)
        {
            return tD.createTeam(t);
        }

        public DataTable getTeamMembers(int teamID)
        {
            return tD.getTeamMembers(teamID);
        }
    }
}