
namespace School
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.pnlDecor = new System.Windows.Forms.Panel();
            this.pbDecor = new System.Windows.Forms.PictureBox();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblNotAMember = new System.Windows.Forms.Label();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pnlMovement = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDecor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDecor)).BeginInit();
            this.pnlLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDecor
            // 
            this.pnlDecor.BackColor = System.Drawing.Color.White;
            this.pnlDecor.Controls.Add(this.pbDecor);
            this.pnlDecor.Location = new System.Drawing.Point(0, 12);
            this.pnlDecor.Name = "pnlDecor";
            this.pnlDecor.Size = new System.Drawing.Size(304, 432);
            this.pnlDecor.TabIndex = 1;
            // 
            // pbDecor
            // 
            this.pbDecor.Image = global::School.Properties.Resources.TransparentHalfCircle1;
            this.pbDecor.Location = new System.Drawing.Point(-162, -87);
            this.pbDecor.Name = "pbDecor";
            this.pbDecor.Size = new System.Drawing.Size(626, 621);
            this.pbDecor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDecor.TabIndex = 2;
            this.pbDecor.TabStop = false;
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.BackColor = System.Drawing.Color.White;
            this.pnlLogIn.Controls.Add(this.lblSignIn);
            this.pnlLogIn.Controls.Add(this.lblNotAMember);
            this.pnlLogIn.Controls.Add(this.pbLock);
            this.pnlLogIn.Controls.Add(this.userNameTextBox);
            this.pnlLogIn.Controls.Add(this.userPasswordTextBox);
            this.pnlLogIn.Controls.Add(this.lblClose);
            this.pnlLogIn.Controls.Add(this.lblLogIn);
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.pbUserName);
            this.pnlLogIn.Controls.Add(this.pbPassword);
            this.pnlLogIn.Location = new System.Drawing.Point(304, 12);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(243, 429);
            this.pnlLogIn.TabIndex = 2;
   
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.BackColor = System.Drawing.Color.White;
            this.lblSignIn.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSignIn.Location = new System.Drawing.Point(147, 323);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(57, 16);
            this.lblSignIn.TabIndex = 15;
            this.lblSignIn.Text = "Sign In";
            this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // lblNotAMember
            // 
            this.lblNotAMember.AutoSize = true;
            this.lblNotAMember.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAMember.Location = new System.Drawing.Point(35, 322);
            this.lblNotAMember.Name = "lblNotAMember";
            this.lblNotAMember.Size = new System.Drawing.Size(106, 16);
            this.lblNotAMember.TabIndex = 14;
            this.lblNotAMember.Text = "Not a member?";
            // 
            // pbLock
            // 
            this.pbLock.BackColor = System.Drawing.Color.Transparent;
            this.pbLock.Image = global::School.Properties.Resources.PasswordPic;
            this.pbLock.Location = new System.Drawing.Point(14, 224);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(20, 20);
            this.pbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLock.TabIndex = 2;
            this.pbLock.TabStop = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.userNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(17, 131);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(190, 29);
            this.userNameTextBox.TabIndex = 9;
            this.userNameTextBox.Click += new System.EventHandler(this.userNameTextBox_Click);
            // 
            // usersBindingSource
            // 
           
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserPassword", true));
            this.userPasswordTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordTextBox.Location = new System.Drawing.Point(40, 215);
            this.userPasswordTextBox.Multiline = true;
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(167, 29);
            this.userPasswordTextBox.TabIndex = 11;
            this.userPasswordTextBox.Click += new System.EventHandler(this.userPasswordTextBox_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(204, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 16);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(3, 25);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(230, 47);
            this.lblLogIn.TabIndex = 4;
            this.lblLogIn.Text = "Please Log In";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLogIn.Image = global::School.Properties.Resources.LogIn;
            this.btnLogIn.Location = new System.Drawing.Point(40, 286);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(157, 31);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pbUserName
            // 
            this.pbUserName.BackColor = System.Drawing.Color.Transparent;
            this.pbUserName.Image = global::School.Properties.Resources.TextboxBackground;
            this.pbUserName.Location = new System.Drawing.Point(6, 113);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(212, 67);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserName.TabIndex = 1;
            this.pbUserName.TabStop = false;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbPassword.Image = global::School.Properties.Resources.TextboxBackground;
            this.pbPassword.Location = new System.Drawing.Point(6, 197);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(212, 67);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 0;
            this.pbPassword.TabStop = false;
            // 
            // pnlMovement
            // 
            this.pnlMovement.BackColor = System.Drawing.Color.White;
            this.pnlMovement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMovement.Location = new System.Drawing.Point(0, 0);
            this.pnlMovement.Name = "pnlMovement";
            this.pnlMovement.Size = new System.Drawing.Size(547, 10);
            this.pnlMovement.TabIndex = 3;
            this.pnlMovement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMovement_MouseDown);
            this.pnlMovement.MouseEnter += new System.EventHandler(this.pnlMovement_MouseEnter);
            this.pnlMovement.MouseLeave += new System.EventHandler(this.pnlMovement_MouseLeave);
            this.pnlMovement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMovement_MouseMove);
            this.pnlMovement.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMovement_MouseUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 444);
            this.Controls.Add(this.pnlMovement);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.pnlDecor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlDecor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDecor)).EndInit();
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Panel pnlDecor;
        private System.Windows.Forms.PictureBox pbDecor;
        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlMovement;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblNotAMember;
    }
}

