using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Business_Layer;
namespace BugTracker.Common
{
    public class User
    {
        UserBusiness bUser = new UserBusiness();
		public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string role { get; set; }

        public User()
        {
            id = 1;
            email = "";
            password = "";
            name = "";
            type = "";
            role = "";
        }

        public User(int i, string e, string p, string n , string t , string r)
        {
            id = 0;
            email = e;
            password = p;
            name = n;
            type = t;
            role = r;
        }
        public DataTable getUsers() {
            return bUser.getUsers();
        }
    }
}
