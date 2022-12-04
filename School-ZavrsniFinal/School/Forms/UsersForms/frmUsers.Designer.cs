
namespace School.Forms.UsersForms
{
    partial class frmUsers
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
            this.pnlUsersMenu = new System.Windows.Forms.Panel();
            this.pnlUserSearch = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlUserList = new System.Windows.Forms.Panel();
            this.usersMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.pbAddUser = new System.Windows.Forms.PictureBox();
            this.pbUpdateUser = new System.Windows.Forms.PictureBox();
            this.pbDeleteSutudent = new System.Windows.Forms.PictureBox();
            this.pnlUsersMenu.SuspendLayout();
            this.pnlUserSearch.SuspendLayout();
            this.pnlUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSutudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsersMenu
            // 
            this.pnlUsersMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUsersMenu.Controls.Add(this.pbAddUser);
            this.pnlUsersMenu.Controls.Add(this.pbUpdateUser);
            this.pnlUsersMenu.Controls.Add(this.pbDeleteSutudent);
            this.pnlUsersMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsersMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlUsersMenu.Name = "pnlUsersMenu";
            this.pnlUsersMenu.Size = new System.Drawing.Size(800, 121);
            this.pnlUsersMenu.TabIndex = 1;
            this.pnlUsersMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlUserSearch
            // 
            this.pnlUserSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUserSearch.Controls.Add(this.btnRefresh);
            this.pnlUserSearch.Controls.Add(this.pbSearchbtn);
            this.pnlUserSearch.Controls.Add(this.cbFilter);
            this.pnlUserSearch.Controls.Add(this.tbSearch);
            this.pnlUserSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserSearch.Location = new System.Drawing.Point(0, 121);
            this.pnlUserSearch.Name = "pnlUserSearch";
            this.pnlUserSearch.Size = new System.Drawing.Size(800, 73);
            this.pnlUserSearch.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "All users",
            "User name"});
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All users",
            "UserName"});
            this.cbFilter.Location = new System.Drawing.Point(622, 25);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(171, 21);
            this.cbFilter.TabIndex = 8;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(92, 21);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(524, 30);
            this.tbSearch.TabIndex = 6;
            // 
            // pnlUserList
            // 
            this.pnlUserList.Controls.Add(this.usersMetroGrid);
            this.pnlUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserList.Location = new System.Drawing.Point(0, 194);
            this.pnlUserList.Name = "pnlUserList";
            this.pnlUserList.Size = new System.Drawing.Size(800, 389);
            this.pnlUserList.TabIndex = 3;
            // 
            // usersMetroGrid
            // 
            this.usersMetroGrid.AllowUserToResizeRows = false;
            this.usersMetroGrid.AutoGenerateColumns = false;
            this.usersMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usersMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.usersMetroGrid.DataSource = this.usersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersMetroGrid.EnableHeadersVisualStyles = false;
            this.usersMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usersMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersMetroGrid.Location = new System.Drawing.Point(0, 0);
            this.usersMetroGrid.Name = "usersMetroGrid";
            this.usersMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.usersMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersMetroGrid.Size = new System.Drawing.Size(800, 389);
            this.usersMetroGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UsersID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UsersID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserPassword";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserPassword";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserEmail";
            this.dataGridViewTextBoxColumn4.HeaderText = "UserEmail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Administrator";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Administrator";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // usersBindingSource
            // 
       
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImage = global::School.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(8, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 30);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pbSearchbtn
            // 
            this.pbSearchbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbSearchbtn.Image = global::School.Properties.Resources.imageedit_16_5363622926;
            this.pbSearchbtn.Location = new System.Drawing.Point(50, 20);
            this.pbSearchbtn.Name = "pbSearchbtn";
            this.pbSearchbtn.Size = new System.Drawing.Size(36, 30);
            this.pbSearchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchbtn.TabIndex = 7;
            this.pbSearchbtn.TabStop = false;
            this.pbSearchbtn.Click += new System.EventHandler(this.pbSearchbtn_Click);
            // 
            // pbAddUser
            // 
            this.pbAddUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbAddUser.BackColor = System.Drawing.Color.Coral;
            this.pbAddUser.Image = global::School.Properties.Resources.addUser;
            this.pbAddUser.Location = new System.Drawing.Point(50, 11);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Size = new System.Drawing.Size(158, 99);
            this.pbAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddUser.TabIndex = 4;
            this.pbAddUser.TabStop = false;
            this.pbAddUser.Click += new System.EventHandler(this.pbAddUser_Click);
            // 
            // pbUpdateUser
            // 
            this.pbUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbUpdateUser.BackColor = System.Drawing.Color.Coral;
            this.pbUpdateUser.Image = global::School.Properties.Resources.update_user;
            this.pbUpdateUser.Location = new System.Drawing.Point(574, 11);
            this.pbUpdateUser.Name = "pbUpdateUser";
            this.pbUpdateUser.Size = new System.Drawing.Size(158, 99);
            this.pbUpdateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdateUser.TabIndex = 3;
            this.pbUpdateUser.TabStop = false;
            this.pbUpdateUser.Click += new System.EventHandler(this.pbUpdateUser_Click);
            // 
            // pbDeleteSutudent
            // 
            this.pbDeleteSutudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDeleteSutudent.BackColor = System.Drawing.Color.Coral;
            this.pbDeleteSutudent.Image = global::School.Properties.Resources.DeleteUser;
            this.pbDeleteSutudent.Location = new System.Drawing.Point(321, 11);
            this.pbDeleteSutudent.Name = "pbDeleteSutudent";
            this.pbDeleteSutudent.Size = new System.Drawing.Size(158, 99);
            this.pbDeleteSutudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeleteSutudent.TabIndex = 2;
            this.pbDeleteSutudent.TabStop = false;
            this.pbDeleteSutudent.Click += new System.EventHandler(this.pbDeleteSutudent_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.pnlUserList);
            this.Controls.Add(this.pnlUserSearch);
            this.Controls.Add(this.pnlUsersMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.pnlUsersMenu.ResumeLayout(false);
            this.pnlUserSearch.ResumeLayout(false);
            this.pnlUserSearch.PerformLayout();
            this.pnlUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteSutudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Panel pnlUsersMenu;
        private System.Windows.Forms.Panel pnlUserSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbDeleteSutudent;
        private System.Windows.Forms.Panel pnlUserList;
        private MetroFramework.Controls.MetroGrid usersMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.PictureBox pbUpdateUser;
        private System.Windows.Forms.PictureBox pbAddUser;
    }
}