using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Common;
using BugTracker.Data_Layer;

namespace BugTracker.Business_Layer
{
    public class BugBusiness
    {
        BugData dBug = new BugData();
       public BugBusiness() { }
        public bool createBug(Bug bBug)
        {
            return dBug.createBug(bBug);
        }

        public int getCurrentBugsCount()
        {
            int count = dBug.getCurrentBugsCount();

            return count;
        }
        public Bug getBug(int count)
        {
            Bug temp = dBug.getBugs(count);
            return temp;
        }
    }
}