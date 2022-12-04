using SchoolBL;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms.CountriesForms
{
    public partial class frmUpdateCountry : Form
    {
        private bool _isoIsValid = false;
        private bool _isCountryValid = false;
       
        private bool _iso3IsValid = false;
        private bool _isCountryNameValid = false;
        private bool _isPhoneCodeValid = false;
        Countries countries = new Countries();
        
     
        private bool _isCountryUpdated = false;
        CountriesBL countriesBL = new CountriesBL();
        private Countries _country;
        public bool CountryIsUpdated
        {
            get { return _isCountryUpdated; }
        }
        public Countries Country
        {
            set { _country = value; }
        }
        public frmUpdateCountry()
        {
            InitializeComponent();
            Init();
          


        }

        private void Init()
        {
            countriesBindingSource.DataSource = countries;
           
        }

        private void pnlUpdateCountry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateCountry_Click(object sender, EventArgs e)
        {

            Init();
           UpdateCountry();
        }

       

        private void UpdateCountry()
        {
            ValidateEverything();
            if (_isCountryValid == true)
            {
                _isCountryUpdated = countriesBL.UpdateCountry(countries.CountryName, countries.ISO, countries.ISO3, countries.PhoneCode, _country.CountriesID);
                errorProvider1.Clear();
                MessageBox.Show("Country is valid");
              
            }
            if (_isCountryUpdated == true)
            {
                MessageBox.Show("Country is Updated");
                this.Close();

            }
          
        }
      
        public void ValidateEverything()
        {
            _isoIsValid = countriesBL.ValidateISO(countries.ISO);
            _iso3IsValid = countriesBL.ValidateISO3(countries.ISO3);
            _isPhoneCodeValid = countriesBL.ValidatePhoneCode(countries.PhoneCode);
            _isCountryNameValid = countriesBL.ValidateCountryName2(countries.CountryName);
            _isCountryValid = countriesBL.ValidateCountry(_isoIsValid, _iso3IsValid, _isPhoneCodeValid, _isCountryNameValid);

            if (_isoIsValid == false)
            {
                errorProvider1.SetError(iSOTextBox1, "First name is not valid");
            }
            if (_iso3IsValid == false)
            {
                errorProvider1.SetError(iSO3TextBox1, "Last name is not valid");
            }
            if (_isPhoneCodeValid == false)
            {
                errorProvider1.SetError(phoneCodeTextBox1, "E-mail is not valid");
            }
            if (_isCountryNameValid == false)
            {
                errorProvider1.SetError(countryNameTextBox1, "Gender is not valid");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void frmUpdateCountry_Load(object sender, EventArgs e)
        {
            countryNameTextBox1.Text = _country.CountryName;
            iSOTextBox1.Text = _country.ISO;
            iSO3TextBox1.Text = _country.ISO3;
            phoneCodeTextBox1.Text = _country.PhoneCode.ToString();

        }

        
    }
}
