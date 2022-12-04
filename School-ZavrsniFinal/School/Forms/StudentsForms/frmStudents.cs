using SchoolBL;
using SchoolModel;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms
{
    public partial class frmStudents : Form
    {

        private bool _studentIsUpdated ; 
        private string _filter;
        StudentsBL studentBL = new StudentsBL();
        StudentsResault StudentsResault = new StudentsResault();
        List<StudentsResault> studentsResaults = new List<StudentsResault>();
     
        public frmStudents()
        {
            InitializeComponent();
            LoadUStudents();
            studentsResaultBindingSource.DataSource = StudentsResault;
            LoadUStudents();
            Init();
           




        }

        private void Init()
        {
              studentsResaultMetroGrid.Columns[0].Visible = false;
            studentsResaultMetroGrid.Columns[1].HeaderText = " Name";
            studentsResaultMetroGrid.Columns[2].HeaderText = "Last name";
            studentsResaultMetroGrid.Columns[5].HeaderText = "Date of birth";
            studentsResaultMetroGrid.Columns[7].HeaderText = "Course name";
            studentsResaultMetroGrid.Columns[9].HeaderText = "Start date";
            studentsResaultMetroGrid.Columns[10].HeaderText = "Course description";
            studentsResaultMetroGrid.Columns[11].HeaderText = "Country";
            studentsResaultMetroGrid.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadUStudents()
        {
            studentsResaultBindingSource.DataSource = StudentsResault;
            studentsResaults = studentBL.SelectAllUsers();
            studentsResaultMetroGrid.DataSource = studentBL.SelectAllUsers();
        }

      
        public StudentsResault SelectKorisnikFromDataGridView()
        {
            StudentsResault korisnik = new StudentsResault();
            try 
            {
              korisnik = studentsResaultMetroGrid.SelectedRows[0].DataBoundItem as StudentsResault;
            }
            catch
            {
                
            }

           
           
            return korisnik;
       
        }
        
        

        
        private void pbSearchbtn_Click(object sender, EventArgs e)
        {
            studentsResaults = studentBL.SelectAllUsers();


            switch(cbFilter.SelectedIndex)
            {
                case 0:
                    _filter = tbSearch.Text;
                    studentsResaultMetroGrid.DataSource = studentBL.FilterByStudentName(studentsResaults, _filter);
                    break;
                case 1:
                    _filter = tbSearch.Text;
                    studentsResaultMetroGrid.DataSource = studentBL.FilterByCourseName(studentsResaults, _filter);
                    break;
                case 2:
                    LoadUStudents();
                    break;

            }








        }

        private void pbDeleteSutudent_Click(object sender, EventArgs e)
        {
          
            if (studentsResaults.Count() > 0)
            {
                DeleteStudent();
            }
            else
            {
                MessageBox.Show("Student list is empty");
            }
           
          
           
        }

        private void DeleteStudent()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete Student", "Delete Student?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool StudentIsDeleted = studentBL.DeleteStudent(SelectKorisnikFromDataGridView().StudentsID);
               
                if (StudentIsDeleted == true)
                {

                    MessageBox.Show("Student is deleted");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            LoadUStudents();
        }

        private void pbUpdateStudent_Click(object sender, EventArgs e)
        {
            OpenStudentsUpdate();

        }

        public void OpenStudentsUpdate()
        {

            bool IsOpen = false;
            if (studentsResaults.Count == 0)
            {
                MessageBox.Show("Subject list is empty");

            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Text == "frmUpdateStudent")
                    {
                        IsOpen = true;
                        form.BringToFront();
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    frmUpdateStudent studentsupdate = new frmUpdateStudent();
                    studentsupdate.Student = SelectKorisnikFromDataGridView();
                    studentsupdate.ShowDialog();
                    studentsupdate.BringToFront();
                    _studentIsUpdated = studentsupdate.studentIsUpdated;
                    LoadUStudents();
                    RefreshStudentDGV();


                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddStudent();
            
        }

        private void AddStudent()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmAddStudent")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddStudent studentsupdate = new frmAddStudent();
                studentsupdate.ShowDialog();
                LoadUStudents();
                studentsupdate.BringToFront();

            }
        }

        public void RefreshStudentDGV()
        {
            
            if(_studentIsUpdated==true)
            {
                MessageBox.Show("Reloading student list");
                LoadUStudents();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUStudents();
        }

        private void pnlStudentSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentsResaultMetroGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(SelectKorisnikFromDataGridView().CoursesDescription);
        }

        
    }
}
