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
    public partial class frmAddTeachers : Form
    {
        private bool _teacjerIsSaved;
        private bool _IsTeacherCourseSaved = false;
        private bool _isEverythingValid;
        private bool _isFirstNameIsValid;
        private bool _isLastNameIsValid;
        private bool _isEmailIsValid;
        private bool _isGenderIsValid;
         private bool _isAdressIsvalid;
        private bool _IsClbCoursesValid;
        private int counter = 0;
        List<Courses> coursesList = new List<Courses>();
        List<Courses> chosenCourses = new List<Courses>();
        Teachers teacherByName = new Teachers();
        TeachersBL teachersBL = new TeachersBL();
        Teachers teachers = new Teachers();
        CoursesBL coursesBL = new CoursesBL();
        TeachersCoursesBL teachersCoursesBL = new TeachersCoursesBL();
        private bool _courseIsAdded;

        public frmAddTeachers()
        {
            InitializeComponent();
            teachersBindingSource.DataSource = teachers;
            coursesList = coursesBL.SelectAllCourses();
            LoadCourses();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            AddTeacher();
            if (_teacjerIsSaved==true)
            {
                MessageBox.Show("Teacher is saved");
            }

        }
        private void LoadCourses()
        {
            foreach (var element in coursesList)
            {
                clbCourses.Items.Add(element.CoursesName);
            }
        }
        public void ValidateEverything()
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

           
            if (_IsClbCoursesValid==false)
            {
                errorProvider1.SetError(clbCourses, "Course is not valid");
            }
        }
       
        public void AddTeacher()
        {
            ValidateEverything();
            if (_isEverythingValid == true)
            {
                errorProvider1.Clear();
                _teacjerIsSaved = teachersBL.SaveTeacher(teachers, cbGender.Text);

                teacherByName = teachersBL.SelectTeacherByName(teachers.FirstName);
                LoadChosenCourses();
                foreach (var element in chosenCourses)
                {
                    _IsTeacherCourseSaved = teachersCoursesBL.AddTeacherCourset(teacherByName.TeachersId, element.CoursesID);
                    if (_IsTeacherCourseSaved == true)
                    {
                        counter++;
                        MessageBox.Show($"Teacher course is saved {counter}");
                    }
                    else if (_IsTeacherCourseSaved == false)
                    {
                        MessageBox.Show("Ops something went wrong ");
                    }
                }
                if (_teacjerIsSaved == true)
                {

                   
                    MessageBox.Show("Teacher is saved");
                   
                }
                else if (_teacjerIsSaved == false)
                {
                    MessageBox.Show("Oops something went wrong");
                }
                counter = 0;
                chosenCourses.Clear();
            }
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

        private void pbAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse();
        }
        public void AddCourse()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmAddCourses")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddCourses addCourse = new frmAddCourses();
                addCourse.ShowDialog();
                addCourse.BringToFront();
                _courseIsAdded = addCourse.CourseIsAdded;
                if (_courseIsAdded == true)
                {
                   
                    MessageBox.Show("Course is sucsessfuly added");
                }



            }
        }
    }
    
}
