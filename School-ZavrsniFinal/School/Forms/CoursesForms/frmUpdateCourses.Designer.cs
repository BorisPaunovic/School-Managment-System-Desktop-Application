
namespace School.Forms.CoursesForms
{
    partial class frmUpdateCourses
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
            this.pnlUpdateCourse = new System.Windows.Forms.Panel();
            this.clbSubjects = new System.Windows.Forms.CheckedListBox();
            this.pbAddSubject = new System.Windows.Forms.PictureBox();
            this.lblUpdateCourse = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coursesDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            coursesDescriptionLabel = new System.Windows.Forms.Label();
            coursesNameLabel = new System.Windows.Forms.Label();
            this.pnlUpdateCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // coursesDescriptionLabel
            // 
            coursesDescriptionLabel.AutoSize = true;
            coursesDescriptionLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coursesDescriptionLabel.Location = new System.Drawing.Point(59, 165);
            coursesDescriptionLabel.Name = "coursesDescriptionLabel";
            coursesDescriptionLabel.Size = new System.Drawing.Size(129, 15);
            coursesDescriptionLabel.TabIndex = 1;
            coursesDescriptionLabel.Text = "Courses Description:";
            // 
            // coursesNameLabel
            // 
            coursesNameLabel.AutoSize = true;
            coursesNameLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coursesNameLabel.Location = new System.Drawing.Point(59, 118);
            coursesNameLabel.Name = "coursesNameLabel";
            coursesNameLabel.Size = new System.Drawing.Size(97, 15);
            coursesNameLabel.TabIndex = 5;
            coursesNameLabel.Text = "Courses Name:";
            // 
            // pnlUpdateCourse
            // 
            this.pnlUpdateCourse.BackgroundImage = global::School.Properties.Resources.TransparentHalfCircle;
            this.pnlUpdateCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUpdateCourse.Controls.Add(this.clbSubjects);
            this.pnlUpdateCourse.Controls.Add(this.pbAddSubject);
            this.pnlUpdateCourse.Controls.Add(this.lblUpdateCourse);
            this.pnlUpdateCourse.Controls.Add(this.button1);
            this.pnlUpdateCourse.Controls.Add(this.label1);
            this.pnlUpdateCourse.Controls.Add(coursesDescriptionLabel);
            this.pnlUpdateCourse.Controls.Add(this.coursesDescriptionTextBox);
            this.pnlUpdateCourse.Controls.Add(coursesNameLabel);
            this.pnlUpdateCourse.Controls.Add(this.coursesNameTextBox);
            this.pnlUpdateCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdateCourse.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateCourse.Name = "pnlUpdateCourse";
            this.pnlUpdateCourse.Size = new System.Drawing.Size(366, 488);
            this.pnlUpdateCourse.TabIndex = 0;
            // 
            // clbSubjects
            // 
            this.clbSubjects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSubjects.FormattingEnabled = true;
            this.clbSubjects.Location = new System.Drawing.Point(62, 230);
            this.clbSubjects.Name = "clbSubjects";
            this.clbSubjects.Size = new System.Drawing.Size(252, 151);
            this.clbSubjects.TabIndex = 46;
            // 
            // pbAddSubject
            // 
            this.pbAddSubject.BackColor = System.Drawing.Color.Transparent;
            this.pbAddSubject.Image = global::School.Properties.Resources.download;
            this.pbAddSubject.Location = new System.Drawing.Point(320, 230);
            this.pbAddSubject.Name = "pbAddSubject";
            this.pbAddSubject.Size = new System.Drawing.Size(34, 26);
            this.pbAddSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddSubject.TabIndex = 45;
            this.pbAddSubject.TabStop = false;
            this.pbAddSubject.Click += new System.EventHandler(this.pbAddSubject_Click);
            // 
            // lblUpdateCourse
            // 
            this.lblUpdateCourse.AutoSize = true;
            this.lblUpdateCourse.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateCourse.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCourse.Location = new System.Drawing.Point(74, 25);
            this.lblUpdateCourse.Name = "lblUpdateCourse";
            this.lblUpdateCourse.Size = new System.Drawing.Size(215, 42);
            this.lblUpdateCourse.TabIndex = 11;
            this.lblUpdateCourse.Text = "Update course";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::School.Properties.Resources.Updatebtn;
            this.button1.Location = new System.Drawing.Point(103, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 28);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subjects";
            // 
            // coursesDescriptionTextBox
            // 
            this.coursesDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CoursesDescription", true));
            this.coursesDescriptionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesDescriptionTextBox.Location = new System.Drawing.Point(62, 183);
            this.coursesDescriptionTextBox.Name = "coursesDescriptionTextBox";
            this.coursesDescriptionTextBox.Size = new System.Drawing.Size(252, 26);
            this.coursesDescriptionTextBox.TabIndex = 2;
            // 
            // coursesBindingSource
            // 
        
            // 
            // coursesNameTextBox
            // 
            this.coursesNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "CoursesName", true));
            this.coursesNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesNameTextBox.Location = new System.Drawing.Point(62, 136);
            this.coursesNameTextBox.Name = "coursesNameTextBox";
            this.coursesNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.coursesNameTextBox.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 488);
            this.Controls.Add(this.pnlUpdateCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateCourses";
            this.Text = ";";
            this.Load += new System.EventHandler(this.frmUpdateCourses_Load);
            this.pnlUpdateCourse.ResumeLayout(false);
            this.pnlUpdateCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdateCourse;
        private System.Windows.Forms.TextBox coursesDescriptionTextBox;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.TextBox coursesNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdateCourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbAddSubject;
        private System.Windows.Forms.CheckedListBox clbSubjects;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}