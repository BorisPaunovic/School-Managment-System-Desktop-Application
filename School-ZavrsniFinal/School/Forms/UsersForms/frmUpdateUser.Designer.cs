
namespace School.Forms.UsersForms
{
    partial class frmUpdateUser
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
            System.Windows.Forms.Label userNameLabel;
            this.pnlUpdateUser = new System.Windows.Forms.Panel();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administratorCheckBox = new System.Windows.Forms.CheckBox();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            userNameLabel = new System.Windows.Forms.Label();
            this.pnlUpdateUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpdateUser
            // 
            this.pnlUpdateUser.BackgroundImage = global::School.Properties.Resources.TransparentHalfCircle;
            this.pnlUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUpdateUser.Controls.Add(this.button1);
            this.pnlUpdateUser.Controls.Add(userNameLabel);
            this.pnlUpdateUser.Controls.Add(this.userNameLabel1);
            this.pnlUpdateUser.Controls.Add(this.administratorCheckBox);
            this.pnlUpdateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdateUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateUser.Name = "pnlUpdateUser";
            this.pnlUpdateUser.Size = new System.Drawing.Size(297, 310);
            this.pnlUpdateUser.TabIndex = 0;
            // 
            // usersBindingSource
            // 
         
            // 
            // administratorCheckBox
            // 
            this.administratorCheckBox.BackColor = System.Drawing.Color.White;
            this.administratorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "Administrator", true));
            this.administratorCheckBox.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorCheckBox.Location = new System.Drawing.Point(101, 163);
            this.administratorCheckBox.Name = "administratorCheckBox";
            this.administratorCheckBox.Size = new System.Drawing.Size(103, 24);
            this.administratorCheckBox.TabIndex = 1;
            this.administratorCheckBox.Text = "Administrator";
            this.administratorCheckBox.UseVisualStyleBackColor = false;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = System.Drawing.Color.White;
            userNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(23, 25);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(262, 23);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "Change admin privileges ?";
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.BackColor = System.Drawing.Color.White;
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "UserName", true));
            this.userNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel1.Location = new System.Drawing.Point(96, 92);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.userNameLabel1.TabIndex = 2;
            this.userNameLabel1.Text = "label1";
            this.userNameLabel1.Click += new System.EventHandler(this.userNameLabel1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::School.Properties.Resources.Updatebtn;
            this.button1.Location = new System.Drawing.Point(75, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 28);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 310);
            this.Controls.Add(this.pnlUpdateUser);
            this.Name = "frmUpdateUser";
            this.Text = "frmUpdateUser";
            this.Load += new System.EventHandler(this.frmUpdateUser_Load);
            this.pnlUpdateUser.ResumeLayout(false);
            this.pnlUpdateUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdateUser;
        private System.Windows.Forms.CheckBox administratorCheckBox;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.Button button1;
    }
}