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
    public class CoursesSubjectsDAL
    {
        public static List<CoursesSubjects> SelectAllCoursesSubjects()
        {
            List<CoursesSubjects> coursesList = new List<CoursesSubjects>();
            try
            {
                string StoredProcedure = "SelectAllCoursesSubjects";
                string query = "select CoursesSubjectsID,CoursesID,SubjectsID from CouresSubjects";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    coursesList = SqlConn.Query<CoursesSubjects>(StoredProcedure, commandType: CommandType.StoredProcedure).ToList();

                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return coursesList;


        }
        public static List<CoursesSubjects> SelectCoursesSubjectsById(int CoursesID)
        {
            List<CoursesSubjects> coursesSubjects = new List<CoursesSubjects>();
            try
            {
                string StoredProcedure = "SelectCoursesSubjectsById";
                string query = "select CoursesSubjectsID,CoursesID,SubjectsID from CouresSubjects where CoursesID=@CoursesID";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    coursesSubjects = SqlConn.Query<CoursesSubjects>(StoredProcedure, new { @CoursesID = CoursesID }, commandType: CommandType.StoredProcedure).ToList();

                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return coursesSubjects;


        }

        public static bool AddCourseSubject(int CoursesID, int SubjectsID)
        {
            bool IsCourseSubjectInserted = false;
            try
            {
                string query = "INSERT into CouresSubjects(CoursesID,SubjectsID) values(@CoursesID,@SubjectsID)";
                string StoredProcedure = "AddCourseSubject";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @CoursesID = CoursesID, @SubjectsID = SubjectsID}, commandType: CommandType.StoredProcedure);
                    IsCourseSubjectInserted = true;
                }

            }
            catch
            {
                IsCourseSubjectInserted = false;
            }
            return IsCourseSubjectInserted;
        }

        public static bool UpdateCourseSubject(CoursesSubjects coursesSubject)
        {
            bool IsStudentCourseUpdated = false;
            try
            {
                string StoredProcedure = " UpdateCourseSubject";
                string queery = "update CouresSubjects set SubjectsID=@SubjectsID where CoursesSubjectsID=@CoursesSubjectsID and CoursesID=@CoursesID ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(queery, new { @SubjectsID = coursesSubject.SubjectsId, @CoursesID = coursesSubject.CoursesId, @CoursesSubjectsID = coursesSubject.CoursesSubjectsId });
                    IsStudentCourseUpdated = true;
                }
            }
            catch
            {
                IsStudentCourseUpdated = false;
            }
            return IsStudentCourseUpdated;
        }
        public static bool UpdateCourseSubject2(CoursesSubjects coursesSubject)
        {
            bool IsStudentCourseUpdated = false;
            try
            {
                string StoredProcedure = " UpdateCourseSubjects2";
                string queery = "update CouresSubjects set SubjectsID=@SubjectsID where CoursesSubjectsID=@CoursesSubjectsID and CoursesID=@CoursesID ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @SubjectsID = coursesSubject.SubjectsId, @CoursesID = coursesSubject.CoursesId, @CoursesSubjectsID = coursesSubject.CoursesSubjectsId }, commandType: CommandType.StoredProcedure);
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
