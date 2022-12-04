using SchoolDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL
{
    public class TeachersCoursesBL
    {
        public bool AddTeacherCourset(int TeachersId, int CoursesId)
        {
            bool IsTeachersCoursesInserted = false;
            IsTeachersCoursesInserted = TeachersCoursesDAl.AddTeacherCourses(TeachersId, CoursesId);
            return IsTeachersCoursesInserted;
        }

        public  bool UpdateTeachersCourses(int TeachersId, int CoursesId,int TeachersCoursesId)
        {
            bool IsTeacherCourseUpdated = false;
            IsTeacherCourseUpdated = TeachersCoursesDAl.UpdateTeachersCourses(TeachersId,CoursesId,TeachersCoursesId);
            return IsTeacherCourseUpdated;
        }
    }


}
