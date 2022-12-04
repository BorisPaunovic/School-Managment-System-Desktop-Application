
namespace School.Forms
{
    partial class frmAddCountries
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
            System.Windows.Forms.Label countryNameLabel;
            System.Windows.Forms.Label phoneCodeLabel;
            System.Windows.Forms.Label iSOLabel;
            System.Windows.Forms.Label iSO3Label;
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iSO3TextBox = new System.Windows.Forms.TextBox();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            this.iSOTextBox = new System.Windows.Forms.TextBox();
            countryNameLabel = new System.Windows.Forms.Label();
            phoneCodeLabel = new System.Windows.Forms.Label();
            iSOLabel = new System.Windows.Forms.Label();
            iSO3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // countryNameLabel
            // 
            countryNameLabel.AutoSize = true;
            countryNameLabel.BackColor = System.Drawing.Color.White;
            countryNameLabel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryNameLabel.Location = new System.Drawing.Point(49, 142);
            countryNameLabel.Name = "countryNameLabel";
            countryNameLabel.Size = new System.Drawing.Size(89, 13);
            countryNameLabel.TabIndex = 3;
            countryNameLabel.Text = "Country Name:";
            // 
            // phoneCodeLabel
            // 
            phoneCodeLabel.AutoSize = true;
            phoneCodeLabel.BackColor = System.Drawing.Color.White;
            phoneCodeLabel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneCodeLabel.Location = new System.Drawing.Point(49, 277);
            phoneCodeLabel.Name = "phoneCodeLabel";
            phoneCodeLabel.Size = new System.Drawing.Size(77, 13);
            phoneCodeLabel.TabIndex = 9;
            phoneCodeLabel.Text = "Phone Code:";
            // 
            // iSOLabel
            // 
            iSOLabel.AutoSize = true;
            iSOLabel.BackColor = System.Drawing.Color.White;
            iSOLabel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSOLabel.Location = new System.Drawing.Point(49, 187);
            iSOLabel.Name = "iSOLabel";
            iSOLabel.Size = new System.Drawing.Size(30, 13);
            iSOLabel.TabIndex = 5;
            iSOLabel.Text = "ISO:";
            // 
            // iSO3Label
            // 
            iSO3Label.AutoSize = true;
            iSO3Label.BackColor = System.Drawing.Color.White;
            iSO3Label.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSO3Label.Location = new System.Drawing.Point(49, 232);
            iSO3Label.Name = "iSO3Label";
            iSO3Label.Size = new System.Drawing.Size(36, 13);
            iSO3Label.TabIndex = 7;
            iSO3Label.Text = "ISO3:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::School.Properties.Resources.TransparentHalfCircle;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblAddCountry);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.iSO3TextBox);
            this.panel1.Controls.Add(countryNameLabel);
            this.panel1.Controls.Add(this.phoneCodeTextBox);
            this.panel1.Controls.Add(this.countryNameTextBox);
            this.panel1.Controls.Add(phoneCodeLabel);
            this.panel1.Controls.Add(iSOLabel);
            this.panel1.Controls.Add(iSO3Label);
            this.panel1.Controls.Add(this.iSOTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 454);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblAddCountry.Font = new System.Drawing.Font("Palatino Linotype", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCountry.Location = new System.Drawing.Point(86, 30);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(195, 42);
            this.lblAddCountry.TabIndex = 12;
            this.lblAddCountry.Text = "Add Country";
            // 
            // button1
            // 
            this.button1.Image = global::School.Properties.Resources.Save;
            this.button1.Location = new System.Drawing.Point(106, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iSO3TextBox
            // 
            this.iSO3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "ISO3", true));
            this.iSO3TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSO3TextBox.Location = new System.Drawing.Point(52, 248);
            this.iSO3TextBox.Multiline = true;
            this.iSO3TextBox.Name = "iSO3TextBox";
            this.iSO3TextBox.Size = new System.Drawing.Size(252, 26);
            this.iSO3TextBox.TabIndex = 8;
            // 
            // countriesBindingSource
            // 
            
            // 
            // phoneCodeTextBox
            // 
            this.phoneCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "PhoneCode", true));
            this.phoneCodeTextBox.Location = new System.Drawing.Point(52, 293);
            this.phoneCodeTextBox.Multiline = true;
            this.phoneCodeTextBox.Name = "phoneCodeTextBox";
            this.phoneCodeTextBox.Size = new System.Drawing.Size(252, 26);
            this.phoneCodeTextBox.TabIndex = 10;
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "CountryName", true));
            this.countryNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryNameTextBox.Location = new System.Drawing.Point(52, 158);
            this.countryNameTextBox.Multiline = true;
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.countryNameTextBox.TabIndex = 4;
            // 
            // iSOTextBox
            // 
            this.iSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countriesBindingSource, "ISO", true));
            this.iSOTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSOTextBox.Location = new System.Drawing.Point(52, 203);
            this.iSOTextBox.Multiline = true;
            this.iSOTextBox.Name = "iSOTextBox";
            this.iSOTextBox.Size = new System.Drawing.Size(252, 26);
            this.iSOTextBox.TabIndex = 6;
            // 
            // frmAddCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 454);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddCountries";
            this.Text = "Add country";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource countriesBindingSource;
        private System.Windows.Forms.TextBox countryNameTextBox;
        private System.Windows.Forms.TextBox iSOTextBox;
        private System.Windows.Forms.TextBox iSO3TextBox;
        private System.Windows.Forms.TextBox phoneCodeTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAddCountry;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}