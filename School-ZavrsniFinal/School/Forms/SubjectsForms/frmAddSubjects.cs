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

    public partial class frmAddSubjects : Form
    {
        private bool _isEverythingValid = false;
        bool _isNameValid = false;
        bool _isDescriptionValid = false;
        bool _IsSubjectSaved = false;
        SubjectsBL subjectsBL = new SubjectsBL();
        Subjects subjects = new Subjects();
        public frmAddSubjects()
        {
            InitializeComponent();
            subjectsBindingSource.DataSource = subjects;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateEverything();
            SaveSubject();

          
        }

        private void SaveSubject()
        {
            if(_isEverythingValid==true)
            {
                _IsSubjectSaved = subjectsBL.SaveSubject(subjects);
            }
            if (_IsSubjectSaved == true)
            {
                MessageBox.Show("Subject is saved");
            }
            else
            {
                MessageBox.Show("Ops something went wrong ");
            }
            
        }

        public void ValidateEverything()
        {
            _isNameValid = subjectsBL.ValidateSubjectName(subjects);
            _isDescriptionValid = subjectsBL.ValidateSubjectDescription(subjects);
            if(_isNameValid == false)
            {
                errorProvider1.SetError(subjectNameTextBox, "Subject name is not valid");
            }
            if (_isDescriptionValid == false)
            {
                errorProvider1.SetError(subjectNameTextBox, "Subject name is not valid");
            }
            if (_isNameValid==true && _isDescriptionValid==true)
            {
                errorProvider1.Clear();
                _isEverythingValid = true;
            }
            else
            {
                _isEverythingValid = false;
            }
        }
    }
}
