using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Common
{
    public class Project
    {
        public int id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string postDate { get; set; }

        public Project()
        {
            id = 0;
            title = "";
            category = "";
            description = "";
            postDate = "";
        }
        public Project( Project obj)
        {
            this.id = obj.id;
            this.title = obj.title;
            this.category = obj.category;
            this.description = obj.description;

        }

        public Project(int i, string t, string c, string d, string pD)
        {
            id = 0;
            title = t;
            category = c;
            description = d;
            postDate = pD;
        }
    }
}
