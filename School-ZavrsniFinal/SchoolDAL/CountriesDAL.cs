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
    public class CountriesDAL
    {
        
        public static Countries SelectCountryByID(string CountryName)
        {
            Countries countries = new Countries();
            try
            {
                string StoredProcedure = "SelectCountryByName";
                string query = "  select CountriesID from Countries where CountryName = @CountryName";
                using(SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                  countries=  SqlConn.QueryFirst<Countries>(StoredProcedure, new { @CountryName=CountryName}, commandType: CommandType.StoredProcedure);
                }


            }
            catch
            {

            }
            return countries;
        }
        public static Countries SelectCountryByName(string CountryName)
        {
            Countries countries = new Countries();
            try
            {
                string StoredProcedure = "SelectCountryByName";
                
                string query = "  select CountriesID,ISO,CountryName,PhoneCode,ISO3,Deleted from Countries where CountryName = @CountryName";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    countries = SqlConn.QueryFirst<Countries>(StoredProcedure, new { @CountryName = CountryName }, commandType: CommandType.StoredProcedure);
                  //  countries = SqlConn.QueryFirst<Countries>(query, new { @CountryName = CountryName });
                }


            }
            catch
            {

            }
            return countries;
        }
        public static List<Countries> SelectAllCountryes()
        {
           List<Countries> countries = new List<Countries>();
            try
            {
                string StoredProcedure = "SelectAllCountryes";
                string query = "   select countriesid,CountryName,ISO,iso3,PhoneCode,Deleted from Countries ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    countries = SqlConn.Query<Countries>(StoredProcedure, commandType: CommandType.StoredProcedure).ToList();
                }


            }
            catch
            {

            }
            return countries;
        }
        public static bool SaveCountry(Countries country)
        {
            bool IsCountrySaved = false;
            string StoredProcedure = "SaveCountry";
            string query = "insert into Countries(ISO,CountryName,PhoneCode,ISO3)values(@ISO,@CountryName,@PhoneCode,@ISO3)";
            try
            {
             using(SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @ISO = country.ISO, @CountryName = country.CountryName, @PhoneCode = country.PhoneCode, @ISO3 = country.ISO3 }, commandType: CommandType.StoredProcedure);
                    IsCountrySaved = true;
                }
            }
            catch 
            {
                IsCountrySaved = false;
            }
            return IsCountrySaved;
        }
        public static bool DeleteCountry(int CountryId)
        {
            bool CountryIsDeleted = false;
            int affectedRows = 0;

            try
            {
                string StoredProcedure = "DeleteCountry";
                string query = "update Students set CountriesID = null where CountriesID=@CountryId delete from Countries where CountriesID=@CountryId";
                string query1 = " UPDATE Countries SET Deleted = 1 WHERE CountriesID = @CountryId";
   
   
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    affectedRows = SqlConn.Execute(StoredProcedure, new { @CountryId = CountryId }, commandType: CommandType.StoredProcedure);
                  //  affectedRows = SqlConn.Execute(query1, new { @CountryId = CountryId });
                    if (affectedRows != 0)
                    {
                        CountryIsDeleted = true;
                    }
                }

            }
            catch
            {
                if (affectedRows == 0)
                {
                    CountryIsDeleted = false;
                }
            }
            return CountryIsDeleted;







        }
        public static bool UpdateCountry( string CountryName,string ISO,string ISO3,int PhoneCode,int CountriesID)
        {

            bool IsStudentCourseUpdated = false;
            try
            {
                string StoredProcedure = "UpdateCountry";
                string queery = "UPDATE Countries SET CountryName = @CountryName, ISO = @ISO,ISO3 = @ISO3, PhoneCode = @PhoneCode WHERE CountriesID = @CountriesID ";
                using (SqlConnection SqlConn = new SqlConnection(Settings1.Default.ConnectionString))
                {
                    SqlConn.Execute(StoredProcedure, new { @CountryName=CountryName,@ISO=ISO,@ISO3=ISO3,@PhoneCode= PhoneCode ,@CountriesID= CountriesID}, commandType: CommandType.StoredProcedure);
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
