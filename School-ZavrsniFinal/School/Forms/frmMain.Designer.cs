
namespace School.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlForms = new System.Windows.Forms.Panel();
            this.pnlMovement = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.pbSubjects = new System.Windows.Forms.PictureBox();
            this.pbCountries = new System.Windows.Forms.PictureBox();
            this.pbTeachers = new System.Windows.Forms.PictureBox();
            this.pbStudents = new System.Windows.Forms.PictureBox();
            this.pbCourses = new System.Windows.Forms.PictureBox();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(173, 0);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(787, 465);
            this.pnlForms.TabIndex = 1;
            // 
            // pnlMovement
            // 
            this.pnlMovement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMovement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMovement.Location = new System.Drawing.Point(173, 0);
            this.pnlMovement.Name = "pnlMovement";
            this.pnlMovement.Size = new System.Drawing.Size(787, 13);
            this.pnlMovement.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.BackgroundImage = global::School.Properties.Resources.pnlMenuBackground;
            this.pnlMenu.Controls.Add(this.pbUsers);
            this.pnlMenu.Controls.Add(this.pbSubjects);
            this.pnlMenu.Controls.Add(this.pbCountries);
            this.pnlMenu.Controls.Add(this.pbTeachers);
            this.pnlMenu.Controls.Add(this.pbStudents);
            this.pnlMenu.Controls.Add(this.pbCourses);
            this.pnlMenu.Controls.Add(this.pbDashboard);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(173, 465);
            this.pnlMenu.TabIndex = 0;
            // 
            // pbUsers
            // 
            this.pbUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(164)))), ((int)(((byte)(218)))));
            this.pbUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbUsers.Image = global::School.Properties.Resources.Usersactive1;
            this.pbUsers.Location = new System.Drawing.Point(0, 325);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(173, 36);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsers.TabIndex = 6;
            this.pbUsers.TabStop = false;
            this.pbUsers.Click += new System.EventHandler(this.pbUsers_Click);
            // 
            // pbSubjects
            // 
            this.pbSubjects.BackColor = System.Drawing.Color.Red;
            this.pbSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSubjects.Image = global::School.Properties.Resources.Subjects_btn;
            this.pbSubjects.Location = new System.Drawing.Point(0, 289);
            this.pbSubjects.Name = "pbSubjects";
            this.pbSubjects.Size = new System.Drawing.Size(173, 36);
            this.pbSubjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSubjects.TabIndex = 5;
            this.pbSubjects.TabStop = false;
            this.pbSubjects.Click += new System.EventHandler(this.pbSubjects_Click);
            // 
            // pbCountries
            // 
            this.pbCountries.BackColor = System.Drawing.Color.Red;
            this.pbCountries.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbCountries.Image = global::School.Properties.Resources.Countriespic;
            this.pbCountries.Location = new System.Drawing.Point(0, 253);
            this.pbCountries.Name = "pbCountries";
            this.pbCountries.Size = new System.Drawing.Size(173, 36);
            this.pbCountries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCountries.TabIndex = 4;
            this.pbCountries.TabStop = false;
            this.pbCountries.Click += new System.EventHandler(this.pbCountries_Click);
            // 
            // pbTeachers
            // 
            this.pbTeachers.BackColor = System.Drawing.Color.Red;
            this.pbTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbTeachers.Image = global::School.Properties.Resources.Teachersbtn;
            this.pbTeachers.Location = new System.Drawing.Point(0, 217);
            this.pbTeachers.Name = "pbTeachers";
            this.pbTeachers.Size = new System.Drawing.Size(173, 36);
            this.pbTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTeachers.TabIndex = 3;
            this.pbTeachers.TabStop = false;
            this.pbTeachers.Click += new System.EventHandler(this.pbTeachers_Click);
            // 
            // pbStudents
            // 
            this.pbStudents.BackColor = System.Drawing.Color.Red;
            this.pbStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbStudents.Image = global::School.Properties.Resources.studentbtn;
            this.pbStudents.Location = new System.Drawing.Point(0, 181);
            this.pbStudents.Name = "pbStudents";
            this.pbStudents.Size = new System.Drawing.Size(173, 36);
            this.pbStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudents.TabIndex = 2;
            this.pbStudents.TabStop = false;
            this.pbStudents.Click += new System.EventHandler(this.pbStudents_Click);
            // 
            // pbCourses
            // 
            this.pbCourses.BackColor = System.Drawing.Color.Red;
            this.pbCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbCourses.Image = global::School.Properties.Resources.Coursesbtn;
            this.pbCourses.Location = new System.Drawing.Point(0, 145);
            this.pbCourses.Name = "pbCourses";
            this.pbCourses.Size = new System.Drawing.Size(173, 36);
            this.pbCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCourses.TabIndex = 1;
            this.pbCourses.TabStop = false;
            this.pbCourses.Click += new System.EventHandler(this.pbCourses_Click);
            // 
            // pbDashboard
            // 
            this.pbDashboard.BackColor = System.Drawing.Color.Red;
            this.pbDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbDashboard.Image = global::School.Properties.Resources.dashboardbtn;
            this.pbDashboard.Location = new System.Drawing.Point(0, 109);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(173, 36);
            this.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDashboard.TabIndex = 0;
            this.pbDashboard.TabStop = false;
            this.pbDashboard.Click += new System.EventHandler(this.pbDashboard_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Lime;
            this.pnlLogo.BackgroundImage = global::School.Properties.Resources.pnlMenuBackground;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(173, 109);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School.Properties.Resources.TransparentLogo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 465);
            this.Controls.Add(this.pnlMovement);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Panel pnlMovement;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.PictureBox pbStudents;
        private System.Windows.Forms.PictureBox pbCourses;
        private System.Windows.Forms.PictureBox pbTeachers;
        private System.Windows.Forms.PictureBox pbCountries;
        private System.Windows.Forms.PictureBox pbSubjects;
        private System.Windows.Forms.PictureBox pbUsers;
    }
}