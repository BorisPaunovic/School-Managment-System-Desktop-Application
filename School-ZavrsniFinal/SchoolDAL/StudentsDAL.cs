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
      public   class StudentsDAL
      {

        public static Students SelectStudentByName(string StudentName)
        {
            Students students = new Students();
            try
            {
                string StoredProcedure = "AddStudentCourse";
                string query = " select StudentsID,FirstName,LastName,Email,Gender,DateOfBirth,Adress,CountriesID from Students where FirstName=@FirstName";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    students = SqlConn.QueryFirst<Students>(StoredProcedure, new { @FirstName = StudentName }, commandType: CommandType.StoredProcedure);
                }


            }
            catch
            {

            }
            return students;
        }
        public static List<StudentsResault> SelectAllUsers()
        {
            List<StudentsResault> usersList = new List<StudentsResault>();
            try
            {
                string StoredProcedure = "SelectAllStudentsResault";
                string query = "SELECT S.StudentsID ,S.FirstName,S.LastName,S.Email,s.Gender,s.DateOfBirth,s.Adress,C.CoursesName,SC.Passed,SC.StartDate,C.CoursesDescription,Co.CountryName FROM Students AS S left join StudentsCourses AS SC ON S.StudentsID=SC.StudentsID left join Courses AS C ON SC.CoursesID=C.CoursesID left join Countries AS Co ON S.CountriesID=Co.CountriesID";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    usersList = SqlConn.Query<StudentsResault>(StoredProcedure, commandType: CommandType.StoredProcedure).ToList();
                   
                }
            }
            catch (Exception ex)
            {

            }
            return usersList;


        }

        public static Students SelectLastStudent()
        {
            Students student = new Students();
            try
            {
                string StoredProcedure = "SelectLastStudent";
                string query = "SELECT top 1 StudentsID,FirstName,LastName,Email,Gender,DateOfBirth,Adress,CountriesID FROM Students  ORDER BY StudentsID DESC";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    student = SqlConn.QueryFirst<Students>(StoredProcedure, commandType: CommandType.StoredProcedure) ;

                }
            }
            catch (Exception ex)
            {

            }
            return student;


        }
        public static bool DeleteStudent(int StudentID)
        {
            bool StudentIsDeleted = false; 
            int affectedRows=0;

            try
            {
                string StoredProcedure = "DeleteStudent";
                string query2 = " Update Students set  WHERE Students.StudentsID=@StudentsID";
                string query = "DELETE FROM dbo.StudentsCourses WHERE dbo.StudentsCourses.StudentsID=@StudentsID DELETE FROM Students WHERE Students.StudentsID=@StudentsID";
            using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
            {
                    affectedRows= SqlConn.Execute(StoredProcedure, new { @StudentsID = StudentID }, commandType: CommandType.StoredProcedure);
                    if(affectedRows>0)
                    {
                        StudentIsDeleted = true;
                    }
            }

            }
            catch
            {
                if (affectedRows == 0)
                {
                    StudentIsDeleted = false;
                }
            }
            return StudentIsDeleted;







        }
        public static bool UpdateStudent(Students student, int StudentID,string Gender, int CountriesID)
        {
            bool StudentIsUpdated = false;
            
            try
            {
              string query = "Update Students SET FirstName=@FirstName,LastName=@LastName,Email=@Email,Gender=@Gender,DateOfBirth=@DateOfBirth,Adress=@Adress,CountriesID=@CountriesID WHERE StudentsID=@StudentsId";
                string StoredProcedure = "UpdateStudent";
               
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
               {
                SqlConn.Execute(StoredProcedure, new { @FirstName = student.FirstName, @LastName = student.LastName, @Email=student.Email,@Gender=Gender,@DateOfBirth=student.DateOfBirth,@Adress=student.Adress, @CountriesID= CountriesID, @StudentsId = StudentID }, commandType: CommandType.StoredProcedure);
                   
                        StudentIsUpdated = true;
                    
                }
            }
            catch
            {
                
                
                    StudentIsUpdated = false;
                
            }
            return StudentIsUpdated;

            
        }
        public static bool SaveStudent(Students student,int CountriesID,string Gender)
        {
           bool  StudentIsAdded = false;


            try
            {
                string StoredProcedure = "SaveStudent";
                string qery = "INSERT INTO Students(FirstName,LastName,Email,Gender,DateOfBirth,Adress,CountriesID) VALUES(@FirstName,@LastName,@Email,@Gender,@DateOfBirth,@Adress,@CountriesID)";
                using (var SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @FirstName = student.FirstName, @LastName = student.LastName, @Email = student.Email, @Gender = Gender, @DateOfBirth = student.DateOfBirth, @Adress = student.Adress, @CountriesID = CountriesID }, commandType: CommandType.StoredProcedure);
                    StudentIsAdded = true;
                }

            }
            catch (Exception ex)
            {
                StudentIsAdded = false;
            }
            return StudentIsAdded;








        }
    }
}
