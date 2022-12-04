
namespace School.Forms.TeachersForms
{
    partial class frmTeachers
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
            this.pbAddTeacher = new System.Windows.Forms.PictureBox();
            this.pnlStudentSearch = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlTeachers = new System.Windows.Forms.Panel();
            this.teachersJoinCoursesResaultMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.teachersJoinCoursesResaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersJoinCoursesResaultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teachersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersCoursesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStudentMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSutudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTeacher)).BeginInit();
            this.pnlStudentSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            this.pnlTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersJoinCoursesResaultMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersJoinCoursesResaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersJoinCoursesResaultBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentMenu
            // 
            this.pnlStudentMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlStudentMenu.Controls.Add(this.pbUpdateStudent);
            this.pnlStudentMenu.Controls.Add(this.pbDeleteSutudent);
            this.pnlStudentMenu.Controls.Add(this.pbAddTeacher);
            this.pnlStudentMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentMenu.Name = "pnlStudentMenu";
            this.pnlStudentMenu.Size = new System.Drawing.Size(897, 120);
            this.pnlStudentMenu.TabIndex = 1;
            // 
            // pbUpdateStudent
            // 
            this.pbUpdateStudent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbUpdateStudent.BackColor = System.Drawing.Color.Coral;
            this.pbUpdateStudent.Image = global::School.Properties.Resources.UpdateTeacherTial;
            this.pbUpdateStudent.Location = new System.Drawing.Point(682, 12);
            this.pbUpdateStudent.Name = "pbUpdateStudent";
            this.pbUpdateStudent.Size = new System.Drawing.Size(158, 99);
            this.pbUpdateStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdateStudent.TabIndex = 2;
            this.pbUpdateStudent.TabStop = false;
            this.pbUpdateStudent.Click += new System.EventHandler(this.pbUpdateTeacher_Click);
            // 
            // pbDeleteSutudent
            // 
            this.pbDeleteSutudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDeleteSutudent.BackColor = System.Drawing.Color.Coral;
            this.pbDeleteSutudent.Image = global::School.Properties.Resources.DeleteTeacherTial;
            this.pbDeleteSutudent.Location = new System.Drawing.Point(353, 12);
            this.pbDeleteSutudent.Name = "pbDeleteSutudent";
            this.pbDeleteSutudent.Size = new System.Drawing.Size(158, 99);
            this.pbDeleteSutudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeleteSutudent.TabIndex = 1;
            this.pbDeleteSutudent.TabStop = false;
            this.pbDeleteSutudent.Click += new System.EventHandler(this.pbDeleteSutudent_Click);
            // 
            // pbAddTeacher
            // 
            this.pbAddTeacher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbAddTeacher.BackColor = System.Drawing.Color.Coral;
            this.pbAddTeacher.Image = global::School.Properties.Resources.AddTeacherTial;
            this.pbAddTeacher.Location = new System.Drawing.Point(12, 15);
            this.pbAddTeacher.Name = "pbAddTeacher";
            this.pbAddTeacher.Size = new System.Drawing.Size(158, 99);
            this.pbAddTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddTeacher.TabIndex = 0;
            this.pbAddTeacher.TabStop = false;
            this.pbAddTeacher.Click += new System.EventHandler(this.pbAddTeacher_Click_1);
            // 
            // pnlStudentSearch
            // 
            this.pnlStudentSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlStudentSearch.Controls.Add(this.btnRefresh);
            this.pnlStudentSearch.Controls.Add(this.cbFilter);
            this.pnlStudentSearch.Controls.Add(this.pbSearchbtn);
            this.pnlStudentSearch.Controls.Add(this.tbSearch);
            this.pnlStudentSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentSearch.Location = new System.Drawing.Point(0, 120);
            this.pnlStudentSearch.Name = "pnlStudentSearch";
            this.pnlStudentSearch.Size = new System.Drawing.Size(897, 65);
            this.pnlStudentSearch.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = global::School.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(31, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "First name",
            "Course name",
            "All Teachers"});
            this.cbFilter.Location = new System.Drawing.Point(645, 21);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(171, 21);
            this.cbFilter.TabIndex = 4;
            // 
            // pbSearchbtn
            // 
            this.pbSearchbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbSearchbtn.Image = global::School.Properties.Resources.imageedit_16_5363622926;
            this.pbSearchbtn.Location = new System.Drawing.Point(73, 17);
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
            this.tbSearch.Location = new System.Drawing.Point(115, 17);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(524, 30);
            this.tbSearch.TabIndex = 0;
            // 
            // pnlTeachers
            // 
            this.pnlTeachers.Controls.Add(this.teachersJoinCoursesResaultMetroGrid);
            this.pnlTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeachers.Location = new System.Drawing.Point(0, 185);
            this.pnlTeachers.Name = "pnlTeachers";
            this.pnlTeachers.Size = new System.Drawing.Size(897, 315);
            this.pnlTeachers.TabIndex = 3;
            // 
            // teachersJoinCoursesResaultMetroGrid
            // 
            this.teachersJoinCoursesResaultMetroGrid.AllowUserToResizeRows = false;
            this.teachersJoinCoursesResaultMetroGrid.AutoGenerateColumns = false;
            this.teachersJoinCoursesResaultMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.teachersJoinCoursesResaultMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.teachersJoinCoursesResaultMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teachersJoinCoursesResaultMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.teachersJoinCoursesResaultMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teachersJoinCoursesResaultMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teachersJoinCoursesResaultMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersJoinCoursesResaultMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teachersIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.teachersCoursesIdDataGridViewTextBoxColumn,
            this.coursesIdDataGridViewTextBoxColumn,
            this.coursesNameDataGridViewTextBoxColumn,
            this.coursesDescriptionDataGridViewTextBoxColumn});
            this.teachersJoinCoursesResaultMetroGrid.DataSource = this.teachersJoinCoursesResaultBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.teachersJoinCoursesResaultMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.teachersJoinCoursesResaultMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachersJoinCoursesResaultMetroGrid.EnableHeadersVisualStyles = false;
            this.teachersJoinCoursesResaultMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.teachersJoinCoursesResaultMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.teachersJoinCoursesResaultMetroGrid.Location = new System.Drawing.Point(0, 0);
            this.teachersJoinCoursesResaultMetroGrid.Name = "teachersJoinCoursesResaultMetroGrid";
            this.teachersJoinCoursesResaultMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teachersJoinCoursesResaultMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.teachersJoinCoursesResaultMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.teachersJoinCoursesResaultMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teachersJoinCoursesResaultMetroGrid.Size = new System.Drawing.Size(897, 315);
            this.teachersJoinCoursesResaultMetroGrid.TabIndex = 0;
            this.teachersJoinCoursesResaultMetroGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.teachersJoinCoursesResaultMetroGrid_MouseDoubleClick);
            // 
            // teachersJoinCoursesResaultBindingSource1
            // 
            this.teachersJoinCoursesResaultBindingSource1.DataSource = typeof(SchoolModel.TeachersJoinCoursesResault);
            // 
            // teachersIdDataGridViewTextBoxColumn
            // 
            this.teachersIdDataGridViewTextBoxColumn.DataPropertyName = "TeachersId";
            this.teachersIdDataGridViewTextBoxColumn.HeaderText = "TeachersId";
            this.teachersIdDataGridViewTextBoxColumn.Name = "teachersIdDataGridViewTextBoxColumn";
            this.teachersIdDataGridViewTextBoxColumn.Width = 84;
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
            // teachersCoursesIdDataGridViewTextBoxColumn
            // 
            this.teachersCoursesIdDataGridViewTextBoxColumn.DataPropertyName = "TeachersCoursesId";
            this.teachersCoursesIdDataGridViewTextBoxColumn.HeaderText = "TeachersCoursesId";
            this.teachersCoursesIdDataGridViewTextBoxColumn.Name = "teachersCoursesIdDataGridViewTextBoxColumn";
            this.teachersCoursesIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursesIdDataGridViewTextBoxColumn
            // 
            this.coursesIdDataGridViewTextBoxColumn.DataPropertyName = "CoursesId";
            this.coursesIdDataGridViewTextBoxColumn.HeaderText = "CoursesId";
            this.coursesIdDataGridViewTextBoxColumn.Name = "coursesIdDataGridViewTextBoxColumn";
            this.coursesIdDataGridViewTextBoxColumn.Width = 81;
            // 
            // coursesNameDataGridViewTextBoxColumn
            // 
            this.coursesNameDataGridViewTextBoxColumn.DataPropertyName = "CoursesName";
            this.coursesNameDataGridViewTextBoxColumn.HeaderText = "CoursesName";
            this.coursesNameDataGridViewTextBoxColumn.Name = "coursesNameDataGridViewTextBoxColumn";
            // 
            // coursesDescriptionDataGridViewTextBoxColumn
            // 
            this.coursesDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CoursesDescription";
            this.coursesDescriptionDataGridViewTextBoxColumn.HeaderText = "CoursesDescription";
            this.coursesDescriptionDataGridViewTextBoxColumn.Name = "coursesDescriptionDataGridViewTextBoxColumn";
            this.coursesDescriptionDataGridViewTextBoxColumn.Width = 130;
            // 
            // frmTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 500);
            this.Controls.Add(this.pnlTeachers);
            this.Controls.Add(this.pnlStudentSearch);
            this.Controls.Add(this.pnlStudentMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeachers";
            this.Text = "frmTeachers";
            this.pnlStudentMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSutudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTeacher)).EndInit();
            this.pnlStudentSearch.ResumeLayout(false);
            this.pnlStudentSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            this.pnlTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teachersJoinCoursesResaultMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersJoinCoursesResaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersJoinCoursesResaultBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentMenu;
        private System.Windows.Forms.PictureBox pbUpdateStudent;
        private System.Windows.Forms.PictureBox pbDeleteSutudent;
        private System.Windows.Forms.PictureBox pbAddTeacher;
        private System.Windows.Forms.Panel pnlStudentSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pnlTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource teachersJoinCoursesResaultBindingSource;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private MetroFramework.Controls.MetroGrid teachersJoinCoursesResaultMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersCoursesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teachersJoinCoursesResaultBindingSource1;
    }
}