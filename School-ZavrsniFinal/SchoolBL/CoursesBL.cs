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
    public class CoursesBL
    {
        public Courses SelectCourseByName(string CoursesName)
        {
            Courses courses = new Courses();
            courses = CoursesDAL.SelectCourseByName(CoursesName);
            return courses;
        }
        public List<Courses> SelectAllCourses()
        {
            List<Courses> coursesList = new List<Courses>();
            coursesList = CoursesDAL.SelectAllCourses();
            return coursesList;


        }
        public bool SaveCourse(Courses course)
        {
            bool IsCourseSaved = CoursesDAL.SaveCourse(course);
            return IsCourseSaved;
        }
        public bool ValidateCourse(bool IsNameValid, bool IsDescriptionValid, bool _isClbSubjectsValid)
        {
            bool IsCourseValid = false;

            if (IsNameValid == true && IsDescriptionValid == true && _isClbSubjectsValid == true)
            {
                IsCourseValid = true;
            }
            return IsCourseValid;
        }

        public bool ValidateCoursename(string CourseName)
        {
            bool IsUnique = String.IsNullOrEmpty(SelectCourseByName(CourseName).CoursesName);
            bool isNameValid = false;
            if (String.IsNullOrEmpty(CourseName) == false && IsUnique == true)
            {
                isNameValid = true;
            }
            return isNameValid;
        }
        public bool ValidateCourseDescription(string CourseDescription)
        {
            bool isDescriptionValid = false;
            if (String.IsNullOrEmpty(CourseDescription) == false)
            {
                isDescriptionValid = true;
            }
            return isDescriptionValid;
        }
        public bool ValidateClbSubjects(CheckedListBox checkedListBox)
        {
            bool _isClbSubjectsValid = false;
            if (checkedListBox.CheckedItems.Count > 0)
            {
                _isClbSubjectsValid = true;
            }
            return _isClbSubjectsValid;
        }
        public bool UpdateCourse(Courses course, int CoursefromGridId)
        {
            bool IsCourseUpdated = false;
            IsCourseUpdated = CoursesDAL.UpdateCourse(course, CoursefromGridId);
            return IsCourseUpdated;
        }
        public bool DeleteCourse(int CourseId)
        {
            bool courseIsDeleted = false;
            courseIsDeleted = CoursesDAL.DeleteCourse(CourseId);
            return courseIsDeleted;
        }

        public List<Courses> FilterByTeacherName(List<Courses> courses, string TextBox)
        {

            List<Courses> Teacher = new List<Courses>();
            if (String.IsNullOrEmpty(TextBox) == false)
            {
                foreach (var element in courses)
                {
                    if (element.CoursesName.ToLower() == TextBox.ToLower())
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

    }
}
