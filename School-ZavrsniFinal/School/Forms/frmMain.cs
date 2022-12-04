using School.Forms.CountriesForms;
using School.Forms.CoursesForms;
using School.Forms.SubjectsForms;
using School.Forms.TeachersForms;
using School.Forms.UsersForms;
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

namespace School.Forms
{
    public partial class frmMain : Form
    {
        private bool _isAdministritor;
        public bool IsAdministrator
        {
            set { _isAdministritor = value; }
        }

        public frmMain()
        {
            InitializeComponent();
            Init();
            

        }

        private void Init()
        {
            OpenTeachers();
            OpenCourses();
            OpenCountries();
            OpenStudents();
            OpenSubjects();
            OpenDashboard();


        }

        private void pbDashboard_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }
        public void OpenDashboard()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmDashboard")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmDashboard dashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlForms.Controls.Add(dashboard);
                dashboard.Show();
                dashboard.BringToFront();
            }
        }

        private void pbCourses_Click(object sender, EventArgs e)
        {
            OpenCourses();





        }

        private void pbStudents_Click(object sender, EventArgs e)
        {
            OpenStudents();
        }
        public void OpenStudents()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if(form.Text=="frmStudents")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }    
            if(IsOpen==false)
            {
                frmStudents students = new frmStudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlForms.Controls.Add(students);
                students.Show();
                students.BringToFront();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pbCountries_Click(object sender, EventArgs e)
        {
            OpenCountries();


        }
        public void OpenCountries()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmCountries")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmCountries frmCountries = new frmCountries() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlForms.Controls.Add(frmCountries);
                frmCountries.Show();
                frmCountries.BringToFront();
            }
        }
        public void OpenUsers()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmUsers")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmUsers frmCountries = new frmUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlForms.Controls.Add(frmCountries);
                frmCountries.Show();
                frmCountries.BringToFront();
            }
        }
        public void OpenCourses()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmCourses")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmCourses frmCountries = new frmCourses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlForms.Controls.Add(frmCountries);
                frmCountries.Show();
                frmCountries.BringToFront();
            }
        }

        private void pbSubjects_Click(object sender, EventArgs e)
        {
            OpenSubjects();
        }
        public void OpenSubjects()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmSubjects")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmSubjects frmSubject = new frmSubjects() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlForms.Controls.Add(frmSubject);
                frmSubject.Show();
                frmSubject.BringToFront();
            }
        }

        private void pbTeachers_Click(object sender, EventArgs e)
        {
            OpenTeachers();
        }
        public void OpenTeachers()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmTeachers")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmTeachers frmTeachers = new frmTeachers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.pnlForms.Controls.Add(frmTeachers);
                frmTeachers.Show();
                frmTeachers.BringToFront();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(_isAdministritor==false)
            {
             
                  pbUsers.Enabled = false;
                pbUsers.Image = null;
               
            }
           
           
        }

        private void pbUsers_Click(object sender, EventArgs e)
        {
            OpenUsers();
          
        }
    }
}
