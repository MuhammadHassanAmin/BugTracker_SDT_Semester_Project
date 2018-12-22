using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Common
{
    public class Bug
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string assignTime { get; set; }
        public string deadline { get; set; }
        public string category { get; set; }
        public string status { get; set; }
        public int temp { get; set; }
        public string priority { get; set; }
        public int userID_FK { get; set; }

        public Bug()
        {
            id = 0;
            title = "";
            description = "";
            assignTime = "";
            deadline = "";
            category = "";
            status = "";
        }

        public Bug(int i, string t, string d, string at, string dl, string c, string s)
        {
            id = 0;
            title = t;
            description = d;
            assignTime = at;
            deadline = dl;
            category = c;
            status = s;
        }
    }
}
