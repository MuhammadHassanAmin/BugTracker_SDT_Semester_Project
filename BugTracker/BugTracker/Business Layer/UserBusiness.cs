using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Common;
using BugTracker.Data_Layer;
using System.Data;

namespace BugTracker.Business_Layer
{
    public class UserBusiness
    {
		public UserData userData;
        public UserBusiness()
        {
            userData = new UserData();
        }

        public User registerUser(User u)
        {
            bool checkEmail = IsValidEmail(u.email);

            if (checkEmail == true)
            {
                User temp = userData.registerUser(u);

                return temp;
            }
            else
            {
                u.id = 0;
                return u;
            }
        }

        public User userLogin(User u)
        {
            User temp = userData.userLogin(u);
            return temp;
        }
        public User changePassword(User u)
        {
            User temp = userData.changePassword(u);
            return temp;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public User getUserDetails(string email, string pass)
        {
            User temp = userData.getUserDetails(email, pass);
            return temp;
        }

        public int CheckExistingEmail(string email)
        {
            int temp = userData.CheckExistingEmail(email);

            return temp;
        }

        public int getUsersCount()
        {
            int count = userData.getUsersCount();

            return count;
        }
        public User getUsers(int count)
        {
            User temp = userData.getUsers(count);
            return temp;
        }
        public DataTable getUsers()
        {

            return userData.getUsers();
        }

        public void assignRole(int uID, string role)
        {
            userData.assignRole(uID, role);
        }
    }
}
