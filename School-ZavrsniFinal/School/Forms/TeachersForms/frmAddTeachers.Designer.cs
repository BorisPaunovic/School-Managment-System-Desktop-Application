
namespace School.Forms.TeachersForms
{
    partial class frmAddTeachers
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
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            this.pnlAddTeacher = new System.Windows.Forms.Panel();
            this.lblCourses = new System.Windows.Forms.Label();
            this.clbCourses = new System.Windows.Forms.CheckedListBox();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbAddCourse = new System.Windows.Forms.PictureBox();
            adressLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            this.pnlAddTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adressLabel.Location = new System.Drawing.Point(39, 221);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(53, 15);
            adressLabel.TabIndex = 1;
            adressLabel.Text = "Adress:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfBirthLabel.Location = new System.Drawing.Point(40, 268);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(84, 15);
            dateOfBirthLabel.TabIndex = 3;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(40, 174);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 15);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(39, 82);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(74, 15);
            firstNameLabel.TabIndex = 7;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(39, 129);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(73, 15);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name:";
            // 
            // pnlAddTeacher
            // 
            this.pnlAddTeacher.BackgroundImage = global::School.Properties.Resources.TransparentHalfCircle;
            this.pnlAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddTeacher.Controls.Add(this.pbAddCourse);
            this.pnlAddTeacher.Controls.Add(this.lblCourses);
            this.pnlAddTeacher.Controls.Add(this.clbCourses);
            this.pnlAddTeacher.Controls.Add(this.lblAddStudent);
            this.pnlAddTeacher.Controls.Add(this.lblGender);
            this.pnlAddTeacher.Controls.Add(this.cbGender);
            this.pnlAddTeacher.Controls.Add(this.btnSave);
            this.pnlAddTeacher.Controls.Add(adressLabel);
            this.pnlAddTeacher.Controls.Add(this.adressTextBox);
            this.pnlAddTeacher.Controls.Add(dateOfBirthLabel);
            this.pnlAddTeacher.Controls.Add(this.dateOfBirthDateTimePicker);
            this.pnlAddTeacher.Controls.Add(emailLabel);
            this.pnlAddTeacher.Controls.Add(this.emailTextBox);
            this.pnlAddTeacher.Controls.Add(firstNameLabel);
            this.pnlAddTeacher.Controls.Add(this.firstNameTextBox);
            this.pnlAddTeacher.Controls.Add(lastNameLabel);
            this.pnlAddTeacher.Controls.Add(this.lastNameTextBox);
            this.pnlAddTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddTeacher.Location = new System.Drawing.Point(0, 0);
            this.pnlAddTeacher.Name = "pnlAddTeacher";
            this.pnlAddTeacher.Size = new System.Drawing.Size(355, 555);
            this.pnlAddTeacher.TabIndex = 0;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(40, 362);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(56, 15);
            this.lblCourses.TabIndex = 44;
            this.lblCourses.Text = "Courses";
            // 
            // clbCourses
            // 
            this.clbCourses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCourses.FormattingEnabled = true;
            this.clbCourses.Location = new System.Drawing.Point(42, 380);
            this.clbCourses.Name = "clbCourses";
            this.clbCourses.Size = new System.Drawing.Size(252, 109);
            this.clbCourses.TabIndex = 43;
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblAddStudent.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudent.ForeColor = System.Drawing.Color.Black;
            this.lblAddStudent.Location = new System.Drawing.Point(59, 18);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(211, 47);
            this.lblAddStudent.TabIndex = 42;
            this.lblAddStudent.Text = "Add Teacher";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(41, 315);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(49, 15);
            this.lblGender.TabIndex = 41;
            this.lblGender.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(44, 333);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(252, 27);
            this.cbGender.TabIndex = 40;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::School.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(94, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 33);
            this.btnSave.TabIndex = 39;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "Adress", true));
            this.adressTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTextBox.Location = new System.Drawing.Point(42, 239);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(252, 26);
            this.adressTextBox.TabIndex = 2;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teachersBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(43, 286);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(252, 26);
            this.dateOfBirthDateTimePicker.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(43, 192);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(252, 26);
            this.emailTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(44, 100);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teachersBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(42, 147);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbAddCourse
            // 
            this.pbAddCourse.Image = global::School.Properties.Resources.download;
            this.pbAddCourse.Location = new System.Drawing.Point(300, 380);
            this.pbAddCourse.Name = "pbAddCourse";
            this.pbAddCourse.Size = new System.Drawing.Size(32, 28);
            this.pbAddCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCourse.TabIndex = 22;
            this.pbAddCourse.TabStop = false;
            this.pbAddCourse.Click += new System.EventHandler(this.pbAddCourse_Click);
            // 
            // frmAddTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 555);
            this.Controls.Add(this.pnlAddTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddTeachers";
            this.Text = "frmAddTeachers";
            this.pnlAddTeacher.ResumeLayout(false);
            this.pnlAddTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddTeacher;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.CheckedListBox clbCourses;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbAddCourse;
    }
}