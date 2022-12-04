
namespace School.Forms.CoursesForms
{
    partial class frmCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCourseMenu = new System.Windows.Forms.Panel();
            this.pbUpdateCourse = new System.Windows.Forms.PictureBox();
            this.pbDeleteCourse = new System.Windows.Forms.PictureBox();
            this.pbAddCourse = new System.Windows.Forms.PictureBox();
            this.pnlCourseSearch = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlCourseList = new System.Windows.Forms.Panel();
            this.mgCCSS = new MetroFramework.Controls.MetroGrid();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCourseMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).BeginInit();
            this.pnlCourseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            this.pnlCourseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgCCSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCourseMenu
            // 
            this.pnlCourseMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCourseMenu.Controls.Add(this.pbUpdateCourse);
            this.pnlCourseMenu.Controls.Add(this.pbDeleteCourse);
            this.pnlCourseMenu.Controls.Add(this.pbAddCourse);
            this.pnlCourseMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCourseMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlCourseMenu.Name = "pnlCourseMenu";
            this.pnlCourseMenu.Size = new System.Drawing.Size(800, 120);
            this.pnlCourseMenu.TabIndex = 2;
            // 
            // pbUpdateCourse
            // 
            this.pbUpdateCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbUpdateCourse.BackColor = System.Drawing.Color.Coral;
            this.pbUpdateCourse.Image = global::School.Properties.Resources.update_Course;
            this.pbUpdateCourse.Location = new System.Drawing.Point(630, 12);
            this.pbUpdateCourse.Name = "pbUpdateCourse";
            this.pbUpdateCourse.Size = new System.Drawing.Size(158, 99);
            this.pbUpdateCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdateCourse.TabIndex = 2;
            this.pbUpdateCourse.TabStop = false;
            this.pbUpdateCourse.Click += new System.EventHandler(this.pbUpdateCourse_Click);
            // 
            // pbDeleteCourse
            // 
            this.pbDeleteCourse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDeleteCourse.BackColor = System.Drawing.Color.Coral;
            this.pbDeleteCourse.Image = global::School.Properties.Resources.deleteCoursePanel;
            this.pbDeleteCourse.Location = new System.Drawing.Point(305, 12);
            this.pbDeleteCourse.Name = "pbDeleteCourse";
            this.pbDeleteCourse.Size = new System.Drawing.Size(158, 99);
            this.pbDeleteCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeleteCourse.TabIndex = 1;
            this.pbDeleteCourse.TabStop = false;
            this.pbDeleteCourse.Click += new System.EventHandler(this.pbDeleteCourse_Click);
            // 
            // pbAddCourse
            // 
            this.pbAddCourse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbAddCourse.BackColor = System.Drawing.Color.Coral;
            this.pbAddCourse.Image = global::School.Properties.Resources.AddCoursePanel2;
            this.pbAddCourse.Location = new System.Drawing.Point(32, 12);
            this.pbAddCourse.Name = "pbAddCourse";
            this.pbAddCourse.Size = new System.Drawing.Size(158, 99);
            this.pbAddCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCourse.TabIndex = 0;
            this.pbAddCourse.TabStop = false;
            this.pbAddCourse.Click += new System.EventHandler(this.pbAddCourse_Click);
            // 
            // pnlCourseSearch
            // 
            this.pnlCourseSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCourseSearch.Controls.Add(this.button1);
            this.pnlCourseSearch.Controls.Add(this.cbFilter);
            this.pnlCourseSearch.Controls.Add(this.pbSearchbtn);
            this.pnlCourseSearch.Controls.Add(this.tbSearch);
            this.pnlCourseSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCourseSearch.Location = new System.Drawing.Point(0, 120);
            this.pnlCourseSearch.Name = "pnlCourseSearch";
            this.pnlCourseSearch.Size = new System.Drawing.Size(800, 65);
            this.pnlCourseSearch.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::School.Properties.Resources.Refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(48, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Course name",
            "All Courses"});
            this.cbFilter.Location = new System.Drawing.Point(565, 21);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(171, 21);
            this.cbFilter.TabIndex = 4;
            // 
            // pbSearchbtn
            // 
            this.pbSearchbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbSearchbtn.Image = global::School.Properties.Resources.imageedit_16_5363622926;
            this.pbSearchbtn.Location = new System.Drawing.Point(90, 17);
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
            this.tbSearch.Location = new System.Drawing.Point(132, 17);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(427, 30);
            this.tbSearch.TabIndex = 0;
            // 
            // pnlCourseList
            // 
            this.pnlCourseList.BackColor = System.Drawing.Color.White;
            this.pnlCourseList.Controls.Add(this.mgCCSS);
            this.pnlCourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCourseList.Location = new System.Drawing.Point(0, 185);
            this.pnlCourseList.Name = "pnlCourseList";
            this.pnlCourseList.Size = new System.Drawing.Size(800, 265);
            this.pnlCourseList.TabIndex = 4;
            // 
            // mgCCSS
            // 
            this.mgCCSS.AllowUserToResizeRows = false;
            this.mgCCSS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgCCSS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCCSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgCCSS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgCCSS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCCSS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgCCSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgCCSS.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgCCSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgCCSS.EnableHeadersVisualStyles = false;
            this.mgCCSS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgCCSS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCCSS.Location = new System.Drawing.Point(0, 0);
            this.mgCCSS.Name = "mgCCSS";
            this.mgCCSS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCCSS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgCCSS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgCCSS.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.mgCCSS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgCCSS.Size = new System.Drawing.Size(800, 265);
            this.mgCCSS.TabIndex = 0;
            this.mgCCSS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mgCCSS_MouseDoubleClick);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataSource = typeof(SchoolModel.Courses);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCourseList);
            this.Controls.Add(this.pnlCourseSearch);
            this.Controls.Add(this.pnlCourseMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCourses";
            this.Text = "frmCourses";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            this.pnlCourseMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).EndInit();
            this.pnlCourseSearch.ResumeLayout(false);
            this.pnlCourseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            this.pnlCourseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgCCSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCourseMenu;
        private System.Windows.Forms.PictureBox pbUpdateCourse;
        private System.Windows.Forms.PictureBox pbDeleteCourse;
        private System.Windows.Forms.PictureBox pbAddCourse;
        private System.Windows.Forms.Panel pnlCourseSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pnlCourseList;
        private MetroFramework.Controls.MetroGrid mgCCSS;
        private System.Windows.Forms.BindingSource coursesBindingSource;
    }
}