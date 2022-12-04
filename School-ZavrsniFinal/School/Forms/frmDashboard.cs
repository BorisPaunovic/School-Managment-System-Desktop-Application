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
    public partial class frmDashboard : Form
    {
       
        public frmDashboard()
        {
            InitializeComponent();

        }

        private void pbstudentsTial_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "frmStudents")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
           
        }
        public void OpenStudents()
        {
            
        }

        private void pbTeacherTial_Click(object sender, EventArgs e)
        {

        }

        private void pbTeachersTial_Click(object sender, EventArgs e)
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
        }

        private void pbCountries_Click(object sender, EventArgs e)
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
        }

        private void pbCourseTial_Click(object sender, EventArgs e)
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
        }

        private void pbSubjects_Click(object sender, EventArgs e)
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
        }
    }
}
