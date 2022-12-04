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
    public partial class frmUpdateStudent : Form 
    {
        
        private int _courseIdFromCb;
         private bool _studentCourseIsUpdated = false;
        private bool _lastNameIsValid = false;
        private bool _firstNameIsValid = false;
        private bool _emailIsValid = false;
        private bool _genderIsValid = false;
        private bool _countryIsValid = false;
        private bool _adressIsvalid = false;
        private bool _everythingIsValid = false;
        private bool _classPassed = false;
        private bool _studentIsUpdated = false;
        frmStudents frmStudents = new frmStudents();
        Countries countries = new Countries();
        CountriesBL countriesBL = new CountriesBL();
        List<Countries> countriesList = new List<Countries>();
        List<Courses> coursesList = new List<Courses>();
        StudentsBL studentBL = new StudentsBL();
        Courses coursesId = new Courses();
        CoursesBL coursesBL = new CoursesBL();
       
      
       
      //  Countries countriesId = new Countries();
        private StudentsResault _student;
        public StudentsResault Student
        {
            set { _student = value; }
        }
        public bool studentIsUpdated
        {
            get { return _studentIsUpdated; }
        }

        public bool _courseIsAdded { get; set; }

        Students students = new Students();
        StudentsBL studentsBL = new StudentsBL();
       
       
        public frmUpdateStudent()
        {
            InitializeComponent();
            Init();
           






        }

        private void Init()
        {
            studentsBindingSource.DataSource = students;
            countriesList = countriesBL.SelectAllCountryes();
            coursesList = coursesBL.SelectAllCourses();
            LoadCountries();
            LoadCourses();
        }

        private void LoadCountries()
        {
            foreach (var element in countriesList)
            {
                cbCountries.Items.Add(element.CountryName);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //  countriesId = countriesBL.SelectCountryByID(cbCountries.Text);
            _courseIdFromCb = coursesBL.SelectCourseByName(cbCourses.Text).CoursesID;
            countries = countriesBL.SelectCountryByID(cbCountries.Text);
            coursesId = coursesBL.SelectCourseByName(cbCourses.Text);
   
            IsClassPassed();
            UpdateStudent();
          
        }
        private void ValidateStudent()
        {
            _firstNameIsValid = studentBL.ValidateFirstName(students.FirstName);
            _lastNameIsValid = studentBL.ValidateLastName(students.LastName);
            _emailIsValid = studentBL.ValidateEmail(students.Email);
            _genderIsValid = studentBL.ValidateGender(cbGender.Text);
            _countryIsValid = studentBL.ValidateCountry(cbCountries.Text);
            _adressIsvalid = studentBL.ValidateAdress(students.Adress);
            

            if (_firstNameIsValid == false)
            {
                errorProvider1.SetError(firstNameTextBox, "First name is not valid");
            }
            if (_lastNameIsValid == false)
            {
                errorProvider1.SetError(lastNameTextBox, "Last name is not valid");
            }
            if (_emailIsValid == false)
            {
                errorProvider1.SetError(emailTextBox, "E-mail is not valid");
            }
            if (_genderIsValid == false)
            {
                errorProvider1.SetError(cbGender, "Gender is not valid");
            }
            if (_countryIsValid == false)
            {
                errorProvider1.SetError(cbCountries, "Country is not valid");
            }
            if (_adressIsvalid == false)
            {
                errorProvider1.SetError(adressTextBox, "Adress is not valid");
            }
           



        }
        public void UpdateStudent()
        {

            ValidateStudent();

            _everythingIsValid = studentBL.ValidateEverything(_firstNameIsValid, _lastNameIsValid, _emailIsValid, _genderIsValid, _countryIsValid, _adressIsvalid);

            if (_everythingIsValid == true)
            {
                errorProvider1.Clear();
           
                _studentIsUpdated = studentsBL.UpdateStudent(students, _student.StudentsID, cbGender.Text, countries.CountriesID);
               
                _studentCourseIsUpdated = StudentCoursesDAL.UpdateStudentCourse(_student.StudentsID,_courseIdFromCb,_classPassed,dtpStartDate.Value,coursesId.CoursesID);
                lblUpdateStudent.Text = _student.StudentsID.ToString();
                
                MessageBox.Show("Everything is valid");
                if (_everythingIsValid==true)
                {

                    MessageBox.Show("Student is updated");
                    MessageBox.Show("StudentCourse is updated");

                    this.Close();

                }



            }
            else if (_everythingIsValid == false)
            {
                MessageBox.Show("Oops something went wronggg");
            }
          
            
            

        }

        private void pbAddCountry_Click(object sender, EventArgs e)
        {
            AddCountry();
        }
        public void AddCountry()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmAddCountries")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddCountries addCountry = new frmAddCountries();
                addCountry.Show();
                
                addCountry.BringToFront();

            }
        }
        public void LoadCourses()
        {
            foreach (var element in coursesList)
            {
                cbCourses.Items.Add(element.CoursesName);
            }
        }
        public void IsClassPassed()
        {
            if(cbPassed.Text=="Passed")
            {
                _classPassed = true;
            }
            else
            {
                _classPassed = false;
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
        private void frmUpdateStudent_Load(object sender, EventArgs e)
        {
            adressTextBox.Text = _student.Adress;
            firstNameTextBox.Text = _student.FirstName;
            lastNameTextBox.Text = _student.LastName;
            emailTextBox.Text = _student.Email;
            dateOfBirthDateTimePicker.Value = _student.DateOfBirth;
            cbGender.Text = _student.Gender;
            cbCountries.Text = _student.CountryName;
            cbCourses.Text = _student.CoursesName;
           
            if (_student.Passed==true)
            {
                cbPassed.Text = "Passed";
            }
            else if(_student.Passed==false)
            {
                cbPassed.Text = "Failed";
            }
          


        }
        
    }
}
