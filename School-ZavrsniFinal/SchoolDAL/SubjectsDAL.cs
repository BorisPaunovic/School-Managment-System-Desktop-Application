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
   public  class SubjectsDAL
    {
        public static List<Subjects> SelectAllSubjects()
        {
            List<Subjects> subjects = new List<Subjects>();
            try
            {
                string StoredProcedure = "SelectAllSubjects";
                string query = "   select SubjectID,SubjectName,SubjectDescription from Subjects ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    subjects = SqlConn.Query<Subjects>(StoredProcedure, commandType: CommandType.StoredProcedure).ToList();
                }


            }
            catch
            {

            }
            return subjects;
        }
        public static bool SaveSubject(Subjects subject)
        {
            bool IsSubjectsSaved = false;
            string StoredProcedure = "SaveSubject";
            string query = "insert into Subjects(SubjectName,SubjectDescription) values(@SubjectName,@SubjectDescription)";
            try
            {
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @SubjectName=subject.SubjectName, @SubjectDescription=subject.SubjectDescription}, commandType: CommandType.StoredProcedure);
                    IsSubjectsSaved = true;
                }
            }
            catch
            {
                IsSubjectsSaved = false;
            }
            return IsSubjectsSaved;
        }
        public static Subjects SelectSubjectByName(Subjects subject)
        {
            Subjects subjects = new Subjects();
            try
            {
                string StoredProcedure = "SelectSubjectByName";
                string query = "  select SubjectID,SubjectDescription,SubjectName from Subjects where SubjectName=@SubjectName";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    subjects = SqlConn.QueryFirst<Subjects>(StoredProcedure, new { @SubjectName = subject.SubjectName }, commandType: CommandType.StoredProcedure);
                }


            }
            catch
            {

            }
            return subjects;
        }
        public static bool DeleteSubject(int SubjectId)
        {
            bool SubjectIsDeleted = false;
            int affectedRows = 0;

            try
            {
                string StoredProcedure = "DeleteSubject";
                string query = "delete Subjects where SubjectID=@SubjectId";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    affectedRows = SqlConn.Execute(StoredProcedure, new { @SubjectId = SubjectId }, commandType: CommandType.StoredProcedure);
                    if (affectedRows != 0)
                    {
                        SubjectIsDeleted = true;
                    }
                }

            }
            catch
            {
                if (affectedRows == 0)
                {
                    SubjectIsDeleted = false;
                }
            }
            return SubjectIsDeleted;







        }
        public static bool UpdateSubject(Subjects subject, int SubjectIdfromGird)
        {
            bool IsCourseUpdated = false;
            try
            {
                string StoredProcedure = "UpdateSubject";
                string queery = "update Subjects set SubjectName=@SubjectName,SubjectDescription=@SubjectDescription where SubjectID=@SubjectID ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @SubjectName=subject.SubjectName, @SubjectDescription=subject.SubjectDescription, @SubjectID=SubjectIdfromGird }, commandType: CommandType.StoredProcedure);
                    IsCourseUpdated = true;
                }
            }
            catch
            {
                IsCourseUpdated = false;
            }
            return IsCourseUpdated;
        }
    }
}
