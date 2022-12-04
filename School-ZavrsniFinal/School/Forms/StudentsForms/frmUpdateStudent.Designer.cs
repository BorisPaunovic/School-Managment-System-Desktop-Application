
namespace School.Forms
{
    partial class frmUpdateStudent
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
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label lastNameLabel;
            this.pnlDecor = new System.Windows.Forms.Panel();
            this.pbAddCourse = new System.Windows.Forms.PictureBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cbPassed = new System.Windows.Forms.ComboBox();
            this.lblPassed = new System.Windows.Forms.Label();
            this.cbCourses = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.pbAddCountry = new System.Windows.Forms.PictureBox();
            this.lblCountries = new System.Windows.Forms.Label();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateStudent = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbGender = new System.Windows.Forms.ComboBox();
            adressLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            this.pnlDecor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.BackColor = System.Drawing.Color.White;
            adressLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adressLabel.Location = new System.Drawing.Point(52, 82);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(53, 15);
            adressLabel.TabIndex = 18;
            adressLabel.Text = "Adress:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.BackColor = System.Drawing.Color.White;
            dateOfBirthLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateOfBirthLabel.Location = new System.Drawing.Point(52, 129);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(84, 15);
            dateOfBirthLabel.TabIndex = 22;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.White;
            emailLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(52, 176);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 15);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.White;
            firstNameLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(52, 223);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(74, 15);
            firstNameLabel.TabIndex = 26;
            firstNameLabel.Text = "First Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.White;
            genderLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(52, 270);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(53, 15);
            genderLabel.TabIndex = 28;
            genderLabel.Text = "Gender:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.White;
            lastNameLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(52, 317);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(73, 15);
            lastNameLabel.TabIndex = 30;
            lastNameLabel.Text = "Last Name:";
            // 
            // pnlDecor
            // 
            this.pnlDecor.BackgroundImage = global::School.Properties.Resources.TransparentHalfCircle;
            this.pnlDecor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDecor.Controls.Add(this.cbGender);
            this.pnlDecor.Controls.Add(this.pbAddCourse);
            this.pnlDecor.Controls.Add(this.dtpStartDate);
            this.pnlDecor.Controls.Add(this.lblStartDate);
            this.pnlDecor.Controls.Add(this.cbPassed);
            this.pnlDecor.Controls.Add(this.lblPassed);
            this.pnlDecor.Controls.Add(this.cbCourses);
            this.pnlDecor.Controls.Add(this.lblCourse);
            this.pnlDecor.Controls.Add(this.pbAddCountry);
            this.pnlDecor.Controls.Add(this.lblCountries);
            this.pnlDecor.Controls.Add(this.cbCountries);
            this.pnlDecor.Controls.Add(adressLabel);
            this.pnlDecor.Controls.Add(this.adressTextBox);
            this.pnlDecor.Controls.Add(dateOfBirthLabel);
            this.pnlDecor.Controls.Add(this.dateOfBirthDateTimePicker);
            this.pnlDecor.Controls.Add(emailLabel);
            this.pnlDecor.Controls.Add(this.emailTextBox);
            this.pnlDecor.Controls.Add(firstNameLabel);
            this.pnlDecor.Controls.Add(this.firstNameTextBox);
            this.pnlDecor.Controls.Add(genderLabel);
            this.pnlDecor.Controls.Add(lastNameLabel);
            this.pnlDecor.Controls.Add(this.lastNameTextBox);
            this.pnlDecor.Controls.Add(this.btnUpdate);
            this.pnlDecor.Controls.Add(this.lblUpdateStudent);
            this.pnlDecor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDecor.Location = new System.Drawing.Point(0, 0);
            this.pnlDecor.Name = "pnlDecor";
            this.pnlDecor.Size = new System.Drawing.Size(344, 603);
            this.pnlDecor.TabIndex = 0;
            // 
            // pbAddCourse
            // 
            this.pbAddCourse.Image = global::School.Properties.Resources.download;
            this.pbAddCourse.Location = new System.Drawing.Point(305, 429);
            this.pbAddCourse.Name = "pbAddCourse";
            this.pbAddCourse.Size = new System.Drawing.Size(34, 26);
            this.pbAddCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCourse.TabIndex = 44;
            this.pbAddCourse.TabStop = false;
            this.pbAddCourse.Click += new System.EventHandler(this.pbAddCourse_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(47, 523);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(252, 26);
            this.dtpStartDate.TabIndex = 43;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.White;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(52, 505);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(63, 15);
            this.lblStartDate.TabIndex = 42;
            this.lblStartDate.Text = "Start date";
            // 
            // cbPassed
            // 
            this.cbPassed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPassed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPassed.FormattingEnabled = true;
            this.cbPassed.Items.AddRange(new object[] {
            "Passed",
            "Failed"});
            this.cbPassed.Location = new System.Drawing.Point(47, 476);
            this.cbPassed.Name = "cbPassed";
            this.cbPassed.Size = new System.Drawing.Size(252, 26);
            this.cbPassed.TabIndex = 41;
            // 
            // lblPassed
            // 
            this.lblPassed.AutoSize = true;
            this.lblPassed.BackColor = System.Drawing.Color.White;
            this.lblPassed.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassed.Location = new System.Drawing.Point(51, 458);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(50, 15);
            this.lblPassed.TabIndex = 40;
            this.lblPassed.Text = "Passed";
            // 
            // cbCourses
            // 
            this.cbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(47, 429);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(252, 26);
            this.cbCourses.TabIndex = 39;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.BackColor = System.Drawing.Color.White;
            this.lblCourse.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(52, 411);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(49, 15);
            this.lblCourse.TabIndex = 38;
            this.lblCourse.Text = "Course";
            // 
            // pbAddCountry
            // 
            this.pbAddCountry.Image = global::School.Properties.Resources.download;
            this.pbAddCountry.Location = new System.Drawing.Point(305, 382);
            this.pbAddCountry.Name = "pbAddCountry";
            this.pbAddCountry.Size = new System.Drawing.Size(34, 26);
            this.pbAddCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCountry.TabIndex = 37;
            this.pbAddCountry.TabStop = false;
            this.pbAddCountry.Click += new System.EventHandler(this.pbAddCountry_Click);
            // 
            // lblCountries
            // 
            this.lblCountries.AutoSize = true;
            this.lblCountries.BackColor = System.Drawing.Color.White;
            this.lblCountries.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountries.Location = new System.Drawing.Point(52, 364);
            this.lblCountries.Name = "lblCountries";
            this.lblCountries.Size = new System.Drawing.Size(53, 15);
            this.lblCountries.TabIndex = 36;
            this.lblCountries.Text = "Country";
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(47, 382);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(252, 26);
            this.cbCountries.TabIndex = 35;
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Adress", true));
            this.adressTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTextBox.Location = new System.Drawing.Point(47, 100);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(252, 26);
            this.adressTextBox.TabIndex = 19;
            // 
            // studentsBindingSource
            // 
   
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(47, 147);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(252, 26);
            this.dateOfBirthDateTimePicker.TabIndex = 23;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(47, 194);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(252, 26);
            this.emailTextBox.TabIndex = 25;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(47, 241);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.firstNameTextBox.TabIndex = 27;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(47, 335);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.lastNameTextBox.TabIndex = 31;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::School.Properties.Resources.Updatebtn;
            this.btnUpdate.Location = new System.Drawing.Point(92, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 31);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateStudent
            // 
            this.lblUpdateStudent.AutoSize = true;
            this.lblUpdateStudent.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateStudent.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStudent.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUpdateStudent.Location = new System.Drawing.Point(53, 9);
            this.lblUpdateStudent.Name = "lblUpdateStudent";
            this.lblUpdateStudent.Size = new System.Drawing.Size(238, 43);
            this.lblUpdateStudent.TabIndex = 17;
            this.lblUpdateStudent.Text = "Update student";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(46, 288);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(252, 27);
            this.cbGender.TabIndex = 45;
            // 
            // frmUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 603);
            this.Controls.Add(this.pnlDecor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUpdateStudent";
            this.Text = "Update student";
            this.Load += new System.EventHandler(this.frmUpdateStudent_Load);
            this.pnlDecor.ResumeLayout(false);
            this.pnlDecor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDecor;
        private System.Windows.Forms.Label lblUpdateStudent;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.Label lblCountries;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbAddCountry;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cbPassed;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.PictureBox pbAddCourse;
        private System.Windows.Forms.ComboBox cbCourses;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cbGender;
    }
}