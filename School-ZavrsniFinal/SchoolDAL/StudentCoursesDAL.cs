using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolModel;

namespace SchoolDAL
{
    public class StudentCoursesDAL
    {
      

        public static bool AddStudentCourse(int StudentId,int CourseId,DateTime Startdate)
        {
            bool IsStudentCourseIserted = false;
            try
            {
                string StoredProcedure = "AddStudentCourse";
                string query = "INSERT INTO StudentsCourses(StudentsID,CoursesID,StartDate) VALUES(@StudentId,@CourseId,@Startdate)";
                using (SqlConnection SqlConn= new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @StudentId = StudentId, @CourseId = CourseId, @Startdate = Startdate }, commandType: CommandType.StoredProcedure);
                    IsStudentCourseIserted = true;
                }

            }
            catch
            {
                IsStudentCourseIserted = false;
            }
            return IsStudentCourseIserted;
        }
        public static bool UpdateStudentCourse(int StudentId,int CoursesId,bool Passed,DateTime StartDate,int CourseIDFromGrid)
        {
            bool IsStudentCourseUpdated = false;
            try
            {
                string StoredProcedure = "UpdateStudentCourse";
                string queery = "UPDATE StudentsCourses SET CoursesID=@CoursesID,Passed=@Passed WHERE StudentsID=@StudentsID AND CoursesID=@CourseIDFromGrid  ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @StudentsID=StudentId, @CoursesID = CoursesId, @Passed = Passed, @StartDate = StartDate, @CourseIDFromGrid=CourseIDFromGrid }, commandType: CommandType.StoredProcedure);
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
