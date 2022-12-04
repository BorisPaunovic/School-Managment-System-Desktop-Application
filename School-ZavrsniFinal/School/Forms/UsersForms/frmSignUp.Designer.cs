
namespace School.Forms
{
    partial class frmSignUp
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
            this.pnlMovement = new System.Windows.Forms.Panel();
            this.pnlDecor = new System.Windows.Forms.Panel();
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.userPasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.userEmailTextBox1 = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.administratorCheckBox = new System.Windows.Forms.CheckBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDecor.SuspendLayout();
            this.pnlSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMovement
            // 
            this.pnlMovement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMovement.Location = new System.Drawing.Point(0, 0);
            this.pnlMovement.Name = "pnlMovement";
            this.pnlMovement.Size = new System.Drawing.Size(565, 11);
            this.pnlMovement.TabIndex = 0;
            this.pnlMovement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMovement_MouseDown);
            this.pnlMovement.MouseEnter += new System.EventHandler(this.pnlMovement_MouseEnter);
            this.pnlMovement.MouseLeave += new System.EventHandler(this.pnlMovement_MouseLeave);
            this.pnlMovement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMovement_MouseMove);
            this.pnlMovement.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMovement_MouseUp);
            // 
            // pnlDecor
            // 
            this.pnlDecor.Controls.Add(this.pictureBox1);
            this.pnlDecor.Location = new System.Drawing.Point(0, 12);
            this.pnlDecor.Name = "pnlDecor";
            this.pnlDecor.Size = new System.Drawing.Size(308, 515);
            this.pnlDecor.TabIndex = 1;
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.BackColor = System.Drawing.Color.White;
            this.pnlSignIn.Controls.Add(this.administratorCheckBox);
            this.pnlSignIn.Controls.Add(this.pbEmail);
            this.pnlSignIn.Controls.Add(this.pictureBox6);
            this.pnlSignIn.Controls.Add(this.pbPassword);
            this.pnlSignIn.Controls.Add(this.lblClose);
            this.pnlSignIn.Controls.Add(this.btnSignUp);
            this.pnlSignIn.Controls.Add(this.userPasswordTextBox1);
            this.pnlSignIn.Controls.Add(this.tbRepeatPassword);
            this.pnlSignIn.Controls.Add(this.lblSignIn);
            this.pnlSignIn.Controls.Add(this.pictureBox5);
            this.pnlSignIn.Controls.Add(this.userEmailTextBox1);
            this.pnlSignIn.Controls.Add(this.pictureBox4);
            this.pnlSignIn.Controls.Add(this.userPasswordTextBox);
            this.pnlSignIn.Controls.Add(this.pictureBox3);
            this.pnlSignIn.Controls.Add(this.userNameTextBox1);
            this.pnlSignIn.Controls.Add(this.pictureBox2);
            this.pnlSignIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSignIn.Location = new System.Drawing.Point(297, 11);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(268, 516);
            this.pnlSignIn.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(233, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 16);
            this.lblClose.TabIndex = 17;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // userPasswordTextBox1
            // 
            this.userPasswordTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userPasswordTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserPassword", true));
            this.userPasswordTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordTextBox1.Location = new System.Drawing.Point(43, 247);
            this.userPasswordTextBox1.Multiline = true;
            this.userPasswordTextBox1.Name = "userPasswordTextBox1";
            this.userPasswordTextBox1.Size = new System.Drawing.Size(200, 29);
            this.userPasswordTextBox1.TabIndex = 11;
            this.userPasswordTextBox1.Click += new System.EventHandler(this.userPasswordTextBox1_Click);
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRepeatPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepeatPassword.Location = new System.Drawing.Point(43, 302);
            this.tbRepeatPassword.Multiline = true;
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(200, 29);
            this.tbRepeatPassword.TabIndex = 10;
            this.tbRepeatPassword.Click += new System.EventHandler(this.tbRepeatPassword_Click);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(8, 29);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(240, 47);
            this.lblSignIn.TabIndex = 9;
            this.lblSignIn.Text = "Please Sign In";
            // 
            // userEmailTextBox1
            // 
            this.userEmailTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userEmailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserEmail", true));
            this.userEmailTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailTextBox1.Location = new System.Drawing.Point(43, 183);
            this.userEmailTextBox1.Multiline = true;
            this.userEmailTextBox1.Name = "userEmailTextBox1";
            this.userEmailTextBox1.Size = new System.Drawing.Size(200, 29);
            this.userEmailTextBox1.TabIndex = 4;
            this.userEmailTextBox1.Click += new System.EventHandler(this.userEmailTextBox1_Click);
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserPassword", true));
            this.userPasswordTextBox.Location = new System.Drawing.Point(84, 256);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.userPasswordTextBox.TabIndex = 8;
            // 
            // userNameTextBox1
            // 
            this.userNameTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.userNameTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox1.Location = new System.Drawing.Point(31, 130);
            this.userNameTextBox1.Multiline = true;
            this.userNameTextBox1.Name = "userNameTextBox1";
            this.userNameTextBox1.Size = new System.Drawing.Size(200, 33);
            this.userNameTextBox1.TabIndex = 6;
            this.userNameTextBox1.Click += new System.EventHandler(this.userNameTextBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // administratorCheckBox
            // 
            this.administratorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "Administrator", true));
            this.administratorCheckBox.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorCheckBox.Location = new System.Drawing.Point(31, 349);
            this.administratorCheckBox.Name = "administratorCheckBox";
            this.administratorCheckBox.Size = new System.Drawing.Size(104, 24);
            this.administratorCheckBox.TabIndex = 19;
            this.administratorCheckBox.Text = "Administrator";
            this.administratorCheckBox.UseVisualStyleBackColor = true;
            // 
            // usersBindingSource
            // 
            
            // 
            // pbEmail
            // 
            this.pbEmail.Image = global::School.Properties.Resources.Email;
            this.pbEmail.Location = new System.Drawing.Point(18, 192);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(23, 20);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmail.TabIndex = 1;
            this.pbEmail.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::School.Properties.Resources.PasswordPic;
            this.pictureBox6.Location = new System.Drawing.Point(18, 307);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::School.Properties.Resources.PasswordPic;
            this.pbPassword.Location = new System.Drawing.Point(18, 252);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(19, 24);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 1;
            this.pbPassword.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.Image = global::School.Properties.Resources.SignUp;
            this.btnSignUp.Location = new System.Drawing.Point(56, 379);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(153, 33);
            this.btnSignUp.TabIndex = 16;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::School.Properties.Resources.TextboxBackground;
            this.pictureBox5.Location = new System.Drawing.Point(18, 291);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(225, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::School.Properties.Resources.TextboxBackground;
            this.pictureBox4.Location = new System.Drawing.Point(18, 236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "UserName", true));
            this.pictureBox3.Image = global::School.Properties.Resources.TextboxBackground;
            this.pictureBox3.Location = new System.Drawing.Point(18, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "UserEmail", true));
            this.pictureBox2.Image = global::School.Properties.Resources.TextboxBackground;
            this.pictureBox2.Location = new System.Drawing.Point(18, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School.Properties.Resources.TransparentHalfCircle1;
            this.pictureBox1.Location = new System.Drawing.Point(-44, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 618);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 527);
            this.Controls.Add(this.pnlSignIn);
            this.Controls.Add(this.pnlDecor);
            this.Controls.Add(this.pnlMovement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.pnlDecor.ResumeLayout(false);
            this.pnlSignIn.ResumeLayout(false);
            this.pnlSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMovement;
        private System.Windows.Forms.Panel pnlDecor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox userEmailTextBox1;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox1;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.TextBox userPasswordTextBox1;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.CheckBox administratorCheckBox;
    }
}