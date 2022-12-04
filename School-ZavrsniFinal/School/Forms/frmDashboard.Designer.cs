
namespace School.Forms
{
    partial class frmDashboard
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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pbSubjects = new System.Windows.Forms.PictureBox();
            this.pbCountries = new System.Windows.Forms.PictureBox();
            this.pbTeachersTial = new System.Windows.Forms.PictureBox();
            this.pbstudentsTial = new System.Windows.Forms.PictureBox();
            this.pbCourseTial = new System.Windows.Forms.PictureBox();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeachersTial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstudentsTial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourseTial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDashboard.BackColor = System.Drawing.Color.White;
            this.pnlDashboard.Controls.Add(this.pbSubjects);
            this.pnlDashboard.Controls.Add(this.pbCountries);
            this.pnlDashboard.Controls.Add(this.pbTeachersTial);
            this.pnlDashboard.Controls.Add(this.pbstudentsTial);
            this.pnlDashboard.Controls.Add(this.pbCourseTial);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(803, 527);
            this.pnlDashboard.TabIndex = 3;
            // 
            // pbSubjects
            // 
            this.pbSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSubjects.BackColor = System.Drawing.Color.SandyBrown;
            this.pbSubjects.Image = global::School.Properties.Resources.SubjectsTial;
            this.pbSubjects.Location = new System.Drawing.Point(505, 37);
            this.pbSubjects.Name = "pbSubjects";
            this.pbSubjects.Size = new System.Drawing.Size(224, 156);
            this.pbSubjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSubjects.TabIndex = 4;
            this.pbSubjects.TabStop = false;
            this.pbSubjects.Click += new System.EventHandler(this.pbSubjects_Click);
            // 
            // pbCountries
            // 
            this.pbCountries.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbCountries.BackColor = System.Drawing.Color.SandyBrown;
            this.pbCountries.Image = global::School.Properties.Resources.Countries;
            this.pbCountries.Location = new System.Drawing.Point(275, 37);
            this.pbCountries.Name = "pbCountries";
            this.pbCountries.Size = new System.Drawing.Size(224, 156);
            this.pbCountries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCountries.TabIndex = 3;
            this.pbCountries.TabStop = false;
            this.pbCountries.Click += new System.EventHandler(this.pbCountries_Click);
            // 
            // pbTeachersTial
            // 
            this.pbTeachersTial.BackColor = System.Drawing.Color.SandyBrown;
            this.pbTeachersTial.Image = global::School.Properties.Resources.TeachersTial;
            this.pbTeachersTial.Location = new System.Drawing.Point(45, 37);
            this.pbTeachersTial.Name = "pbTeachersTial";
            this.pbTeachersTial.Size = new System.Drawing.Size(224, 156);
            this.pbTeachersTial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTeachersTial.TabIndex = 2;
            this.pbTeachersTial.TabStop = false;
            this.pbTeachersTial.Click += new System.EventHandler(this.pbTeachersTial_Click);
            // 
            // pbstudentsTial
            // 
            this.pbstudentsTial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbstudentsTial.BackColor = System.Drawing.Color.SandyBrown;
            this.pbstudentsTial.Image = global::School.Properties.Resources.StudentsTial;
            this.pbstudentsTial.Location = new System.Drawing.Point(424, 241);
            this.pbstudentsTial.Name = "pbstudentsTial";
            this.pbstudentsTial.Size = new System.Drawing.Size(224, 156);
            this.pbstudentsTial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbstudentsTial.TabIndex = 1;
            this.pbstudentsTial.TabStop = false;
            this.pbstudentsTial.Click += new System.EventHandler(this.pbstudentsTial_Click);
            // 
            // pbCourseTial
            // 
            this.pbCourseTial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbCourseTial.BackColor = System.Drawing.Color.Coral;
            this.pbCourseTial.Image = global::School.Properties.Resources.SoursesTial;
            this.pbCourseTial.Location = new System.Drawing.Point(116, 241);
            this.pbCourseTial.Name = "pbCourseTial";
            this.pbCourseTial.Size = new System.Drawing.Size(224, 156);
            this.pbCourseTial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCourseTial.TabIndex = 0;
            this.pbCourseTial.TabStop = false;
            this.pbCourseTial.Click += new System.EventHandler(this.pbCourseTial_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 527);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeachersTial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbstudentsTial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourseTial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCourseTial;
        private System.Windows.Forms.PictureBox pbstudentsTial;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.PictureBox pbTeachersTial;
        private System.Windows.Forms.PictureBox pbCountries;
        private System.Windows.Forms.PictureBox pbSubjects;
    }
}