
namespace School.Forms
{
    partial class frmAddCourses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label coursesDescriptionLabel;
            System.Windows.Forms.Label coursesNameLabel;
            this.pnlAddCourse = new System.Windows.Forms.Panel();
            this.pbAddSubject = new System.Windows.Forms.PictureBox();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.clbSubjects = new System.Windows.Forms.CheckedListBox();
            this.lblAddCourse = new System.Windows.Forms.Label();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.coursesNameTextBox = new System.Windows.Forms.TextBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            coursesDescriptionLabel = new System.Windows.Forms.Label();
            coursesNameLabel = new System.Windows.Forms.Label();
            this.pnlAddCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // coursesDescriptionLabel
            // 
            coursesDescriptionLabel.AutoSize = true;
            coursesDescriptionLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coursesDescriptionLabel.Location = new System.Drawing.Point(52, 148);
            coursesDescriptionLabel.Name = "coursesDescriptionLabel";
            coursesDescriptionLabel.Size = new System.Drawing.Size(80, 15);
            coursesDescriptionLabel.TabIndex = 8;
            coursesDescriptionLabel.Text = " Description:";
            // 
            // coursesNameLabel
            // 
            coursesNameLabel.AutoSize = true;
            coursesNameLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coursesNameLabel.Location = new System.Drawing.Point(52, 101);
            coursesNameLabel.Name = "coursesNameLabel";
            coursesNameLabel.Size = new System.Drawing.Size(45, 15);
            coursesNameLabel.TabIndex = 12;
            coursesNameLabel.Text = "Name:";
            // 
            // pnlAddCourse
            // 
            this.pnlAddCourse.BackgroundImage = global::School.Properties.Resources.TransparentHalfCircle;
            this.pnlAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddCourse.Controls.Add(this.pbAddSubject);
            this.pnlAddCourse.Controls.Add(this.lblSubjects);
            this.pnlAddCourse.Controls.Add(this.clbSubjects);
            this.pnlAddCourse.Controls.Add(this.lblAddCourse);
            this.pnlAddCourse.Controls.Add(this.btnSaveCourse);
            this.pnlAddCourse.Controls.Add(coursesDescriptionLabel);
            this.pnlAddCourse.Controls.Add(this.coursesNameTextBox);
            this.pnlAddCourse.Controls.Add(coursesNameLabel);
            this.pnlAddCourse.Controls.Add(this.coursesDescriptionTextBox);
            this.pnlAddCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddCourse.Location = new System.Drawing.Point(0, 0);
            this.pnlAddCourse.Name = "pnlAddCourse";
            this.pnlAddCourse.Size = new System.Drawing.Size(355, 502);
            this.pnlAddCourse.TabIndex = 8;
            // 
            // pbAddSubject
            // 
            this.pbAddSubject.Image = global::School.Properties.Resources.download;
            this.pbAddSubject.Location = new System.Drawing.Point(313, 298);
            this.pbAddSubject.Name = "pbAddSubject";
            this.pbAddSubject.Size = new System.Drawing.Size(34, 26);
            this.pbAddSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddSubject.TabIndex = 46;
            this.pbAddSubject.TabStop = false;
            this.pbAddSubject.Click += new System.EventHandler(this.pbAddSubject_Click);
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjects.Location = new System.Drawing.Point(52, 280);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(57, 15);
            this.lblSubjects.TabIndex = 16;
            this.lblSubjects.Text = "Subjects";
            // 
            // clbSubjects
            // 
            this.clbSubjects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSubjects.FormattingEnabled = true;
            this.clbSubjects.Location = new System.Drawing.Point(55, 298);
            this.clbSubjects.Name = "clbSubjects";
            this.clbSubjects.Size = new System.Drawing.Size(252, 109);
            this.clbSubjects.TabIndex = 15;
            // 
            // lblAddCourse
            // 
            this.lblAddCourse.AutoSize = true;
            this.lblAddCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCourse.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourse.Location = new System.Drawing.Point(74, 9);
            this.lblAddCourse.Name = "lblAddCourse";
            this.lblAddCourse.Size = new System.Drawing.Size(204, 49);
            this.lblAddCourse.TabIndex = 14;
            this.lblAddCourse.Text = "Add course";
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Image = global::School.Properties.Resources.Save;
            this.btnSaveCourse.Location = new System.Drawing.Point(98, 426);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(159, 34);
            this.btnSaveCourse.TabIndex = 9;
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // coursesNameTextBox
            // 
            this.coursesNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CoursesName", true));
            this.coursesNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesNameTextBox.Location = new System.Drawing.Point(55, 119);
            this.coursesNameTextBox.Name = "coursesNameTextBox";
            this.coursesNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.coursesNameTextBox.TabIndex = 13;
            // 
            // coursesBindingSource
            // 
          
            // 
            // coursesDescriptionTextBox
            // 
            this.coursesDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CoursesDescription", true));
            this.coursesDescriptionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesDescriptionTextBox.Location = new System.Drawing.Point(55, 166);
            this.coursesDescriptionTextBox.Multiline = true;
            this.coursesDescriptionTextBox.Name = "coursesDescriptionTextBox";
            this.coursesDescriptionTextBox.Size = new System.Drawing.Size(252, 111);
            this.coursesDescriptionTextBox.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 502);
            this.Controls.Add(this.pnlAddCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddCourses";
            this.Text = "Add Courses";
            this.pnlAddCourse.ResumeLayout(false);
            this.pnlAddCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.Panel pnlAddCourse;
        private System.Windows.Forms.Label lblAddCourse;
        private System.Windows.Forms.Button btnSaveCourse;
        private System.Windows.Forms.TextBox coursesNameTextBox;
        private System.Windows.Forms.TextBox coursesDescriptionTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.CheckedListBox clbSubjects;
        private System.Windows.Forms.PictureBox pbAddSubject;
    }
}