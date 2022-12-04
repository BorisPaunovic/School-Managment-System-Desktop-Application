
using SchoolDAL;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBL
{
    public class CountriesBL
    {
        public Countries SelectCountryByName(string CountryName)
        {
            Countries countries = new Countries();
            countries = CountriesDAL.SelectCountryByName(CountryName);
            return countries;
        }

        public Countries SelectCountryByID(string CountryName)
        {
            Countries countries = new Countries();
            countries = CountriesDAL.SelectCountryByID(CountryName);
            return countries;
        }
        public bool SaveCountry(Countries country)
        {
            bool IsCountrySaved = CountriesDAL.SaveCountry(country);
            return IsCountrySaved;
        }
        public bool ValidateCountry(bool IsIsovalid, bool IsIso3Valid, bool IsPhoneCodeValid, bool IsCountryNamevalid)
        {
            bool IsCountryValid = false;

            if (IsIsovalid == true && IsIso3Valid == true && IsPhoneCodeValid == true && IsCountryNamevalid == true)
            {
                IsCountryValid = true;
            }
            else
            {
                IsCountryNamevalid = false;
            }
            return IsCountryValid;
        }
        public bool ValidateISO(string iso)
        {
            bool IsISOValid = false;
            if (String.IsNullOrEmpty(iso)==false && iso.Length==2 )
            {
                IsISOValid = true;
            }
            else
            {
                IsISOValid = false;
            }
            return IsISOValid;

        }
        public bool ValidateISO3(string iso3)
        {
            bool IsIso3Valid = false;
            if (String.IsNullOrEmpty(iso3) == false && iso3.Length == 3 )
            {
                IsIso3Valid = true;
            }
            else
            {
                IsIso3Valid = false;
            }
            return IsIso3Valid;
        }
        public bool ValidatePhoneCode(int PhoneCode)
        {
            bool IsPhoneCodeValid = false;
            if (String.IsNullOrEmpty(PhoneCode.ToString()) == false)
            {
                IsPhoneCodeValid = true;
            }
            else
            {
                IsPhoneCodeValid = false;
            }
            return IsPhoneCodeValid;
        }
        
          public bool ValidateCountryName2(string CountryName)
        {
           
            bool IsCountryNameValid = false;
            if (String.IsNullOrEmpty(CountryName) == false && CountryName.Length > 3)
            {
                IsCountryNameValid = true;
            }
            else
            {
                IsCountryNameValid = false;
            }

            return IsCountryNameValid;
        }
         
        public bool ValidateCountryName(string CountryName)
        {
            var a = SelectCountryByName(CountryName).CountryName;
            bool IsUnique = String.IsNullOrEmpty(SelectCountryByName(CountryName).CountryName);
            bool IsCountryNameValid = false;
            if (String.IsNullOrEmpty(CountryName) == false &&  IsUnique == true && CountryName.Length > 3 )
            {
                IsCountryNameValid = true;
            }
            else
            {
                IsCountryNameValid = false;
            }

            return IsCountryNameValid;
        }
        public List<Countries> SelectAllCountryes()
        {
            List<Countries> countries = new List<Countries>();
            countries = CountriesDAL.SelectAllCountryes();
            return countries;
        }
        public bool DeleteCountry(int CountryId)
        {
            bool CountryIsDeleted = CountriesDAL.DeleteCountry(CountryId);
            return CountryIsDeleted;
        }
        public bool UpdateCountry(string CountryName, string ISO, string ISO3, int PhoneCode, int CountriesID)
        {
            bool IsCountryUpdated = false;
            IsCountryUpdated = CountriesDAL.UpdateCountry(CountryName, ISO, ISO3, PhoneCode, CountriesID);
            return IsCountryUpdated;

        }
        public List<Countries> FilterByCountryName(List<Countries> countries, string TextBox)
        {

            List<Countries> countries1 = new List<Countries>();
            foreach (var element in countries)
            {
                if (element.CountryName.ToLower().Contains(TextBox.ToLower()) == true)
                {
                    countries1.Add(element);
                }


            }
            return countries1;

        }
        public List<Countries> FilterByIso(List<Countries> countries, string TextBox)
        {

            List<Countries> countries1 = new List<Countries>();
            foreach (var element in countries)
            {
                if (element.ISO.ToLower().Contains( TextBox.ToLower())==true)
                {
                    countries1.Add(element);
                }


            }
            return countries1;

        }
    }
}
