using Dapper;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDAL
{
    public class TeachersCoursesDAl
    {
        public static bool AddTeacherCourses(int TeachersId, int CoursesId)
        {
            bool IsCourseSubjectInserted = false;
            try
            {
                string StoredProcedure = "AddTeacherCourses";
                string query = "insert into TeachersCourses(TeachersID,CoursesID) values(@TeachersID,@CoursesID)";

                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @TeachersID = TeachersId, @CoursesID = CoursesId }, commandType: CommandType.StoredProcedure);
                    IsCourseSubjectInserted = true;
                }

            }
            catch
            {
                IsCourseSubjectInserted = false;
            }
            return IsCourseSubjectInserted;
        }
        public static bool UpdateTeachersCourses(int TeachersId, int CoursesId,int TeachersCoursesId)
        {
            bool IsStudentCourseUpdated = false;
            try
            {
                string StoredProcedure = "UpdateTeachersCourses";
                string queery = "update TeachersCourses set CoursesID=@CoursesId where TeachersCoursesID=@TeachersCoursesId and TeachersID=@TeachersId ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @CoursesId=CoursesId, @TeachersId =TeachersId, @TeachersCoursesId=TeachersCoursesId }, commandType: CommandType.StoredProcedure);
                    IsStudentCourseUpdated = true;
                }
            }
            catch
            {
                IsStudentCourseUpdated = false;
            }
            return IsStudentCourseUpdated;
        }
    }
}
