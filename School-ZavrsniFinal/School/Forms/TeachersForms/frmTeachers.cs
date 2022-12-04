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

namespace School.Forms.TeachersForms
{
    public partial class frmTeachers : Form
    {
        private bool _isTeacherUpdated=false;
        private string _filter;
        List< TeachersJoinCoursesResault> teachersJoinCoursesResault = new List<TeachersJoinCoursesResault>();
        TeachersBL teachersBL = new TeachersBL();
        
        

        public frmTeachers()
        {
            InitializeComponent();
            teachersJoinCoursesResault = teachersBL.SelectAllTeachersJoinCourses();
            teachersJoinCoursesResaultMetroGrid.DataSource = teachersJoinCoursesResault;
            Init();
        }

        private void Init()
        {
            teachersJoinCoursesResaultMetroGrid.Columns[0].Visible = false;
            teachersJoinCoursesResaultMetroGrid.Columns[7].Visible = false;
            teachersJoinCoursesResaultMetroGrid.Columns[8].Visible = false;
           
            teachersJoinCoursesResaultMetroGrid.Columns[1].HeaderText = " Name";
            teachersJoinCoursesResaultMetroGrid.Columns[2].HeaderText = "Last name";
            teachersJoinCoursesResaultMetroGrid.Columns[5].HeaderText = "Date of birth";
            teachersJoinCoursesResaultMetroGrid.Columns[9].HeaderText = "Course";
            teachersJoinCoursesResaultMetroGrid.Columns[10].HeaderText = "Course description";
            teachersJoinCoursesResaultMetroGrid.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void pbSearchbtn_Click(object sender, EventArgs e)
        {
            teachersJoinCoursesResault = teachersBL.SelectAllTeachersJoinCourses();
          

            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    _filter = tbSearch.Text;
                    teachersJoinCoursesResaultMetroGrid.DataSource = teachersBL.FilterByTeacherName(teachersJoinCoursesResault, _filter);
                    break;
                case 1:
                    _filter = tbSearch.Text;
                    teachersJoinCoursesResaultMetroGrid.DataSource = teachersBL.FilterByCourseName(teachersJoinCoursesResault, _filter);
                    break;
                case 2:
                    LoadGrid();
                    break;

            }
        }

        private void LoadGrid()
        {
            teachersJoinCoursesResaultMetroGrid.DataSource = teachersBL.SelectAllTeachersJoinCourses();
            teachersJoinCoursesResault = teachersBL.SelectAllTeachersJoinCourses();
        }

        private void pbAddTeacher_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmAddTeachers")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddTeachers frmAddTeachers = new frmAddTeachers();
                frmAddTeachers.Show();
                frmAddTeachers.BringToFront();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void pbDeleteSutudent_Click(object sender, EventArgs e)
        {
           
            if (teachersJoinCoursesResault.Count() > 0)
            {
                DeleteCourse();
            }
            else
            {
                MessageBox.Show("Subject list is empty");
            }
           LoadGrid();
        }

        private void DeleteCourse()
        {
            if(SelectTeacherFromDataGridView().TeachersId==0)
            {
                MessageBox.Show("Teacher list is empty");
            }
            else 
            { 
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete Teacher", "Delete Teacher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool TeacherIsDeleted = teachersBL.DeleteTeacher(SelectTeacherFromDataGridView().TeachersId);
               
                
                if (TeacherIsDeleted == true)
                {

                    MessageBox.Show("Teacher is deleted");
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
            }
            LoadGrid();
        }

        private TeachersJoinCoursesResault SelectTeacherFromDataGridView()
        {


            TeachersJoinCoursesResault teacher = new TeachersJoinCoursesResault();
            try
            {
                teacher = teachersJoinCoursesResaultMetroGrid.SelectedRows[0].DataBoundItem as TeachersJoinCoursesResault;
            }
            catch
            {
                teacher.TeachersId = 0;

                teacher.FirstName = null;
                teacher.LastName = null;
                teacher.Email = null;
                teacher.Gender = null;
                teacher.DateOfBirth = default;
                teacher.Adress = null;
                teacher.TeachersCoursesId = 0;
                teacher.CoursesId = 0;
                teacher.CoursesName = null;
                teacher.CoursesDescription = null;
                   
            }
            return teacher;

        }

        private void pbUpdateTeacher_Click(object sender, EventArgs e)
        {
            UpdateTeacher();
        }
        public void UpdateTeacher()
        {
            if (teachersJoinCoursesResault.Count == 0)
            {
                MessageBox.Show("Teacher list is empty");

            }
            else
            {
                bool IsOpen = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmUpdateTeacher")
                    {
                        IsOpen = true;
                        form.BringToFront();
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    frmUpdateTeachers updateTeacher = new frmUpdateTeachers();
                    updateTeacher.TeacherFromGrid = SelectTeacherFromDataGridView();
                    updateTeacher.ShowDialog();
                    updateTeacher.BringToFront();
                    _isTeacherUpdated = updateTeacher.IsTeacherUpdated;

                    LoadGrid();

                }
            }
        }

        public void AddTeacher()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmAddTeachers")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddTeachers addTeacher = new frmAddTeachers();
                //updateTeacher.TeacherFromGrid = SelectTeacherFromDataGridView();
                addTeacher.ShowDialog();
                addTeacher.BringToFront();
              // _isTeacherUpdated = updateTeacher.IsTeacherUpdated;

                LoadGrid();

            }
        }
        private void pbAddTeacher_Click_1(object sender, EventArgs e)
        {
            AddTeacher();
        }

        private void teachersJoinCoursesResaultMetroGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(SelectTeacherFromDataGridView().CoursesDescription);
        }
    }
}
