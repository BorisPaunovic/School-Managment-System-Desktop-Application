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
    public partial class frmSubjects : Form
    {
        private string _filter;
        List<Subjects> subjectsList = new List<Subjects>();
        Subjects subjects = new Subjects();
        SubjectsBL subjectsBL = new SubjectsBL();
        public frmSubjects()
        {
            InitializeComponent();
           
            Init();
        }

        private void Init()
        {
            LoadSubjects();
            if(subjectsList.Count()>0)
            {
                subjectsMetroGrid.Columns[3].Visible = false;
                subjectsMetroGrid.Columns[0].Visible = false;
            subjectsMetroGrid.Columns[1].HeaderText = " Subject";
            subjectsMetroGrid.Columns[2].HeaderText = "Description";
            }
            
           // LoadSubjects();
            
    
        }
        public void LoadSubjects()
        {
            subjectsList.Clear();
            subjectsList = subjectsBL.SelectAllSubjects(); 
            subjectsMetroGrid.DataSource = subjectsList;
           
         

        }

        public Subjects SelectSubjectFromDataGridView()
        {
            Subjects subject = new Subjects();
            try 
            { 
            subject = subjectsMetroGrid.SelectedRows[0].DataBoundItem as Subjects;
            

            }
            catch
            {
                subject.SubjectId = 0;
                subject.SubjectName = null;
                subject.SubjectDescription = null;
            }
           return subject;
            
        }
        private void DeleteSubject()
        {
            if(SelectSubjectFromDataGridView().SubjectId==0)
            {
                MessageBox.Show("Subject list is empty");
            }
            else
            {

         
                 DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete Subject", "Delete Subject ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   bool StudentIsDeleted = subjectsBL.DeleteSubject(SelectSubjectFromDataGridView().SubjectId);

               
                   if (StudentIsDeleted == true)
                   {

                      MessageBox.Show("Subject is deleted");
                   }
                   else
                   {
                    MessageBox.Show("Ops something went wrong");
                   }
                }
                 else if (dialogResult == DialogResult.No)
                 {
                  //do something else
                 }
                LoadSubjects();
            }
        }
        private void pbDeleteSubject_Click(object sender, EventArgs e)
        {
            
            if (subjectsList.Count() > 0)
            {
                DeleteSubject();
            }
            else
            {
                MessageBox.Show("Subject list is empty");
            }
            LoadSubjects();

        }

        private void pbSearchbtn_Click(object sender, EventArgs e)
        {
            Filter();
        }
        public void Filter()
        {
             LoadSubjects();


            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    LoadSubjects();
                    break;
                case 1:
                    _filter = tbSearch.Text;
                    subjectsMetroGrid.DataSource = subjectsBL.FilterBySubjectName(subjectsList, _filter);
                    break;
               

            }
        }

        private void pbUpdateCourse_Click(object sender, EventArgs e)
        {
            UpdateSubject();
        }
        public void UpdateSubject()
        {
            bool IsOpen = false;
            if (subjectsList.Count == 0)
            {
                MessageBox.Show("Subject list is empty");

            }
            else
            {


                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmUpdateSubject")
                    {
                        IsOpen = true;
                        form.BringToFront();
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    frmUpdateSubjects updateSubject = new frmUpdateSubjects();
                    updateSubject.Subject = SelectSubjectFromDataGridView();
                    updateSubject.ShowDialog();
                    updateSubject.BringToFront();


                    LoadSubjects();

                }
            }
        }

        private void subjectsMetroGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Subjects Description = (Subjects)subjectsMetroGrid.SelectedRows[0].DataBoundItem;
            MessageBox.Show(Description.SubjectDescription);
        }

        private void pbAddCourse_Click(object sender, EventArgs e)
        {
            AddSubject();
        }
        public void AddSubject()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmAddSubject")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddSubjects frmaddSubjects = new frmAddSubjects();

                frmaddSubjects.ShowDialog();
                frmaddSubjects.BringToFront();


                LoadSubjects();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        
    }
}
