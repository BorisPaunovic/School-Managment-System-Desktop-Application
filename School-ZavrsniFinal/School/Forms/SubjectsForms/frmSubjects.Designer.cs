
namespace School.Forms.SubjectsForms
{
    partial class frmSubjects
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
            this.pnlCourseMenu = new System.Windows.Forms.Panel();
            this.pbUpdateCourse = new System.Windows.Forms.PictureBox();
            this.pbDeleteSubject = new System.Windows.Forms.PictureBox();
            this.pbAddCourse = new System.Windows.Forms.PictureBox();
            this.pnlCourseSearch = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlDatagridview = new System.Windows.Forms.Panel();
            this.subjectsMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlCourseMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).BeginInit();
            this.pnlCourseSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            this.pnlDatagridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCourseMenu
            // 
            this.pnlCourseMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCourseMenu.Controls.Add(this.pbUpdateCourse);
            this.pnlCourseMenu.Controls.Add(this.pbDeleteSubject);
            this.pnlCourseMenu.Controls.Add(this.pbAddCourse);
            this.pnlCourseMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCourseMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlCourseMenu.Name = "pnlCourseMenu";
            this.pnlCourseMenu.Size = new System.Drawing.Size(800, 120);
            this.pnlCourseMenu.TabIndex = 3;
            // 
            // pbUpdateCourse
            // 
            this.pbUpdateCourse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbUpdateCourse.BackColor = System.Drawing.Color.Coral;
            this.pbUpdateCourse.Image = global::School.Properties.Resources.UpdateSubject;
            this.pbUpdateCourse.Location = new System.Drawing.Point(630, 12);
            this.pbUpdateCourse.Name = "pbUpdateCourse";
            this.pbUpdateCourse.Size = new System.Drawing.Size(158, 99);
            this.pbUpdateCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdateCourse.TabIndex = 2;
            this.pbUpdateCourse.TabStop = false;
            this.pbUpdateCourse.Click += new System.EventHandler(this.pbUpdateCourse_Click);
            // 
            // pbDeleteSubject
            // 
            this.pbDeleteSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDeleteSubject.BackColor = System.Drawing.Color.Coral;
            this.pbDeleteSubject.Image = global::School.Properties.Resources.Delete_Subject;
            this.pbDeleteSubject.Location = new System.Drawing.Point(305, 12);
            this.pbDeleteSubject.Name = "pbDeleteSubject";
            this.pbDeleteSubject.Size = new System.Drawing.Size(158, 99);
            this.pbDeleteSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeleteSubject.TabIndex = 1;
            this.pbDeleteSubject.TabStop = false;
            this.pbDeleteSubject.Click += new System.EventHandler(this.pbDeleteSubject_Click);
            // 
            // pbAddCourse
            // 
            this.pbAddCourse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbAddCourse.BackColor = System.Drawing.Color.Coral;
            this.pbAddCourse.Image = global::School.Properties.Resources.AddSubjectPanel;
            this.pbAddCourse.Location = new System.Drawing.Point(12, 12);
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
            this.pnlCourseSearch.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::School.Properties.Resources.Refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(23, 17);
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
            "All subjects",
            "Subject name"});
            this.cbFilter.Location = new System.Drawing.Point(540, 21);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(171, 21);
            this.cbFilter.TabIndex = 4;
            // 
            // pbSearchbtn
            // 
            this.pbSearchbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbSearchbtn.Image = global::School.Properties.Resources.imageedit_16_5363622926;
            this.pbSearchbtn.Location = new System.Drawing.Point(65, 17);
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
            this.tbSearch.Location = new System.Drawing.Point(107, 17);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(427, 30);
            this.tbSearch.TabIndex = 0;
            // 
            // pnlDatagridview
            // 
            this.pnlDatagridview.Controls.Add(this.subjectsMetroGrid);
            this.pnlDatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatagridview.Location = new System.Drawing.Point(0, 185);
            this.pnlDatagridview.Name = "pnlDatagridview";
            this.pnlDatagridview.Size = new System.Drawing.Size(800, 293);
            this.pnlDatagridview.TabIndex = 5;
            // 
            // subjectsMetroGrid
            // 
            this.subjectsMetroGrid.AllowUserToResizeRows = false;
            this.subjectsMetroGrid.AutoGenerateColumns = false;
            this.subjectsMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subjectsMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subjectsMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectsMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.subjectsMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectsMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subjectsMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIdDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn,
            this.subjectDescriptionDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.subjectsMetroGrid.DataSource = this.subjectsBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subjectsMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.subjectsMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectsMetroGrid.EnableHeadersVisualStyles = false;
            this.subjectsMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subjectsMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subjectsMetroGrid.Location = new System.Drawing.Point(0, 0);
            this.subjectsMetroGrid.Name = "subjectsMetroGrid";
            this.subjectsMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectsMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.subjectsMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.subjectsMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsMetroGrid.Size = new System.Drawing.Size(800, 293);
            this.subjectsMetroGrid.TabIndex = 0;
            this.subjectsMetroGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.subjectsMetroGrid_MouseDoubleClick);
            // 
            // subjectsBindingSource1
            // 
            this.subjectsBindingSource1.DataSource = typeof(SchoolModel.Subjects);
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "SubjectId";
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            // 
            // subjectDescriptionDataGridViewTextBoxColumn
            // 
            this.subjectDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SubjectDescription";
            this.subjectDescriptionDataGridViewTextBoxColumn.HeaderText = "SubjectDescription";
            this.subjectDescriptionDataGridViewTextBoxColumn.Name = "subjectDescriptionDataGridViewTextBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            // 
            // frmSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.pnlDatagridview);
            this.Controls.Add(this.pnlCourseSearch);
            this.Controls.Add(this.pnlCourseMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubjects";
            this.Text = "frmSubjects";
            this.pnlCourseMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCourse)).EndInit();
            this.pnlCourseSearch.ResumeLayout(false);
            this.pnlCourseSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            this.pnlDatagridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCourseMenu;
        private System.Windows.Forms.PictureBox pbUpdateCourse;
        private System.Windows.Forms.PictureBox pbDeleteSubject;
        private System.Windows.Forms.PictureBox pbAddCourse;
        private System.Windows.Forms.Panel pnlCourseSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private System.Windows.Forms.Panel pnlDatagridview;
        private MetroFramework.Controls.MetroGrid subjectsMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource subjectsBindingSource1;
    }
}