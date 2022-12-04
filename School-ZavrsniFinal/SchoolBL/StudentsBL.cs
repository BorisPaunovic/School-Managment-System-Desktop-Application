using SchoolModel;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBL
{
    public class StudentsBL
    {
        public  Students SelectStudentByName(string StudentName)
        {
            Students students = new Students();
            students = StudentsDAL.SelectStudentByName(StudentName);
            return students;
        }
            public  Students SelectLastStudent()
        {
            Students student = new Students();
            student = StudentsDAL.SelectLastStudent();
            return student;


        }
        public List<StudentsResault> SelectAllUsers()
        {
            List<StudentsResault> usersList = new List<StudentsResault>();
            usersList = StudentsDAL.SelectAllUsers();
            return usersList;


        }
        public bool DeleteStudent(int StudentID)
        {
            bool StudentIsDeleted = StudentsDAL.DeleteStudent(StudentID);
            return StudentIsDeleted;
        }
        public List<StudentsResault> FilterByStudentName(List<StudentsResault> korisniks, string TextBox)
        {

            List<StudentsResault> korisniks1 = new List<StudentsResault>();
            foreach (var element in korisniks)
            {
                if (element.FirstName.ToLower() == TextBox.ToLower())
                {
                    korisniks1.Add(element);
                }


            }
            return korisniks1;

        }
        public List<StudentsResault> FilterByCourseName(List<StudentsResault> korisniks, string textBox)
        {
            List<StudentsResault> studentsResaults = new List<StudentsResault>();
            if (String.IsNullOrEmpty(textBox)==false)
            {


                foreach (var element in korisniks)
                {
                    if (String.IsNullOrEmpty(element.CoursesName) == false && element.CoursesName.ToLower() == textBox.ToLower())
                    {


                        studentsResaults.Add(element);

                    }

                }
            }
            else
            {
               
                studentsResaults.DefaultIfEmpty();
            }
            return studentsResaults;
        }

        public  bool UpdateStudent(Students student, int StudentID, string Gender, int CountriesID)
        {
            bool StudentIsUpdated = StudentsDAL.UpdateStudent(student,StudentID,Gender,CountriesID);
            return StudentIsUpdated;
        }
        public bool SaveStudent(Students student,int CountriesID,string Gender)
        {
             
         bool StudentIsAdded  = StudentsDAL.SaveStudent(student, CountriesID,Gender);
            return StudentIsAdded;




        }

        #region Student Validation
        public bool ValidateFirstName(string FirstName)
        {
            bool IsFirstNameValid = false;
            if (String.IsNullOrEmpty(FirstName)||FirstName.Length < 3 || FirstName == "FirstName" )
            {
                IsFirstNameValid = false;

            }
            else
            {
                IsFirstNameValid = true;
            }
            return IsFirstNameValid;

        }

        public bool ValidateLastName(string LastName)
        {
            bool IsLastNameValis = false;
            if (String.IsNullOrEmpty(LastName)||LastName.Length < 3 || LastName == "LastName" )
            {
                IsLastNameValis = false;

            }
            else
            {
                IsLastNameValis = true;
            }
            return IsLastNameValis;

        }
        public bool ValidateEmail(string Email)
        {
            bool IsEmailvalid = false;
            if (String.IsNullOrEmpty(Email) || Email.Length > 5 && Email.Contains("@") == true && Email.Contains(".com") == true)
            {
                IsEmailvalid = true;
            }
            return IsEmailvalid;
        }
        public bool ValidateGender(string Gender)
        {
            bool IsGenderValid = false;
            if (String.IsNullOrEmpty(Gender) == false)
            {
                IsGenderValid = true;
            }
            return IsGenderValid;
        }
        public bool ValidateCountry(string Country)
        {
            bool IsCountryValid = false;
            if (String.IsNullOrEmpty(Country) == false)
            {
                IsCountryValid = true;
            }
            return IsCountryValid;
        }
        public bool ValidateAdress(string Adress)
        {
            bool IsAdressValid = false;
            if (String.IsNullOrEmpty(Adress) || Adress.Length<5||Adress=="Adress")
            {
                IsAdressValid = false;
            }
            else
            {
                IsAdressValid = true;
            }
            return IsAdressValid;
        }

        public bool ValidateEverything(bool FirstNameIsOk, bool LastNameIsOk, bool EmailIsOk, bool GenderIsOk, bool CountryIsOK, bool AdressIsOk)
        {
            bool _EverythingIsOk = false;
            if (FirstNameIsOk == true && LastNameIsOk == true && EmailIsOk == true && GenderIsOk == true && CountryIsOK == true && AdressIsOk == true )
            {
                _EverythingIsOk = true;
            }
            return _EverythingIsOk;

        }
        public bool ValidateClbCourses(CheckedListBox checkedListBox)
        {
            bool _isClbSubjectsValid = false;
            if (checkedListBox.CheckedItems.Count > 0)
            {
                _isClbSubjectsValid = true;
            }
            return _isClbSubjectsValid;
        }



        #endregion


    }
}
