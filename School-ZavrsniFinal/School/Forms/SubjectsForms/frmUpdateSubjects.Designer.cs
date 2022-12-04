
namespace School.Forms.SubjectsForms
{
    partial class frmUpdateSubjects
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
            System.Windows.Forms.Label subjectNameLabel;
            System.Windows.Forms.Label subjectDescriptionLabel;
            this.pnlUpdateSubject = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.subjectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.pbUpdateSubject = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            subjectNameLabel = new System.Windows.Forms.Label();
            subjectDescriptionLabel = new System.Windows.Forms.Label();
            this.pnlUpdateSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectNameLabel
            // 
            subjectNameLabel.AutoSize = true;
            subjectNameLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectNameLabel.Location = new System.Drawing.Point(49, 119);
            subjectNameLabel.Name = "subjectNameLabel";
            subjectNameLabel.Size = new System.Drawing.Size(91, 15);
            subjectNameLabel.TabIndex = 5;
            subjectNameLabel.Text = "Subject Name:";
            // 
            // subjectDescriptionLabel
            // 
            subjectDescriptionLabel.AutoSize = true;
            subjectDescriptionLabel.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subjectDescriptionLabel.Location = new System.Drawing.Point(49, 166);
            subjectDescriptionLabel.Name = "subjectDescriptionLabel";
            subjectDescriptionLabel.Size = new System.Drawing.Size(123, 15);
            subjectDescriptionLabel.TabIndex = 1;
            subjectDescriptionLabel.Text = "Subject Description:";
            // 
            // pnlUpdateSubject
            // 
            this.pnlUpdateSubject.Controls.Add(this.label1);
            this.pnlUpdateSubject.Controls.Add(this.button1);
            this.pnlUpdateSubject.Controls.Add(subjectDescriptionLabel);
            this.pnlUpdateSubject.Controls.Add(this.subjectDescriptionTextBox);
            this.pnlUpdateSubject.Controls.Add(subjectNameLabel);
            this.pnlUpdateSubject.Controls.Add(this.subjectNameTextBox);
            this.pnlUpdateSubject.Controls.Add(this.pbUpdateSubject);
            this.pnlUpdateSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdateSubject.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateSubject.Name = "pnlUpdateSubject";
            this.pnlUpdateSubject.Size = new System.Drawing.Size(355, 454);
            this.pnlUpdateSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Update subject";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::School.Properties.Resources.Updatebtn;
            this.button1.Location = new System.Drawing.Point(96, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subjectDescriptionTextBox
            // 
            this.subjectDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "SubjectDescription", true));
            this.subjectDescriptionTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectDescriptionTextBox.Location = new System.Drawing.Point(52, 184);
            this.subjectDescriptionTextBox.Multiline = true;
            this.subjectDescriptionTextBox.Name = "subjectDescriptionTextBox";
            this.subjectDescriptionTextBox.Size = new System.Drawing.Size(252, 161);
            this.subjectDescriptionTextBox.TabIndex = 2;
            // 
            // subjectsBindingSource
            // 
        
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectsBindingSource, "SubjectName", true));
            this.subjectNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameTextBox.Location = new System.Drawing.Point(52, 137);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(252, 26);
            this.subjectNameTextBox.TabIndex = 6;
            // 
            // pbUpdateSubject
            // 
            this.pbUpdateSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUpdateSubject.Image = global::School.Properties.Resources.TransparentHalfCircle;
            this.pbUpdateSubject.Location = new System.Drawing.Point(0, 0);
            this.pbUpdateSubject.Name = "pbUpdateSubject";
            this.pbUpdateSubject.Size = new System.Drawing.Size(355, 454);
            this.pbUpdateSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUpdateSubject.TabIndex = 0;
            this.pbUpdateSubject.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUpdateSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 454);
            this.Controls.Add(this.pnlUpdateSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateSubjects";
            this.Text = "frmUpdateSubjects";
            this.Load += new System.EventHandler(this.frmUpdateSubjects_Load);
            this.pnlUpdateSubject.ResumeLayout(false);
            this.pnlUpdateSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdateSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdateSubject;
        private System.Windows.Forms.PictureBox pbUpdateSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox subjectDescriptionTextBox;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private System.Windows.Forms.TextBox subjectNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}