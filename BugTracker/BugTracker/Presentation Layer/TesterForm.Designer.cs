namespace BugTracker.Presentation_Layer
{
    partial class TesterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnCreateBug = new System.Windows.Forms.Button();
            this.activePanel = new System.Windows.Forms.Panel();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtBugTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.btnCreateBug1 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.panelCreateBug = new System.Windows.Forms.Panel();
            this.panel13.SuspendLayout();
            this.panelCreateBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.panel13.Controls.Add(this.btnCreateBug);
            this.panel13.Controls.Add(this.activePanel);
            this.panel13.Controls.Add(this.btnTasks);
            this.panel13.Controls.Add(this.btnDashboard);
            this.panel13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel13.ForeColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(0, 9);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(137, 529);
            this.panel13.TabIndex = 25;
            // 
            // btnCreateBug
            // 
            this.btnCreateBug.FlatAppearance.BorderSize = 0;
            this.btnCreateBug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCreateBug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCreateBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBug.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBug.Location = new System.Drawing.Point(0, 93);
            this.btnCreateBug.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateBug.Name = "btnCreateBug";
            this.btnCreateBug.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreateBug.Size = new System.Drawing.Size(137, 37);
            this.btnCreateBug.TabIndex = 5;
            this.btnCreateBug.Text = "Create Bug";
            this.btnCreateBug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateBug.UseVisualStyleBackColor = true;
            this.btnCreateBug.Click += new System.EventHandler(this.btnCreateBug_Click);
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(111)))), ((int)(((byte)(168)))));
            this.activePanel.Location = new System.Drawing.Point(0, 28);
            this.activePanel.Margin = new System.Windows.Forms.Padding(0);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(7, 37);
            this.activePanel.TabIndex = 3;
            // 
            // btnTasks
            // 
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.Location = new System.Drawing.Point(0, 65);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(0);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTasks.Size = new System.Drawing.Size(137, 37);
            this.btnTasks.TabIndex = 4;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(0, 28);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(137, 37);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(242, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Title";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label29.Location = new System.Drawing.Point(242, 176);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "Deadline";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label30.Location = new System.Drawing.Point(242, 212);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 17);
            this.label30.TabIndex = 2;
            this.label30.Text = "Description";
            // 
            // txtBugTitle
            // 
            this.txtBugTitle.Location = new System.Drawing.Point(352, 137);
            this.txtBugTitle.Name = "txtBugTitle";
            this.txtBugTitle.Size = new System.Drawing.Size(161, 20);
            this.txtBugTitle.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(352, 212);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(292, 130);
            this.txtDescription.TabIndex = 5;
            // 
            // txtDeadline
            // 
            this.txtDeadline.Location = new System.Drawing.Point(352, 170);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(161, 20);
            this.txtDeadline.TabIndex = 6;
            // 
            // btnCreateBug1
            // 
            this.btnCreateBug1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCreateBug1.Location = new System.Drawing.Point(306, 418);
            this.btnCreateBug1.Name = "btnCreateBug1";
            this.btnCreateBug1.Size = new System.Drawing.Size(115, 38);
            this.btnCreateBug1.TabIndex = 8;
            this.btnCreateBug1.Text = "Create Bug";
            this.btnCreateBug1.UseVisualStyleBackColor = true;
            this.btnCreateBug1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label31.Location = new System.Drawing.Point(242, 365);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 17);
            this.label31.TabIndex = 9;
            this.label31.Text = "Priority";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "High",
            "Critical"});
            this.cmbPriority.Location = new System.Drawing.Point(352, 368);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 10;
            // 
            // panelCreateBug
            // 
            this.panelCreateBug.Controls.Add(this.cmbPriority);
            this.panelCreateBug.Controls.Add(this.label31);
            this.panelCreateBug.Controls.Add(this.btnCreateBug1);
            this.panelCreateBug.Controls.Add(this.txtDeadline);
            this.panelCreateBug.Controls.Add(this.txtDescription);
            this.panelCreateBug.Controls.Add(this.txtBugTitle);
            this.panelCreateBug.Controls.Add(this.label30);
            this.panelCreateBug.Controls.Add(this.label29);
            this.panelCreateBug.Controls.Add(this.label7);
            this.panelCreateBug.Location = new System.Drawing.Point(140, 12);
            this.panelCreateBug.Name = "panelCreateBug";
            this.panelCreateBug.Size = new System.Drawing.Size(756, 526);
            this.panelCreateBug.TabIndex = 26;
            // 
            // TesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 542);
            this.Controls.Add(this.panelCreateBug);
            this.Controls.Add(this.panel13);
            this.Name = "TesterForm";
            this.Text = "TesterForm";
            this.panel13.ResumeLayout(false);
            this.panelCreateBug.ResumeLayout(false);
            this.panelCreateBug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnCreateBug;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtBugTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.Button btnCreateBug1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Panel panelCreateBug;
    }
}