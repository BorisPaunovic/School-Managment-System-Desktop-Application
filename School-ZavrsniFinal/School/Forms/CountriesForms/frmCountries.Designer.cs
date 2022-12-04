
namespace School.Forms.CountriesForms
{
    partial class frmCountries
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
            this.pnlCountryMenu = new System.Windows.Forms.Panel();
            this.pbUpdateCountry = new System.Windows.Forms.PictureBox();
            this.pbDeleteCountry = new System.Windows.Forms.PictureBox();
            this.pbAddCountry = new System.Windows.Forms.PictureBox();
            this.pnlCountrySearch = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pbSearchbtn = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlCountryList = new System.Windows.Forms.Panel();
            this.countriesMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.countriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSO3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlCountryMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCountry)).BeginInit();
            this.pnlCountrySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).BeginInit();
            this.pnlCountryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCountryMenu
            // 
            this.pnlCountryMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCountryMenu.Controls.Add(this.pbUpdateCountry);
            this.pnlCountryMenu.Controls.Add(this.pbDeleteCountry);
            this.pnlCountryMenu.Controls.Add(this.pbAddCountry);
            this.pnlCountryMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCountryMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlCountryMenu.Name = "pnlCountryMenu";
            this.pnlCountryMenu.Size = new System.Drawing.Size(981, 120);
            this.pnlCountryMenu.TabIndex = 1;
            this.pnlCountryMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCountryMenu_Paint);
            // 
            // pbUpdateCountry
            // 
            this.pbUpdateCountry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbUpdateCountry.BackColor = System.Drawing.Color.Coral;
            this.pbUpdateCountry.Image = global::School.Properties.Resources.update_country;
            this.pbUpdateCountry.Location = new System.Drawing.Point(766, 12);
            this.pbUpdateCountry.Name = "pbUpdateCountry";
            this.pbUpdateCountry.Size = new System.Drawing.Size(158, 99);
            this.pbUpdateCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdateCountry.TabIndex = 2;
            this.pbUpdateCountry.TabStop = false;
            this.pbUpdateCountry.Click += new System.EventHandler(this.pbUpdateCountry_Click);
            // 
            // pbDeleteCountry
            // 
            this.pbDeleteCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDeleteCountry.BackColor = System.Drawing.Color.Coral;
            this.pbDeleteCountry.Image = global::School.Properties.Resources.delete_country;
            this.pbDeleteCountry.Location = new System.Drawing.Point(395, 12);
            this.pbDeleteCountry.Name = "pbDeleteCountry";
            this.pbDeleteCountry.Size = new System.Drawing.Size(158, 99);
            this.pbDeleteCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeleteCountry.TabIndex = 1;
            this.pbDeleteCountry.TabStop = false;
            this.pbDeleteCountry.Click += new System.EventHandler(this.pbDeleteCountry_Click);
            // 
            // pbAddCountry
            // 
            this.pbAddCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbAddCountry.BackColor = System.Drawing.Color.Coral;
            this.pbAddCountry.Image = global::School.Properties.Resources.addCountry;
            this.pbAddCountry.Location = new System.Drawing.Point(12, 12);
            this.pbAddCountry.Name = "pbAddCountry";
            this.pbAddCountry.Size = new System.Drawing.Size(158, 99);
            this.pbAddCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddCountry.TabIndex = 0;
            this.pbAddCountry.TabStop = false;
            this.pbAddCountry.Click += new System.EventHandler(this.pbAddCountry_Click);
            // 
            // pnlCountrySearch
            // 
            this.pnlCountrySearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCountrySearch.Controls.Add(this.button1);
            this.pnlCountrySearch.Controls.Add(this.cbFilter);
            this.pnlCountrySearch.Controls.Add(this.pbSearchbtn);
            this.pnlCountrySearch.Controls.Add(this.tbSearch);
            this.pnlCountrySearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCountrySearch.Location = new System.Drawing.Point(0, 120);
            this.pnlCountrySearch.Name = "pnlCountrySearch";
            this.pnlCountrySearch.Size = new System.Drawing.Size(981, 65);
            this.pnlCountrySearch.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::School.Properties.Resources.Refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(36, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
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
            "Country name",
            "ISO",
            "All Countries"});
            this.cbFilter.Location = new System.Drawing.Point(736, 21);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(171, 21);
            this.cbFilter.TabIndex = 4;
            // 
            // pbSearchbtn
            // 
            this.pbSearchbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbSearchbtn.Image = global::School.Properties.Resources.imageedit_16_5363622926;
            this.pbSearchbtn.Location = new System.Drawing.Point(80, 17);
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
            this.tbSearch.Location = new System.Drawing.Point(122, 17);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(608, 30);
            this.tbSearch.TabIndex = 0;
            // 
            // pnlCountryList
            // 
            this.pnlCountryList.BackColor = System.Drawing.Color.White;
            this.pnlCountryList.Controls.Add(this.countriesMetroGrid);
            this.pnlCountryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCountryList.Location = new System.Drawing.Point(0, 185);
            this.pnlCountryList.Name = "pnlCountryList";
            this.pnlCountryList.Size = new System.Drawing.Size(981, 490);
            this.pnlCountryList.TabIndex = 3;
            // 
            // countriesMetroGrid
            // 
            this.countriesMetroGrid.AllowUserToResizeRows = false;
            this.countriesMetroGrid.AutoGenerateColumns = false;
            this.countriesMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.countriesMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.countriesMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countriesMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.countriesMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.countriesMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.countriesMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countriesMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countriesIDDataGridViewTextBoxColumn,
            this.iSODataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn,
            this.phoneCodeDataGridViewTextBoxColumn,
            this.iSO3DataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.countriesMetroGrid.DataSource = this.countriesBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.countriesMetroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.countriesMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countriesMetroGrid.EnableHeadersVisualStyles = false;
            this.countriesMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.countriesMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.countriesMetroGrid.Location = new System.Drawing.Point(0, 0);
            this.countriesMetroGrid.Name = "countriesMetroGrid";
            this.countriesMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.countriesMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.countriesMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.countriesMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.countriesMetroGrid.Size = new System.Drawing.Size(981, 490);
            this.countriesMetroGrid.TabIndex = 0;
            // 
            // countriesBindingSource1
            // 
            this.countriesBindingSource1.DataSource = typeof(SchoolModel.Countries);
            // 
            // countriesIDDataGridViewTextBoxColumn
            // 
            this.countriesIDDataGridViewTextBoxColumn.DataPropertyName = "CountriesID";
            this.countriesIDDataGridViewTextBoxColumn.HeaderText = "CountriesID";
            this.countriesIDDataGridViewTextBoxColumn.Name = "countriesIDDataGridViewTextBoxColumn";
            // 
            // iSODataGridViewTextBoxColumn
            // 
            this.iSODataGridViewTextBoxColumn.DataPropertyName = "ISO";
            this.iSODataGridViewTextBoxColumn.HeaderText = "ISO";
            this.iSODataGridViewTextBoxColumn.Name = "iSODataGridViewTextBoxColumn";
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            // 
            // phoneCodeDataGridViewTextBoxColumn
            // 
            this.phoneCodeDataGridViewTextBoxColumn.DataPropertyName = "PhoneCode";
            this.phoneCodeDataGridViewTextBoxColumn.HeaderText = "PhoneCode";
            this.phoneCodeDataGridViewTextBoxColumn.Name = "phoneCodeDataGridViewTextBoxColumn";
            // 
            // iSO3DataGridViewTextBoxColumn
            // 
            this.iSO3DataGridViewTextBoxColumn.DataPropertyName = "ISO3";
            this.iSO3DataGridViewTextBoxColumn.HeaderText = "ISO3";
            this.iSO3DataGridViewTextBoxColumn.Name = "iSO3DataGridViewTextBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            // 
            // frmCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 675);
            this.Controls.Add(this.pnlCountryList);
            this.Controls.Add(this.pnlCountrySearch);
            this.Controls.Add(this.pnlCountryMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCountries";
            this.Text = "frmCountries";
            this.pnlCountryMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddCountry)).EndInit();
            this.pnlCountrySearch.ResumeLayout(false);
            this.pnlCountrySearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchbtn)).EndInit();
            this.pnlCountryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countriesMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCountryMenu;
        private System.Windows.Forms.PictureBox pbUpdateCountry;
        private System.Windows.Forms.PictureBox pbDeleteCountry;
        private System.Windows.Forms.PictureBox pbAddCountry;
        private System.Windows.Forms.Panel pnlCountrySearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.PictureBox pbSearchbtn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pnlCountryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private System.Windows.Forms.BindingSource countriesBindingSource1;
        private MetroFramework.Controls.MetroGrid countriesMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn countriesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSO3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
    }
}