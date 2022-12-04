
namespace School.Forms.SubjectsForms
{
    partial class frmAddSubjects
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
            System.Windows.Forms.Label subjectDescriptionLabel;
            System.Windows.Forms.Label subjectNameLabel;
            this.pnlAddSubject = new System.Windows.Forms.Panel();
            this.lblAddSubject = new System.Windows.Forms.Label();
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.subjectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.pbAddSubject = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            subjectDescriptionLabel = new System.Windows.Forms.Label();
            subjectNameLabel = new System.Windows.Forms.Label();
            this.pnlAddSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectDescriptionLabel
            // 
            subjectDescriptionLabel.AutoSize = true;
            subjectDescriptionLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectDescriptionLabel.Location = new System.Drawing.Point(32, 147);
            subjectDescriptionLabel.Name = "subjectDescriptionLabel";
            subjectDescriptionLabel.Size = new System.Drawing.Size(123, 15);
            subjectDescriptionLabel.TabIndex = 1;
            subjectDescriptionLabel.Text = "Subject Description:";
            // 
            // subjectNameLabel
            // 
            subjectNameLabel.AutoSize = true;
            subjectNameLabel.BackColor = System.Drawing.Color.White;
            subjectNameLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectNameLabel.Location = new System.Drawing.Point(32, 102);
            subjectNameLabel.Name = "subjectNameLabel";
            subjectNameLabel.Size = new System.Drawing.Size(91, 15);
            subjectNameLabel.TabIndex = 5;
            subjectNameLabel.Text = "Subject Name:";
            // 
            // pnlAddSubject
            // 
            this.pnlAddSubject.Controls.Add(this.lblAddSubject);
            this.pnlAddSubject.Controls.Add(this.btnSaveSubject);
            this.pnlAddSubject.Controls.Add(subjectDescriptionLabel);
            this.pnlAddSubject.Controls.Add(this.subjectDescriptionTextBox);
            this.pnlAddSubject.Controls.Add(subjectNameLabel);
            this.pnlAddSubject.Controls.Add(this.subjectNameTextBox);
            this.pnlAddSubject.Controls.Add(this.pbAddSubject);
            this.pnlAddSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddSubject.Location = new System.Drawing.Point(0, 0);
            this.pnlAddSubject.Name = "pnlAddSubject";
            this.pnlAddSubject.Size = new System.Drawing.Size(355, 454);
            this.pnlAddSubject.TabIndex = 0;
            // 
            // lblAddSubject
            // 
            this.lblAddSubject.AutoSize = true;
            this.lblAddSubject.BackColor = System.Drawing.Color.White;
            this.lblAddSubject.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSubject.Location = new System.Drawing.Point(68, 9);
            this.lblAddSubject.Name = "lblAddSubject";
            this.lblAddSubject.Size = new System.Drawing.Size(185, 43);
            this.lblAddSubject.TabIndex = 8;
            this.lblAddSubject.Text = "Add subject";
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Image = global::School.Properties.Resources.Save;
            this.btnSaveSubject.Location = new System.Drawing.Point(86, 367);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(157, 31);
            this.btnSaveSubject.TabIndex = 7;
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            this.btnSaveSubject.Click += new System.EventHandler(this.button1_Click);
            // 
            // subjectDescriptionTextBox
            // 
            this.subjectDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "SubjectDescription", true));
            this.subjectDescriptionTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectDescriptionTextBox.Location = new System.Drawing.Point(35, 165);
            this.subjectDescriptionTextBox.Multiline = true;
            this.subjectDescriptionTextBox.Name = "subjectDescriptionTextBox";
            this.subjectDescriptionTextBox.Size = new System.Drawing.Size(252, 174);
            this.subjectDescriptionTextBox.TabIndex = 2;
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "SubjectName", true));
            this.subjectNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameTextBox.Location = new System.Drawing.Point(35, 118);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.subjectNameTextBox.TabIndex = 6;
            // 
            // pbAddSubject
            // 
            this.pbAddSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAddSubject.Image = global::School.Properties.Resources.TransparentHalfCircle;
            this.pbAddSubject.Location = new System.Drawing.Point(0, 0);
            this.pbAddSubject.Name = "pbAddSubject";
            this.pbAddSubject.Size = new System.Drawing.Size(355, 454);
            this.pbAddSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddSubject.TabIndex = 1;
            this.pbAddSubject.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // subjectsBindingSource
            // 
          
            // 
            // frmAddSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 454);
            this.Controls.Add(this.pnlAddSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddSubjects";
            this.Text = "frmAddSubjects";
            this.pnlAddSubject.ResumeLayout(false);
            this.pnlAddSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddSubject;
        private System.Windows.Forms.PictureBox pbAddSubject;
        private System.Windows.Forms.TextBox subjectDescriptionTextBox;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private System.Windows.Forms.TextBox subjectNameTextBox;
        private System.Windows.Forms.Label lblAddSubject;
        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}