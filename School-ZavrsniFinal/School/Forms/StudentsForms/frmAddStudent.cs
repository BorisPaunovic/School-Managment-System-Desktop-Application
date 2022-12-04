using Dapper;
using SchoolBL;
using SchoolModel;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms
{
    public partial class frmAddStudent : Form
    {
        private int counter = 0;
        Students studentByName = new Students();
        private bool _courseIsAdded = false;
       private bool  _IsClbCoursesValid= false;
        bool StudentCourseIsAdded = false;
        bool LastNameIsValid=false;
        bool FirstNameIsValid = false;
        bool EmailIsValid = false;
        bool GenderIsValid = false;
        bool CountryIsValid = false;
        bool AdressIsvalid = false;
        bool _everythingIsValid = false;
        bool StudentIsAdded = false;
        Students students = new Students();
        StudentsBL studentBL = new StudentsBL();
        Countries countriesId = new Countries();
        List<Countries> countries = new List<Countries>();
        List<Courses> chosenCourses = new List<Courses>();
        CountriesBL countriesBL = new CountriesBL();
        Courses coursesId = new Courses();
        List<Courses> coursesList = new List<Courses>();
        CoursesBL coursesBL = new CoursesBL();
        StudentCoursesBL studentCoursesBL = new StudentCoursesBL();
        private bool _isEverythingValid;
        private bool _IsStudentCourseSaved;

        public frmAddStudent()
        {
            InitializeComponent();
            studentsBindingSource.DataSource = students;
            countries = countriesBL.SelectAllCountryes();
            coursesList = coursesBL.SelectAllCourses();
            Init();
           
          
           
        }

        private void Init()
        {
        
            LoadCountries();
            LoadCourses();
           
        }   
                
        private void LoadCountries()
        {
            foreach(var element in countries)
            {
                cbCountries.Items.Add(element.CountryName);
            }
        }
        private void LoadCourses()
        {

            
            foreach (var element in coursesList)
            {
                clbCourses.Items.Add(element.CoursesName);
            }
        }
        private void RefreshCourses()
        {
           
            clbCourses.Items.Clear();
            coursesList = coursesBL.SelectAllCourses();
            foreach (var element in coursesList)
            {
                clbCourses.Items.Add(element.CoursesName);
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
           
            countriesId= countriesBL.SelectCountryByID(cbCountries.Text);
           AddStudent();
            
          
           

        }
      
        private void LoadChosenCourses()
        {
            foreach (var element in clbCourses.CheckedItems)
            {

                var a =
                    from sj in coursesList
                    where sj.CoursesName == element.ToString()
                    select sj;
                foreach (var chosenElement in a)
                {
                    chosenCourses.Add(chosenElement);
                }
            }



        }



        public void AddStudent()
        {
            ValidateEverything();
            if (_isEverythingValid == true)
            {
                LoadChosenCourses();
                errorProvider1.Clear();
               
                StudentIsAdded = studentBL.SaveStudent(students, countriesId.CountriesID, cbGender.Text);
                studentByName = studentBL.SelectStudentByName(students.FirstName);

               
             
                foreach (var element in chosenCourses)
                {
                    _IsStudentCourseSaved = studentCoursesBL.AddStudentCourse(studentBL.SelectLastStudent().StudentsID, element.CoursesID, dtpStartDate.Value);
                    if (_IsStudentCourseSaved == true)
                    {
                        counter++;
                        MessageBox.Show($"Student course is saved {counter}");
                    }
                    else if (_IsStudentCourseSaved == false)
                    {
                        MessageBox.Show("Ops something went wrong Student course is not saved");
                    }
                }
                if (StudentIsAdded == true)
                {


                    MessageBox.Show("Teacher is saved");

                }
                else if (StudentIsAdded == false)
                {
                    MessageBox.Show("Oops something went wrong student is not added");
                }
                counter = 0;
                chosenCourses.Clear();
                ResetAddStudent();
            }
        }


       
       

        private void ValidateEverything()
        {
            FirstNameIsValid =studentBL.ValidateFirstName(students.FirstName);
            LastNameIsValid = studentBL.ValidateLastName(students.LastName);
            EmailIsValid = studentBL.ValidateEmail(students.Email);
            GenderIsValid = studentBL.ValidateGender(cbGender.Text);
            CountryIsValid = studentBL.ValidateCountry(cbCountries.Text);
            AdressIsvalid = studentBL.ValidateAdress(students.Adress);
            _IsClbCoursesValid = studentBL.ValidateClbCourses(clbCourses);
            _isEverythingValid = studentBL.ValidateEverything(FirstNameIsValid, LastNameIsValid, EmailIsValid, GenderIsValid, CountryIsValid, AdressIsvalid); ;

            if (FirstNameIsValid==false)
            {
                errorProvider1.SetError(firstNameTextBox, "First name is not valid");
            }
            if (LastNameIsValid == false)
            {
                errorProvider1.SetError(lastNameTextBox, "Last name is not valid");
            }
            if (EmailIsValid == false)
            {
                errorProvider1.SetError(emailTextBox, "E-mail is not valid");
            }
            if (GenderIsValid == false)
            {
                errorProvider1.SetError(cbGender, "Gender is not valid");
            }
            if (CountryIsValid == false)
            {
                errorProvider1.SetError(cbCountries, "Country is not valid");
            }
            if (AdressIsvalid == false)
            {
                errorProvider1.SetError(adressTextBox, "Adress is not valid");
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

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCountries();
        }
        public void ResetAddStudent()
        {
            
            adressTextBox.Text = "";
            dateOfBirthDateTimePicker.Value = DateTime.Today;
            emailTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            cbGender.SelectedIndex = -1;
            cbCountries.SelectedIndex = -1;
            
            dtpStartDate.Value = DateTime.Today;
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
                if(_courseIsAdded==true)
                {
                    RefreshCourses();
                    MessageBox.Show("Course is sucsessfuly added");
                }



            }
        }

        private void pbAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse();
        }

       
    }
}



            
            
       
        



        

    

    

           

             
           
       

        

       

        

      
