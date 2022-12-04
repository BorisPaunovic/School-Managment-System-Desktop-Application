using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel
{
    public   class Countries
    {
        public int CountriesID { get; set; }
        public string ISO { get; set; }
        public string CountryName { get; set; }
        public int PhoneCode { get; set; }
        public string ISO3 { get; set; }
        public bool Deleted { get; set; }
    }

}
