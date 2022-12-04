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

namespace School.Forms.CountriesForms
{
    public partial class frmCountries : Form
    {
        private string _filter;
        List<Countries> countriesList = new List<Countries>();
        private bool _isCountryUpdated = false;
        CountriesBL countriesBL = new CountriesBL();
        public frmCountries()
        {
            InitializeComponent();
            LoadCountries();
            Init();
        }

        private void Init()
        {
            countriesMetroGrid.Columns[0].Visible = false;

            countriesMetroGrid.Columns[2].HeaderText = "Country";
            countriesMetroGrid.Columns[3].HeaderText = "Phone code";
            countriesMetroGrid.Columns[5].Visible = false;


        }

        private void pbAddCountry_Click(object sender, EventArgs e)
        {
            AddCountry();
        }
        public Countries SelectCountryFromDataGridView()
        {

            Countries country = new Countries();
            try
            {
                country = countriesMetroGrid.SelectedRows[0].DataBoundItem as Countries;
            }
            catch
            {
                country.CountriesID = 0;
                country.CountryName = null;
                country.ISO = null;
                country.ISO3 = null;
                country.PhoneCode = 0;
               
            }
           
            return country;

        }
        public void AddCountry()
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmAddCountries")
                {
                    IsOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                frmAddCountries addCountry = new frmAddCountries();
                addCountry.ShowDialog();
                LoadCountries();
                addCountry.BringToFront();

            }
        }
        public void LoadCountries()
        {
            countriesList = countriesBL.SelectAllCountryes();
            countriesMetroGrid.DataSource = countriesBL.SelectAllCountryes();
        }

        private void pbDeleteCountry_Click(object sender, EventArgs e)
        {
           
            if (countriesList.Count() > 0)
            {
                DeleteCountry();
            }
            else
            {
                MessageBox.Show("Country list is empty");
            } 
            LoadCountries();


        }

        private void DeleteCountry()
        {
            if(SelectCountryFromDataGridView().CountriesID==0)
            {
                MessageBox.Show("Country list is empty");
            }
            else
            {

           
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete Country", "Delete Country?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool StudentIsDeleted = countriesBL.DeleteCountry(SelectCountryFromDataGridView().CountriesID);
                //bool StudentIsDeleted = CountriesDAL.DeleteCountry(SelectCountryFromDataGridView().CountriesID);
                LoadCountries();
                if (StudentIsDeleted == true)
                {

                    MessageBox.Show("Country is deleted");
                }
                else
                {
                    MessageBox.Show("Ops something went wrong");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            }
        }

        private void pbUpdateCountry_Click(object sender, EventArgs e)
        {
            UpdateCountry();
        }
        public void UpdateCountry()
        {
            bool IsOpen = false;
            LoadCountries();
            if (countriesList.Count == 0)
            {
                MessageBox.Show("Country list is empty");
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "frmUpdateCountry")
                    {
                        IsOpen = true;
                        form.BringToFront();
                        break;
                    }
                }
                if (IsOpen == false)
                {
                    frmUpdateCountry updateCountry = new frmUpdateCountry();
                    updateCountry.Country = SelectCountryFromDataGridView();
                    updateCountry.ShowDialog();
                    updateCountry.BringToFront();
                    _isCountryUpdated = updateCountry.CountryIsUpdated;

                    RefreshCountryDGV();

                }

            }
               
        }
        public void RefreshCountryDGV()
        {

            if (_isCountryUpdated == true)
            {
             
                LoadCountries();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCountries();
        }

        private void pbSearchbtn_Click(object sender, EventArgs e)
        {

            countriesList = countriesBL.SelectAllCountryes();


            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    _filter = tbSearch.Text;
                    countriesMetroGrid.DataSource = countriesBL.FilterByCountryName(countriesList, _filter);
                    break;
                case 1:
                    _filter = tbSearch.Text;
                    countriesMetroGrid.DataSource = countriesBL.FilterByIso(countriesList, _filter);
                    break;
                case 2:
                    LoadCountries();
                    break;

            }
        }

        private void pnlCountryMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
