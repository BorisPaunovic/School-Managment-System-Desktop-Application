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
   public  class TeachersDAL
    {
        public static List<TeachersJoinCoursesResault> SelectAllTeachersJoinCourses()
        {
            List<TeachersJoinCoursesResault> usersList = new List<TeachersJoinCoursesResault>();
            try
            {
                string StoredProcedure = "SelectAllTeachersJoinCourses";
                string query = "select T.TeachersID,T.FirstName,T.LastName,T.Email,T.Gender,T.DateOfBirth,T.Adress,TC.TeachersCoursesID,C.CoursesID,C.CoursesName,C.CoursesDescription from Teachers as T left join TeachersCourses as TC on t.TeachersID= TC.TeachersID left join Courses as C on TC.CoursesID= C.CoursesID  ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    usersList = SqlConn.Query<TeachersJoinCoursesResault>(StoredProcedure, commandType: CommandType.StoredProcedure).ToList();

                }
            }
            catch (Exception ex)
            {

            }
            return usersList;


        }
        public static bool SaveTeacher(Teachers teacher, string Gender)
        {
            bool StudentIsAdded = false;


            try
            {
                string StoredProcedure = "SaveTeacher";
                string qery = "insert into Teachers(FirstName,LastName,Email,Gender,DateOfBirth,Adress)values(@FirstName,@LastName,@Email,@Gender,@DateOfBirth,@Adress)";
                using (var SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @FirstName=teacher.FirstName, @LastName=teacher.LastName, @Email=teacher.Email, @Gender=Gender, @DateOfBirth=teacher.DateOfBirth, @Adress=teacher.Adress }, commandType: CommandType.StoredProcedure);
                    StudentIsAdded = true;
                }

            }
            catch (Exception ex)
            {
                StudentIsAdded = false;
            }
            return StudentIsAdded;








        }
        public static Teachers SelectTeacherByName(string TeacherName)
        {
            Teachers courses = new Teachers();
            try
            {
                string StoredProcedure = "SelectTeacherByName";
                string query = "  select TeachersID,FirstName,LastName,Email,Gender,DateOfBirth,Adress from Teachers where FirstName = @FirstName";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    courses = SqlConn.QueryFirst<Teachers>(StoredProcedure, new { @FirstName = TeacherName }, commandType: CommandType.StoredProcedure);
                }


            }
            catch
            {

            }
            return courses;
        }
        public static bool DeleteTeacher(int TeacherId)
        {
            bool TeacherIsDeleted = false;
            int affectedRows = 0;

            try
            {
                string StoredProcedure = "DeleteTeacher";
                string query = "delete TeachersCourses  where TeachersID = @TeachersID delete Teachers where TeachersID = @TeachersID";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    affectedRows = SqlConn.Execute(StoredProcedure, new { @TeachersID = TeacherId }, commandType: CommandType.StoredProcedure);
                    if (affectedRows != 0)
                    {
                        TeacherIsDeleted = true;
                    }
                }

            }
            catch
            {
                if (affectedRows == 0)
                {
                    TeacherIsDeleted = false;
                }
            }
            return TeacherIsDeleted;







        }
        public static bool UpdateTeacher(Teachers teacher, int TeacherfromGridId,string Gender)
        {
            bool IsTeacherUpdated = false;
            try
            {
                string StoredProcedure = "UpdateTeacher";
                string queery = "update Teachers set FirstName=@FirstName,LastName=@LastName,Adress=@Adress,Email=@Email,DateOfBirth=@DateOfBirth,Gender=@Gender where TeachersID= @TeachersId ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @TeachersId=TeacherfromGridId, @FirstName=teacher.FirstName, @LastName =teacher.LastName,@Adress= teacher.Adress,@Email=teacher.Email, @DateOfBirth=teacher.DateOfBirth,@Gender=Gender }, commandType: CommandType.StoredProcedure);
                    IsTeacherUpdated = true;
                }
            }
            catch
            {
                IsTeacherUpdated = false;
            }
            return IsTeacherUpdated;
        }
    }
}
