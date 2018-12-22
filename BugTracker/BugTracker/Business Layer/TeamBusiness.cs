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

        public int createTeam(Team t)
        {
            return tD.createTeam(t);
        }

        
            public DataTable getTeamMembers(int tID, int count)
        {
            return tD.getTeamMembers(tID, count);
        }

        public void addMemberToTeam(int team_id, int user_id)
        {
            tD.addMemberToTeam(team_id, user_id);
        }
    }
}