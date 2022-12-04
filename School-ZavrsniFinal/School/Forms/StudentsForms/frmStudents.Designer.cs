
namespace School.Forms
{
    partial class frmStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlStudentMenu = new System.Windows.Forms.Panel();
            this.pbUpdateStudent = new System.Windows.Forms.PictureBox();
            this.pbDeleteSutudent = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlStudentList = new System.Windows.Forms.Panel();
            this.studentsResaultMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.studentsResaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlStudentSearch = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsResaultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStudentMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSutudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsResaultMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsResaultBindingSource)).BeginInit();
            this.pnlStudentSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsResaultBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentMenu
            // 
            this.pnlStudentMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlStudentMenu.Controls.Add(this.pbUpdateStudent);
            this.pnlStudentMenu.Controls.Add(this.pbDeleteSutudent);
            this.pnlStudentMenu.Controls.Add(this.pictureBox1);
            this.pnlStudentMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentMenu.Name = "pnlStudentMenu";
            this.pnlStudentMenu.Size = new System.Drawing.Size(823, 120);
            this.pnlStudentMenu.TabIndex = 0;
            // 
            // pbUpdateStudent
            // 
            this.pbUpdateStudent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbUpdateStudent.BackColor = System.Drawing.Color.Coral;
            this.pbUpdateStudent.Image = global::School.Properties.Resources.UpdatestudentTial;
            this.pbUpdateStudent.Location = new System.Drawing.Point(608, 12);
            this.pbUpdateStudent.Name = "pbUpdateStudent";
            this.pbUpdateStudent.Size = new System.Drawing.Size(158, 99);
            this.pbUpdateStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdateStudent.TabIndex = 2;
            this.pbUpdateStudent.TabStop = false;
            this.pbUpdateStudent.Click += new System.EventHandler(this.pbUpdateStudent_Click);
            // 
            // pbDeleteSutudent
            // 
            this.pbDeleteSutudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDeleteSutudent.BackColor = System.Drawing.Color.Coral;
            this.pbDeleteSutudent.Image = global::School.Properties.Resources.DeleteStudentTial1;
            this.pbDeleteSutudent.Location = new System.Drawing.Point(316, 12);
            this.pbDeleteSutudent.Name = "pbDeleteSutudent";
            this.pbDeleteSutudent.Size = new System.Drawing.Size(158, 99);
            this.pbDeleteSutudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeleteSutudent.TabIndex = 1;
            this.pbDeleteSutudent.TabStop = false;
            this.pbDeleteSutudent.Click += new System.EventHandler(this.pbDeleteSutudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Coral;
            this.pictureBox1.Image = global::School.Properties.Resources.AddStudentTial1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlStudentList
            // 
            this.pnlStudentList.BackColor = System.Drawing.Color.White;
            this.pnlStudentList.Controls.Add(this.studentsResaultMetroGrid);
            this.pnlStudentList.Controls.Add(this.pnlStudentSearch);
            this.pnlStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudentList.Location = new System.Drawing.Point(0, 120);
            this.pnlStudentList.Name = "pnlStudentList";
            this.pnlStudentList.Size = new System.Drawing.Size(823, 535);
            this.pnlStudentList.TabIndex = 1;
            // 
            // studentsResaultMetroGrid
            // 
            this.studentsResaultMetroGrid.AllowUserToResizeRows = false;
            this.studentsResaultMetroGrid.AutoGenerateColumns = false;
            this.studentsResaultMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentsResaultMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentsResaultMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentsResaultMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentsResaultMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsResaultMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentsResaultMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsResaultMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentsIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.coursesNameDataGridViewTextBoxColumn,
            this.passedDataGridViewCheckBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.coursesDescriptionDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn});
            this.studentsResaultMetroGrid.DataSource = this.studentsResaultBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentsResaultMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentsResaultMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsResaultMetroGrid.EnableHeadersVisualStyles = false;
            this.studentsResaultMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.studentsResaultMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentsResaultMetroGrid.Location = new System.Drawing.Point(0, 65);
            this.studentsResaultMetroGrid.Name = "studentsResaultMetroGrid";
            this.studentsResaultMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsResaultMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentsResaultMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentsResaultMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsResaultMetroGrid.Size = new System.Drawing.Size(823, 470);
            this.studentsResaultMetroGrid.TabIndex = 2;
            this.studentsResaultMetroGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsResaultMetroGrid_CellDoubleClick);
            // 
            // pnlStudentSearch
            // 
            this.pnlStudentSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlStudentSearch.Controls.Add(this.btnRefresh);
            this.pnlStudentSearch.Controls.Add(this.cbFilter);
            this.pnlStudentSearch.Controls.Add(this.pbSearchbtn);
            this.pnlStudentSearch.Controls.Add(this.tbSearch);
            this.pnlStudentSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentSearch.Name = "pnlStudentSearch";
            this.pnlStudentSearch.Size = new System.Drawing.Size(823, 65);
            this.pnlStudentSearch.TabIndex = 0;
            this.pnlStudentSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStudentSearch_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = global::School.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(26, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 31);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "First Name",
            "Course Name",
            "All Students"});
            this.cbFilter.Location = new System.Drawing.Point(566, 22);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(171, 21);
            this.cbFilter.TabIndex = 4;
            // 
            // pbSearchbtn
            // 
            this.pbSearchbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbSearchbtn.Image = global::School.Properties.Resources.imageedit_16_5363622926;
            this.pbSearchbtn.Location = new System.Drawing.Point(68, 17);
            this.pbSearchbtn.Name = "pbSearchbtn";
            this.pbSearchbtn.Size = new System.Drawing.Size(36, 30);
            this.pbSearchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchbtn.TabIndex = 1;
            this.pbSearchbtn.TabStop = false;
            this.pbSearchbtn.Click += new System.EventHandler(this.pbSearchbtn_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(110, 17);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(450, 30);
            this.tbSearch.TabIndex = 0;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // studentsResaultBindingSource1
            // 
            this.studentsResaultBindingSource1.DataSource = typeof(SchoolModel.StudentsResault);
            // 
            // studentsIDDataGridViewTextBoxColumn
            // 
            this.studentsIDDataGridViewTextBoxColumn.DataPropertyName = "StudentsID";
            this.studentsIDDataGridViewTextBoxColumn.HeaderText = "StudentsID";
            this.studentsIDDataGridViewTextBoxColumn.Name = "studentsIDDataGridViewTextBoxColumn";
            this.studentsIDDataGridViewTextBoxColumn.Width = 87;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 81;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 79;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 68;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 91;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 64;
            // 
            // coursesNameDataGridViewTextBoxColumn
            // 
            this.coursesNameDataGridViewTextBoxColumn.DataPropertyName = "CoursesName";
            this.coursesNameDataGridViewTextBoxColumn.HeaderText = "CoursesName";
            this.coursesNameDataGridViewTextBoxColumn.Name = "coursesNameDataGridViewTextBoxColumn";
            // 
            // passedDataGridViewCheckBoxColumn
            // 
            this.passedDataGridViewCheckBoxColumn.DataPropertyName = "Passed";
            this.passedDataGridViewCheckBoxColumn.HeaderText = "Passed";
            this.passedDataGridViewCheckBoxColumn.Name = "passedDataGridViewCheckBoxColumn";
            this.passedDataGridViewCheckBoxColumn.Width = 46;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // coursesDescriptionDataGridViewTextBoxColumn
            // 
            this.coursesDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CoursesDescription";
            this.coursesDescriptionDataGridViewTextBoxColumn.HeaderText = "CoursesDescription";
            this.coursesDescriptionDataGridViewTextBoxColumn.Name = "coursesDescriptionDataGridViewTextBoxColumn";
            this.coursesDescriptionDataGridViewTextBoxColumn.Width = 130;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 655);
            this.Controls.Add(this.pnlStudentList);
            this.Controls.Add(this.pnlStudentMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudents";
            this.Text = "frmStudents";
            this.pnlStudentMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSutudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStudentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsResaultMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsResaultBindingSource)).EndInit();
            this.pnlStudentSearch.ResumeLayout(false);
            this.pnlStudentSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsResaultBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlStudentList;
        private System.Windows.Forms.Panel pnlStudentSearch;
        private System.Windows.Forms.PictureBox pbDeleteSutudent;
        private System.Windows.Forms.PictureBox pbUpdateStudent;
        private System.Windows.Forms.BindingSource studentsResaultBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private MetroFramework.Controls.MetroGrid studentsResaultMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn passedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsResaultBindingSource1;
    }
}