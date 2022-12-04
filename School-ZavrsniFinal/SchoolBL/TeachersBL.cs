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
    public class TeachersBL
    {

        public Teachers SelectTeacherByName(string TeacherName)
        {
            Teachers teachers = new Teachers();
            teachers = TeachersDAL.SelectTeacherByName(TeacherName);
            return teachers;
        }
        public List<TeachersJoinCoursesResault> SelectAllTeachersJoinCourses()
        {
            List<TeachersJoinCoursesResault> teachersJoinCoursesResaults = new List<TeachersJoinCoursesResault>();
            teachersJoinCoursesResaults = TeachersDAL.SelectAllTeachersJoinCourses();
            return teachersJoinCoursesResaults;

        }
        public List<TeachersJoinCoursesResault> FilterByTeacherName(List<TeachersJoinCoursesResault> korisniks, string TextBox)
        {

            List<TeachersJoinCoursesResault> Teacher = new List<TeachersJoinCoursesResault>();
            if (String.IsNullOrEmpty(TextBox) == false)
            {
                foreach (var element in korisniks)
                {
                    if (String.IsNullOrEmpty(element.FirstName) == false && element.FirstName.ToLower().Contains( TextBox.ToLower()))
                    {


                        Teacher.Add(element);

                    }


                }
            }
            else
            {
                Teacher.DefaultIfEmpty();
            }
            return Teacher;

        }
        public List<TeachersJoinCoursesResault> FilterByCourseName(List<TeachersJoinCoursesResault> korisniks, string textBox)
        {
            List<TeachersJoinCoursesResault> CourseName = new List<TeachersJoinCoursesResault>();
            if (String.IsNullOrEmpty(textBox) == false)
            {
                foreach (var element in korisniks)
                {

                    if (String.IsNullOrEmpty(element.CoursesName) == false && element.CoursesName.ToLower().Contains( textBox.ToLower()))
                    {


                        CourseName.Add(element);

                    }


                }
            }
            else
            {
                CourseName.DefaultIfEmpty();
            }
            return CourseName;
        }
        public bool SaveTeacher(Teachers teacher, string Gender)
        {
            bool TeacherIsAdded = false;
            TeacherIsAdded = TeachersDAL.SaveTeacher(teacher, Gender);
            return TeacherIsAdded;
        }

        public bool ValidateFirstName(string FirstName)
        {
            bool IsFirstNameValid = false;
            if (String.IsNullOrEmpty(FirstName) || FirstName.Length < 3 || FirstName == "FirstName")
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
            if (String.IsNullOrEmpty(LastName) || LastName.Length < 3 || LastName == "LastName")
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

        public bool ValidateAdress(string Adress)
        {
            bool IsAdressValid = false;
            if (String.IsNullOrEmpty(Adress) || Adress.Length < 5 || Adress == "Adress")
            {
                IsAdressValid = false;
            }
            else
            {
                IsAdressValid = true;
            }
            return IsAdressValid;
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
        public bool ValidateEverything(bool FirstNameIsOk, bool LastNameIsOk, bool EmailIsOk, bool GenderIsOk, bool AdressIsOk, bool clbCoursesIsOk)
        {
            bool _EverythingIsOk = false;
            if (FirstNameIsOk == true && LastNameIsOk == true && EmailIsOk == true && GenderIsOk == true && clbCoursesIsOk == true && AdressIsOk == true)
            {
                _EverythingIsOk = true;
            }
            return _EverythingIsOk;

        }
        public bool DeleteTeacher(int TeacherId)
        {
            bool TeacherIsDeleted = false;
            TeacherIsDeleted = TeachersDAL.DeleteTeacher(TeacherId);
            return TeacherIsDeleted;
        }

        public  bool UpdateTeacher(Teachers teacher, int TeacherfromGridId,string cbGender)
        {
            bool IsTeacherUpdated = false;
            IsTeacherUpdated = TeachersDAL.UpdateTeacher(teacher,TeacherfromGridId,cbGender);
            return IsTeacherUpdated;
        }

    }
}
