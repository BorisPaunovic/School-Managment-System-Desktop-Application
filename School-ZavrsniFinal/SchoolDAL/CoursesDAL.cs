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
    public class CoursesDAL
    {

        public static bool UpdateCourse(Courses course, int CoursefromGridId)
        {
            bool IsCourseUpdated = false;
            try
            {
                string StoredProcedure = "UpdateCourse";
                string queery = "UPDATE Courses SET CoursesName=@CourseName , CoursesDescription=@CoursesDescription WHERE CoursesID=@CourseID ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @CourseName=course.CoursesName, @CoursesDescription=course.CoursesDescription, @CourseID = CoursefromGridId }, commandType: CommandType.StoredProcedure);
                    IsCourseUpdated = true;
                }
            }
            catch
            {
                IsCourseUpdated = false;
            }
            return IsCourseUpdated;
        }
        public static bool DeleteCourse(int CourseId )
        {
            bool ourseIsDeleted = false;
            int affectedRows = 0;

            try
            {
                string StoredProcedure = "DeleteCourse";
                string query = " delete StudentsCourses where CoursesID=@CoursesID delete CouresSubjects where CoursesID=@CoursesID delete TeachersCourses where CoursesID=@CoursesID delete Courses where CoursesID=@CoursesID";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    affectedRows = SqlConn.Execute(StoredProcedure, new { @CoursesID=CourseId  }, commandType: CommandType.StoredProcedure);
                  //  affectedRows = SqlConn.Execute(query, new { @CoursesID = CourseId });
                    if (affectedRows != 0)
                    {
                        ourseIsDeleted = true;
                    }
                }

            }
            catch
            {
                if (affectedRows == 0)
                {
                    ourseIsDeleted = false;
                }
            }
            return ourseIsDeleted;







        }
        public static List<Courses> SelectAllCourses()
        {
            List<Courses> coursesList = new List<Courses>();
            try
            {
                string StoredProcedure = "SelectAllCourses";
                string query = "SELECT CoursesID,CoursesName,CoursesDescription FROM Courses";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    coursesList = SqlConn.Query<Courses>(StoredProcedure, commandType: CommandType.StoredProcedure).ToList();

                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return coursesList;


        } //select CoursesSubjectsID,CoursesID,SubjectsID from CouresSubjects where CoursesID=50

        
        public static bool SaveCourse(Courses course)
        {
            bool IsCountrySaved = false;
            string StoredProcedure = "SaveCourse";
            string query = "insert into Courses(CoursesName,CoursesDescription) values (@CoursesName,@CoursesDescription)";
            try
            {
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @CoursesName=course.CoursesName, @CoursesDescription=course.CoursesDescription },commandType: CommandType.StoredProcedure);
                    IsCountrySaved = true;
                }
            }
            catch
            {
                IsCountrySaved = false;
            }
            return IsCountrySaved;
        }
        public static Courses SelectCourseByName(string CoursesName)
        {
            Courses courses = new Courses();
            try
            {
                string StoredProcedure = "SelectCourseByName";
                string query = "  SELECT CoursesID,CoursesName,CoursesDescription FROM Courses WHERE CoursesName=@CoursesName";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    courses = SqlConn.QueryFirst<Courses>(StoredProcedure, new { @CoursesName = CoursesName }, commandType: CommandType.StoredProcedure);
                }


            }
            catch
            {
               
            }
            return courses;
        }
       


    }
}
