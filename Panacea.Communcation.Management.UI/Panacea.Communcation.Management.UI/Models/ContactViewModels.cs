using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Panacea.Communcation.Management.UI.Helpers;

namespace Panacea.Communcation.Management.UI.Models
{

    public class AddContactVm
    {
        public List<SelectListItem> TitleList;
        public List<SelectListItem> CountryList;

        public AddContactVm()
        {
            TitleList = DownDownListHelper.GetTitleSelectList();
            CountryList = DownDownListHelper.GetCountrySelectList();
        }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
    }
}