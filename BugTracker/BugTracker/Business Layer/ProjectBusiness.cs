using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Common;
using BugTracker.Data_Layer;
namespace BugTracker.Business_Layer
{
    public class ProjectBusiness
    {
        ProjectData dProject = new ProjectData();
        Project bProject;
        public ProjectBusiness() { }
        public ProjectBusiness(Project bProject) {
            bProject = new Project(bProject);
        }

        public bool createProject(Project bProject){
            return dProject.createProject(bProject);
        }

    }
}
