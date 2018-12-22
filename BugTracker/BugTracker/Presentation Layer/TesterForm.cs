using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracker.Business_Layer;
using BugTracker.Common;

namespace BugTracker.Presentation_Layer
{
    public partial class TesterForm : Form
    {
        User currentUser = new User();
        public TesterForm()
        {
            InitializeComponent();
        }
        public TesterForm(User temp)
        {
            InitializeComponent();
            currentUser.id = temp.id;

        }
        private void btnCreateBug_Click(object sender, EventArgs e)
        {
            panelCreateBug.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCreateBug.BringToFront();

            DateTime assignTime = DateTime.Now;
            Bug bug = new Bug();
            BugBusiness bBug = new BugBusiness();
            bug.userID_FK = currentUser.id;
            MessageBox.Show(currentUser.id.ToString());
            bug.title = txtBugTitle.Text;
            bug.deadline = txtDescription.Text;
            bug.description = txtBugTitle.Text;
            bug.assignTime = assignTime.ToString();
            bug.priority = cmbPriority.Text.ToString();


            if (bBug.createBug(bug))
            {
                MessageBox.Show("New Bug Added");
            }
            else
            {
                MessageBox.Show("Some error occur while adding bug");

            }
        }
    }
}
