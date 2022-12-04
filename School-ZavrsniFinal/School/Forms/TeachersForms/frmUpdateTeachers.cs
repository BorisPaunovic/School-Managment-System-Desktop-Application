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
    public partial class frmUpdateTeachers : Form
    {
         private bool _isTeacherCourseUpdated = false;
        private bool _IsClbCoursesValid;
        private bool _isEverythingValid;
        private bool _isFirstNameIsValid;
        private bool _isLastNameIsValid;
        private bool _isEmailIsValid;
        private bool _isGenderIsValid;
        private bool _isAdressIsvalid;
        private bool _teacjerIsSaved;
        private int counter = 0;
        private bool _IsTeacherUpdated = false;
        private TeachersJoinCoursesResault _teacherFromGrid;
        TeachersCoursesBL teachersCoursesBL = new TeachersCoursesBL();
        CoursesBL coursesBL = new CoursesBL();
        List<Courses> coursesList = new List<Courses>();
        List<Courses> chosenCourses = new List<Courses>();
        Teachers teachers = new Teachers();
        TeachersBL teachersBL = new TeachersBL();
       
       

        public TeachersJoinCoursesResault TeacherFromGrid
        {
            set { _teacherFromGrid = value; }
        }
        public bool IsTeacherUpdated
        {
            get { return _IsTeacherUpdated; }
        }
        public frmUpdateTeachers()
        {
            InitializeComponent();
            teachersBindingSource.DataSource = teachers;
            coursesList = coursesBL.SelectAllCourses();
            LoadCourses();
        }
        private void LoadCourses()
        {
            foreach (var element in coursesList)
            {
                clbCourses.Items.Add(element.CoursesName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTeacher();
           
        }
        private void LoadChosenCourses()
        {
            foreach (var element in clbCourses.CheckedItems)
            {

                var a =
                    from sj in coursesList
                    where sj.CoursesName == element
                    select sj;
                foreach (var chosenElement in a)
                {
                    chosenCourses.Add(chosenElement);
                }
            }



        }
        public void UpdateTeacher()
        {
            ValidateEverything();
            if (_isEverythingValid == true)
            {
                errorProvider1.Clear();
             
                _IsTeacherUpdated = teachersBL.UpdateTeacher(teachers, _teacherFromGrid.TeachersId, cbGender.Text);
                
                LoadChosenCourses();
                foreach (var element in chosenCourses)
                {
                   
                    _isTeacherCourseUpdated = teachersCoursesBL.UpdateTeachersCourses(_teacherFromGrid.TeachersId, element.CoursesID,_teacherFromGrid.TeachersCoursesId);
                    if (_isTeacherCourseUpdated == true)
                    {
                        counter++;
                        MessageBox.Show($"Teacher course is saved {counter}");
                    }
                    else if (_isTeacherCourseUpdated == false)
                    {
                        MessageBox.Show("Ops something went wrong Teacher course is not saved");
                    }
                }
                if (_IsTeacherUpdated == true)
                {


                    MessageBox.Show("Teacher is saved");

                }
                else if (_IsTeacherUpdated == false)
                {
                    MessageBox.Show("Oops something went wrong");
                }
                counter = 0;
                chosenCourses.Clear();
                this.Close();
            }
        }


        private void ValidateEverything()
        {
          
                _isFirstNameIsValid = teachersBL.ValidateFirstName(teachers.FirstName);
                _isLastNameIsValid = teachersBL.ValidateLastName(teachers.LastName);
                _isEmailIsValid = teachersBL.ValidateEmail(teachers.Email);
                _isGenderIsValid = teachersBL.ValidateGender(cbGender.Text);
                _isAdressIsvalid = teachersBL.ValidateAdress(teachers.Adress);
                _IsClbCoursesValid = teachersBL.ValidateClbCourses(clbCourses);
                _isEverythingValid = teachersBL.ValidateEverything(_isFirstNameIsValid, _isLastNameIsValid, _isEmailIsValid, _isGenderIsValid, _isAdressIsvalid, _IsClbCoursesValid);




                if (_isFirstNameIsValid == false)
                {
                    errorProvider1.SetError(firstNameTextBox, "First name is not valid");
                }
                if (_isLastNameIsValid == false)
                {
                    errorProvider1.SetError(lastNameTextBox, "Last name is not valid");
                }
                if (_isEmailIsValid == false)
                {
                    errorProvider1.SetError(emailTextBox, "E-mail is not valid");
                }
                if (_isGenderIsValid == false)
                {
                    errorProvider1.SetError(cbGender, "Gender is not valid");
                }

                if (_isAdressIsvalid == false)
                {
                    errorProvider1.SetError(adressTextBox, "Adress is not valid");
                }


                if (_IsClbCoursesValid == false)
                {
                    errorProvider1.SetError(clbCourses, "Course is not valid");
                }
            
        }

        private void frmUpdateTeachers_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = _teacherFromGrid.FirstName;
            lastNameTextBox.Text = _teacherFromGrid.LastName;
            emailTextBox.Text = _teacherFromGrid.Email;
            adressTextBox.Text = _teacherFromGrid.Adress;
            dateOfBirthDateTimePicker.Value = _teacherFromGrid.DateOfBirth;
            cbGender.Text = _teacherFromGrid.Gender;
           
        }
    }
}
