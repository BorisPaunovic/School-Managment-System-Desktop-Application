using SchoolDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL
{
  public  class StudentCoursesBL
    {
        public  bool AddStudentCourse(int StudentId, int CourseId, DateTime Startdate)
        {
            bool IsStudentCourseIserted = false;
            IsStudentCourseIserted = StudentCoursesDAL.AddStudentCourse(StudentId,CourseId,Startdate);
            return IsStudentCourseIserted;
        }
        public static bool UpdateStudentCourse(int StudentId, int CourseId, bool Passed, DateTime StartDate, int CourseIDFromGrid)
        {
            bool IsStudentCourseUpdated = false;
            IsStudentCourseUpdated = StudentCoursesDAL.UpdateStudentCourse(StudentId, CourseId, Passed, StartDate, CourseIDFromGrid);
            return IsStudentCourseUpdated;
        }

    }
}
