using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Common
{
    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }

        public Team()
        {
            id = 0;
            name = "";
            category = "";
        }

        public Team(int i, string n, string c)
        {
            id = i;
            name = n;
            category = c;
        }
    }
}
