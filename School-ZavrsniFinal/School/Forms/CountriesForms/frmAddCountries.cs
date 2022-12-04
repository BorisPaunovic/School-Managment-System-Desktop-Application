using SchoolBL;
using SchoolModel;
using SchoolDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms
{
    public partial class frmAddCountries : Form
    {
        private bool _isoIsValid = false;
        private bool _isCountryValid = false;
        private bool _iscountrySaved = false;
        private bool _iso3IsValid = false;
        private bool _isCountryNameValid = false;
        private bool _isPhoneCodeValid = false;
        Countries countries = new Countries();
        CountriesBL countriesBL = new CountriesBL();
        public frmAddCountries()
        {
            InitializeComponent();
            countriesBindingSource.DataSource = countries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveCountry();
        }






       
        public void SaveCountry()
        {
            ValidateEverything();
            if(_isCountryValid==true)
            {
                errorProvider1.Clear();
                MessageBox.Show("Country is valid");
                _iscountrySaved = countriesBL.SaveCountry(countries);
            }
            if(_iscountrySaved==true)
            {
                MessageBox.Show("Country is saved");
                
            }



        }
        public void ValidateEverything()
        {
            _isoIsValid = countriesBL.ValidateISO(countries.ISO);
             _iso3IsValid = countriesBL.ValidateISO3(countries.ISO3);
            _isPhoneCodeValid = countriesBL.ValidatePhoneCode(countries.PhoneCode);
            _isCountryNameValid = countriesBL.ValidateCountryName(countries.CountryName);
             _isCountryValid = countriesBL.ValidateCountry(_isoIsValid,_iso3IsValid,_isPhoneCodeValid,_isCountryNameValid);

            if (_isoIsValid == false)
            {
                errorProvider1.SetError(iSOTextBox, "First name is not valid");
            }
            if (_iso3IsValid == false)
            {
                errorProvider1.SetError(iSO3TextBox, "Last name is not valid");
            }
            if (_isPhoneCodeValid == false)
            {
                errorProvider1.SetError(phoneCodeTextBox, "E-mail is not valid");
            }
            if (_isCountryNameValid == false)
            {
                errorProvider1.SetError(countryNameTextBox, "Gender is not valid");
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
