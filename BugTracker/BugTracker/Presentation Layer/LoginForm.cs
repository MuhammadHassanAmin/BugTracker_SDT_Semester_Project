using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.Common;
using BugTracker.Business_Layer;

namespace BugTracker.Presentation_Layer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void boxRSignup_Click(object sender, EventArgs e)
        {
            if ((boxName.Text.Length != 0) && (boxREmail.Text.Length != 0) && (boxRPassword.Text.Length != 0))
            {
                User u = new User();
                UserBusiness uB = new UserBusiness();

                u.email = boxREmail.Text;

                int check = uB.CheckExistingEmail(u.email);
                if (check != 0)
                {
                    u.name = boxName.Text;
                    u.email = boxREmail.Text;
                    u.password = boxRPassword.Text;

                    u = uB.registerUser(u);

                    if (u.id == 0)
                    {
                        MessageBox.Show("Invalid Email");
                    }
                    else
                    {
                        panelLogin.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("Email Already Exists!");
                }
            }
            else if (boxREmail.Text.Length != 0)
            {
                MessageBox.Show("Enter Valid Password");
            }
            else if (boxRPassword.Text.Length != 0)
            {
                MessageBox.Show("Enter Valid Email");
            }
            else
            {
                MessageBox.Show("Both Fields Empty!");
            }
        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            panelSignup.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = new User();
            UserBusiness uB = new UserBusiness();

            u.email = boxEmail.Text;
            u.password = boxPassword.Text;

            u = uB.userLogin(u);
            if (u == null)
            {
                MessageBox.Show("Wrong Email or Password");
            }
            else
            {
                u.role = u.role.Trim();
                if (u.role.Equals("manager"))
                {
                    this.Hide();
                    ManagerForm load = new ManagerForm(u);
                    
                    load.Show();
                }
                else if (u.role.Equals("developer"))
                {
                    

                }
                else if (u.role.Equals("tester"))
                {
                    this.Hide();
                    TesterForm load = new TesterForm(u);

                    load.Show();
                }
                else
                {
                    MessageBox.Show("Ask your manager to assign a role");
                }
            }
        }
    }
}
