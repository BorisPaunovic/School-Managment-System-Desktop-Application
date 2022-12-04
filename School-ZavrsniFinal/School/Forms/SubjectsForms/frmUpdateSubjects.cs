using SchoolBL;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms.SubjectsForms
{
    public partial class frmUpdateSubjects : Form
    {
        private bool _IsStudentUpdated;
        private bool _IsSubjectNameValid = false;
        private bool _isSubjectDescriptionValid = false;
        private Subjects subjectrfomGrid;
        private bool _isEverythingValid = false;
        Subjects subjects = new Subjects();
        SubjectsBL subjectsBL = new SubjectsBL();
        
        public Subjects Subject
        {
            set { subjectrfomGrid = value; }
        }
        public frmUpdateSubjects()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
             subjectsBindingSource.DataSource = subjects;
           // subjectNameTextBox.Text = subjects.SubjectName;
            //subjectDescriptionTextBox.Text = subjects.SubjectDescription;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateEverything();
           UpdateSubjects();
            
        }

        private void UpdateSubjects()
        {
            if(_isEverythingValid==true)
            {
                _IsStudentUpdated = subjectsBL.UpdateSubject(subjects, subjectrfomGrid.SubjectId);
                if (_IsStudentUpdated == true)
                {
                    MessageBox.Show("Subject is updated");
                    this.Close();
                }
            }
        }

        private void frmUpdateSubjects_Load(object sender, EventArgs e)
        {
            subjects = subjectrfomGrid;
            subjectsBindingSource.DataSource = subjects;
        }
        public void ValidateEverything()
        {
            _IsSubjectNameValid = subjectsBL.ValidateSubjectName2(subjects);
            _isSubjectDescriptionValid = subjectsBL.ValidateSubjectDescription(subjects);
            if(_IsSubjectNameValid==true && _isSubjectDescriptionValid==true)
            {
                errorProvider1.Clear();
                _isEverythingValid = true;
                MessageBox.Show("Everything is valid");
            }
            if(_IsSubjectNameValid==false)
            {
                errorProvider1.SetError(subjectNameTextBox,"Subject name is not valid");

            }
            if (_isSubjectDescriptionValid == false)
            {
                errorProvider1.SetError(subjectDescriptionTextBox, "Subject description is not valid");

            }


        }
    }
}
