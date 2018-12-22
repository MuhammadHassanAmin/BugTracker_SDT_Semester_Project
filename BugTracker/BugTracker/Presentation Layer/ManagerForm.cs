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
using BugTracker.Data_Layer;
using System.Data.SqlClient;

namespace BugTracker.Presentation_Layer
{
    public partial class ManagerForm : Form
    {
        User currentUser = new User();
        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(User temp)
        {
            InitializeComponent();
            currentUser.id = temp.id;

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            BugBusiness bugB = new BugBusiness();
            Bug b = new Bug();

            int count = bugB.getCurrentBugsCount();
            int i = 1;

            b = bugB.getBug(count);

            StringBuilder sb1 = new StringBuilder();
            while (i <= count)
            {
                if (b.id != 999)
                {
                    sb1.AppendLine(b.title.Trim() + " marked as " + b.priority.Trim());
                    sb1.AppendLine(b.title.Trim() + " status changed to " + b.status.Trim());
                }
                i++;
                b = bugB.getBug(count);
            }
            bugsFeed.Text = sb1.ToString();


            //UserBusiness uB = new UserBusiness();
            //User u = new User();

            //count = uB.getUsersCount();
            //i = 1;

            //u = uB.getUsers(count);

            //StringBuilder sb2 = new StringBuilder();
            //while (i <= count)
            //{
            //    if (b.id != 999)
            //    {

            //        sb1.AppendLine(b.title + " added by " + u.name);
            //        sb1.AppendLine(b.title + " marked as "+ b.priority + " by " + u.name);
            //    }
            //    i++;
            //    u = uB.getUsers(count);
            //}
            //developersFeed.Text = sb2.ToString();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            activePanel.Height = btnDashboard.Height;
            activePanel.Top = btnDashboard.Top;
        }

        private void managerDashboardUC2_Load(object sender, EventArgs e)
        {

        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            panelDashboardFeed.BringToFront();
        }

        private void btnCreateProjectAction_Click(object sender, EventArgs e)
        {
            Project pProject = new Project();
            pProject.title = txtProjTitle.Text;
            pProject.category = cmbCategory.Text;
            pProject.description = txtDescription.Text;
            pProject.postDate = "22/05/2020";

            ProjectBusiness bProject = new ProjectBusiness(pProject);
            if (bProject.createProject(pProject))
            {
                MessageBox.Show("Project added");
            }
            else
            {
                MessageBox.Show("Project could not be added");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnAssignRole2_Click(object sender, EventArgs e)
        {
            string newRole = selectRoleCB.Text;
            int userID = selectUserCB.SelectedIndex;
            userID = userID + 1;

            UserBusiness uB = new UserBusiness();

            uB.assignRole(userID, newRole);
        }

        private void createProjectbtn_Click(object sender, EventArgs e)
        {
            if (DGVSelectedMemebers.Rows.Count > 0)
            {
                TeamBusiness bTeam = new TeamBusiness();
                Team pTeam = new Team();
                pTeam.name = txtTeamName.Text;
                pTeam.category = cmbTeamType.Text;
                pTeam.id =   bTeam.createTeam(pTeam);
                foreach (DataGridViewRow member in DGVSelectedMemebers.Rows)
                {
                    int uid = Convert.ToInt32(member.Cells[1].Value.ToString());
                    bTeam.addMemberToTeam(pTeam.id, uid);
                }
                MessageBox.Show("Team Created");
            }
            else
            {
                MessageBox.Show("No Member Selected");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelEditTeam.BringToFront();

            
        }

        private void btnCreateTeams_Click(object sender, EventArgs e)
        {
            panelCreateTeam.BringToFront();
            DataTable dt = new DataTable();
            dt = currentUser.getUsers();
            foreach (DataRow item in dt.Rows)
            {
               int n =  DGVselectmembers.Rows.Add();
                DGVselectmembers.Rows[n].Cells["Column1"].Value = item["name"].ToString();
                DGVselectmembers.Rows[n].Cells["Column2"].Value = item["id"].ToString();
            }
            DGVselectmembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //DGVselectmembers.DataSource = currentUser.getUsers();
            //DGVselectmembers
        }

        private void btnCreateProjectOnManagerPanel_Click(object sender, EventArgs e)
        {
            panelCreateProject.BringToFront();
        }

        private void btnAssignRole_Click(object sender, EventArgs e)
        {
            panelAssignRoles.BringToFront();

            this.selectRoleCB.Items.Clear();
            this.selectUserCB.Items.Clear();
            selectRoleCB.Text = "";
            selectUserCB.Text = "";

            selectRoleCB.Items.Add("manager");
            selectRoleCB.DisplayMember = "manager";

            selectRoleCB.Items.Add("developer");
            selectRoleCB.DisplayMember = "developer";

            selectRoleCB.Items.Add("tester");
            selectRoleCB.DisplayMember = "tester";

            User p = new User();
            UserBusiness pB = new UserBusiness();
            p.id = 0;
            int count = 1;

            p = pB.getUsers(count);

            int maxUsers = pB.getUsersCount();

            while (count <= maxUsers)
            {
                if (p.id != 999)
                {
                    p.name = p.name.Trim();

                    selectUserCB.Items.Add(p.name);
                    selectUserCB.ValueMember = p.id.ToString();
                    selectUserCB.DisplayMember = p.name;
                }
                count++;
                p = pB.getUsers(count);
            }
        }

        private void panelCreateTeam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGVselectmembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DGVselectmembers.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string name = DGVselectmembers.SelectedRows[0].Cells[0].Value + string.Empty;
                string userId = DGVselectmembers.SelectedRows[0].Cells[1].Value + string.Empty;

              int n=   DGVSelectedMemebers.Rows.Add();
                DGVSelectedMemebers.Rows[n].Cells[0].Value = name;
                DGVSelectedMemebers.Rows[n].Cells[1].Value = userId;
            }
        }
    }
}
