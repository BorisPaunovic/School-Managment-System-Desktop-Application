
namespace School.Forms
{
    partial class frmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.lblCourses = new System.Windows.Forms.Label();
            this.clbCourses = new System.Windows.Forms.CheckedListBox();
            this.pbAddCourse = new System.Windows.Forms.PictureBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.pbAddCountry = new System.Windows.Forms.PictureBox();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentsResaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsResaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAddUser.BackgroundImage = global::School.Properties.Resources.TransparentHalfCircle;
            this.pnlAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddUser.Controls.Add(this.lblCourses);
            this.pnlAddUser.Controls.Add(this.clbCourses);
            this.pnlAddUser.Controls.Add(this.pbAddCourse);
            this.pnlAddUser.Controls.Add(this.lblStartDate);
            this.pnlAddUser.Controls.Add(this.dtpStartDate);
            this.pnlAddUser.Controls.Add(this.label6);
            this.pnlAddUser.Controls.Add(this.lblLastName);
            this.pnlAddUser.Controls.Add(this.lblGender);
            this.pnlAddUser.Controls.Add(this.lblFirstName);
            this.pnlAddUser.Controls.Add(this.lblEmail);
            this.pnlAddUser.Controls.Add(this.label1);
            this.pnlAddUser.Controls.Add(this.cbGender);
            this.pnlAddUser.Controls.Add(this.lblBirthDate);
            this.pnlAddUser.Controls.Add(this.lblAddStudent);
            this.pnlAddUser.Controls.Add(this.pbAddCountry);
            this.pnlAddUser.Controls.Add(this.cbCountries);
            this.pnlAddUser.Controls.Add(this.btnSave);
            this.pnlAddUser.Controls.Add(this.adressTextBox);
            this.pnlAddUser.Controls.Add(this.dateOfBirthDateTimePicker);
            this.pnlAddUser.Controls.Add(this.emailTextBox);
            this.pnlAddUser.Controls.Add(this.firstNameTextBox);
            this.pnlAddUser.Controls.Add(this.lastNameTextBox);
            this.pnlAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddUser.Location = new System.Drawing.Point(0, 0);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(355, 628);
            this.pnlAddUser.TabIndex = 0;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(40, 428);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(56, 15);
            this.lblCourses.TabIndex = 45;
            this.lblCourses.Text = "Courses";
            // 
            // clbCourses
            // 
            this.clbCourses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCourses.FormattingEnabled = true;
            this.clbCourses.Location = new System.Drawing.Point(43, 450);
            this.clbCourses.Name = "clbCourses";
            this.clbCourses.Size = new System.Drawing.Size(252, 109);
            this.clbCourses.TabIndex = 44;
            // 
            // pbAddCourse
            // 
            this.pbAddCourse.Image = global::School.Properties.Resources.download;
            this.pbAddCourse.Location = new System.Drawing.Point(301, 450);
            this.pbAddCourse.Name = "pbAddCourse";
            this.pbAddCourse.Size = new System.Drawing.Size(32, 28);
            this.pbAddCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCourse.TabIndex = 38;
            this.pbAddCourse.TabStop = false;
            this.pbAddCourse.Click += new System.EventHandler(this.pbAddCourse_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.White;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartDate.Location = new System.Drawing.Point(40, 385);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 13);
            this.lblStartDate.TabIndex = 37;
            this.lblStartDate.Text = "Start date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(43, 399);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(252, 26);
            this.dtpStartDate.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(40, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Country";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastName.Location = new System.Drawing.Point(44, 294);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(63, 13);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Last name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(40, 249);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 13);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "Gender";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFirstName.Location = new System.Drawing.Point(40, 204);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 13);
            this.lblFirstName.TabIndex = 29;
            this.lblFirstName.Text = "First name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(40, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 13);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Adress";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(43, 265);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(252, 26);
            this.cbGender.TabIndex = 25;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.BackColor = System.Drawing.Color.White;
            this.lblBirthDate.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBirthDate.Location = new System.Drawing.Point(40, 114);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(63, 13);
            this.lblBirthDate.TabIndex = 24;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblAddStudent.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddStudent.Location = new System.Drawing.Point(66, 19);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(212, 47);
            this.lblAddStudent.TabIndex = 23;
            this.lblAddStudent.Text = "Add Student";
            // 
            // pbAddCountry
            // 
            this.pbAddCountry.Image = global::School.Properties.Resources.download;
            this.pbAddCountry.Location = new System.Drawing.Point(301, 354);
            this.pbAddCountry.Name = "pbAddCountry";
            this.pbAddCountry.Size = new System.Drawing.Size(32, 28);
            this.pbAddCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCountry.TabIndex = 21;
            this.pbAddCountry.TabStop = false;
            this.pbAddCountry.Click += new System.EventHandler(this.pbAddCountry_Click);
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(43, 356);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(252, 26);
            this.cbCountries.TabIndex = 18;
            this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountries_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Image = global::School.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(92, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 33);
            this.btnSave.TabIndex = 17;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // adressTextBox
            // 
            this.adressTextBox.BackColor = System.Drawing.Color.White;
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Adress", true));
            this.adressTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTextBox.Location = new System.Drawing.Point(43, 83);
            this.adressTextBox.Multiline = true;
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(252, 26);
            this.adressTextBox.TabIndex = 2;
            // 
            // studentsBindingSource
            // 
           
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(43, 130);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(244, 26);
            this.dateOfBirthDateTimePicker.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(43, 175);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(252, 26);
            this.emailTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(43, 220);
            this.firstNameTextBox.Multiline = true;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(43, 310);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.lastNameTextBox.TabIndex = 14;
            // 
            // studentsResaultBindingSource
            // 
         
            // 
            // usersBindingSource
            // 
             // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 628);
            this.Controls.Add(this.pnlAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStudent";
            this.Text = "Add student";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsResaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.BindingSource studentsResaultBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.PictureBox pbAddCountry;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbAddCourse;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.CheckedListBox clbCourses;
        private System.Windows.Forms.Label lblCourses;
    }
}