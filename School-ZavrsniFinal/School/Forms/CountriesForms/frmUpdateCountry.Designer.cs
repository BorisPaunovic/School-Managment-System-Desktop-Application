
namespace School.Forms.CountriesForms
{
    partial class frmUpdateCountry
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
            System.Windows.Forms.Label countryNameLabel1;
            System.Windows.Forms.Label iSOLabel1;
            System.Windows.Forms.Label iSO3Label1;
            System.Windows.Forms.Label phoneCodeLabel1;
            this.pnlUpdateCountry = new System.Windows.Forms.Panel();
            this.lblUpdateCountry = new System.Windows.Forms.Label();
            this.btnUpdateCountry = new System.Windows.Forms.Button();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.countryNameTextBox1 = new System.Windows.Forms.TextBox();
            this.iSOTextBox1 = new System.Windows.Forms.TextBox();
            this.iSO3TextBox1 = new System.Windows.Forms.TextBox();
            this.phoneCodeTextBox1 = new System.Windows.Forms.TextBox();
            countryNameLabel1 = new System.Windows.Forms.Label();
            iSOLabel1 = new System.Windows.Forms.Label();
            iSO3Label1 = new System.Windows.Forms.Label();
            phoneCodeLabel1 = new System.Windows.Forms.Label();
            this.pnlUpdateCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpdateCountry
            // 
            this.pnlUpdateCountry.BackgroundImage = global::School.Properties.Resources.TransparentHalfCircle;
            this.pnlUpdateCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUpdateCountry.Controls.Add(countryNameLabel1);
            this.pnlUpdateCountry.Controls.Add(this.countryNameTextBox1);
            this.pnlUpdateCountry.Controls.Add(iSOLabel1);
            this.pnlUpdateCountry.Controls.Add(this.iSOTextBox1);
            this.pnlUpdateCountry.Controls.Add(iSO3Label1);
            this.pnlUpdateCountry.Controls.Add(this.iSO3TextBox1);
            this.pnlUpdateCountry.Controls.Add(phoneCodeLabel1);
            this.pnlUpdateCountry.Controls.Add(this.phoneCodeTextBox1);
            this.pnlUpdateCountry.Controls.Add(this.lblUpdateCountry);
            this.pnlUpdateCountry.Controls.Add(this.btnUpdateCountry);
            this.pnlUpdateCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdateCountry.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateCountry.Name = "pnlUpdateCountry";
            this.pnlUpdateCountry.Size = new System.Drawing.Size(355, 454);
            this.pnlUpdateCountry.TabIndex = 0;
            this.pnlUpdateCountry.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpdateCountry_Paint);
            // 
            // lblUpdateCountry
            // 
            this.lblUpdateCountry.AutoSize = true;
            this.lblUpdateCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateCountry.Font = new System.Drawing.Font("Palatino Linotype", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCountry.Location = new System.Drawing.Point(70, 24);
            this.lblUpdateCountry.Name = "lblUpdateCountry";
            this.lblUpdateCountry.Size = new System.Drawing.Size(215, 37);
            this.lblUpdateCountry.TabIndex = 12;
            this.lblUpdateCountry.Text = "Update country";
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.Image = global::School.Properties.Resources.Updatebtn;
            this.btnUpdateCountry.Location = new System.Drawing.Point(102, 328);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(158, 28);
            this.btnUpdateCountry.TabIndex = 11;
            this.btnUpdateCountry.UseVisualStyleBackColor = true;
            this.btnUpdateCountry.Click += new System.EventHandler(this.btnUpdateCountry_Click);
            // 
            // countriesBindingSource
            // 
           
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // countryNameLabel1
            // 
            countryNameLabel1.AutoSize = true;
            countryNameLabel1.BackColor = System.Drawing.Color.White;
            countryNameLabel1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryNameLabel1.Location = new System.Drawing.Point(52, 86);
            countryNameLabel1.Name = "countryNameLabel1";
            countryNameLabel1.Size = new System.Drawing.Size(89, 13);
            countryNameLabel1.TabIndex = 14;
            countryNameLabel1.Text = "Country Name:";
            // 
            // countryNameTextBox1
            // 
            this.countryNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "CountryName", true));
            this.countryNameTextBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.countryNameTextBox1.Location = new System.Drawing.Point(55, 103);
            this.countryNameTextBox1.Name = "countryNameTextBox1";
            this.countryNameTextBox1.Size = new System.Drawing.Size(252, 26);
            this.countryNameTextBox1.TabIndex = 15;
            // 
            // iSOLabel1
            // 
            iSOLabel1.AutoSize = true;
            iSOLabel1.BackColor = System.Drawing.Color.White;
            iSOLabel1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSOLabel1.Location = new System.Drawing.Point(52, 132);
            iSOLabel1.Name = "iSOLabel1";
            iSOLabel1.Size = new System.Drawing.Size(30, 13);
            iSOLabel1.TabIndex = 16;
            iSOLabel1.Text = "ISO:";
            // 
            // iSOTextBox1
            // 
            this.iSOTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "ISO", true));
            this.iSOTextBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.iSOTextBox1.Location = new System.Drawing.Point(55, 149);
            this.iSOTextBox1.Name = "iSOTextBox1";
            this.iSOTextBox1.Size = new System.Drawing.Size(252, 26);
            this.iSOTextBox1.TabIndex = 17;
            // 
            // iSO3Label1
            // 
            iSO3Label1.AutoSize = true;
            iSO3Label1.BackColor = System.Drawing.Color.White;
            iSO3Label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSO3Label1.Location = new System.Drawing.Point(52, 178);
            iSO3Label1.Name = "iSO3Label1";
            iSO3Label1.Size = new System.Drawing.Size(36, 13);
            iSO3Label1.TabIndex = 18;
            iSO3Label1.Text = "ISO3:";
            // 
            // iSO3TextBox1
            // 
            this.iSO3TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "ISO3", true));
            this.iSO3TextBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.iSO3TextBox1.Location = new System.Drawing.Point(55, 195);
            this.iSO3TextBox1.Name = "iSO3TextBox1";
            this.iSO3TextBox1.Size = new System.Drawing.Size(252, 26);
            this.iSO3TextBox1.TabIndex = 19;
            // 
            // phoneCodeLabel1
            // 
            phoneCodeLabel1.AutoSize = true;
            phoneCodeLabel1.BackColor = System.Drawing.Color.White;
            phoneCodeLabel1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneCodeLabel1.Location = new System.Drawing.Point(52, 224);
            phoneCodeLabel1.Name = "phoneCodeLabel1";
            phoneCodeLabel1.Size = new System.Drawing.Size(77, 13);
            phoneCodeLabel1.TabIndex = 20;
            phoneCodeLabel1.Text = "Phone Code:";
            // 
            // phoneCodeTextBox1
            // 
            this.phoneCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "PhoneCode", true));
            this.phoneCodeTextBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.phoneCodeTextBox1.Location = new System.Drawing.Point(55, 241);
            this.phoneCodeTextBox1.Name = "phoneCodeTextBox1";
            this.phoneCodeTextBox1.Size = new System.Drawing.Size(252, 26);
            this.phoneCodeTextBox1.TabIndex = 21;
            // 
            // frmUpdateCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 454);
            this.Controls.Add(this.pnlUpdateCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateCountry";
            this.Text = "frmUpdateCountry";
            this.Load += new System.EventHandler(this.frmUpdateCountry_Load);
            this.pnlUpdateCountry.ResumeLayout(false);
            this.pnlUpdateCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdateCountry;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private System.Windows.Forms.Label lblUpdateCountry;
        private System.Windows.Forms.Button btnUpdateCountry;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox countryNameTextBox1;
        private System.Windows.Forms.TextBox iSOTextBox1;
        private System.Windows.Forms.TextBox iSO3TextBox1;
        private System.Windows.Forms.TextBox phoneCodeTextBox1;
    }
}