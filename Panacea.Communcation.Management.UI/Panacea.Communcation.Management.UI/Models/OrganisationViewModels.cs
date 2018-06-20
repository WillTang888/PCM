using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Panacea.Communcation.Management.UI.Helpers;
namespace Panacea.Communcation.Management.UI.Models
{
    // Modal used to list contacts
    public class OrganisationListVM
    {
        public OrganisationListVM()
        {
            Organisations = new List<OrganisationGridItemVM>();
            AddOrganisationVm = new AddOrganisationVm();
        }

        public List<OrganisationGridItemVM> Organisations { get; set; }
        public AddOrganisationVm AddOrganisationVm { get; set; }
    }

    public class OrganisationGridItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class AddOrganisationVm
    {
        public List<SelectListItem> CountryList;

        public AddOrganisationVm()
        {
            CountryList = DownDownListHelper.GetCountrySelectList();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Phone { get; set; }

        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [Display(Name = "Address 3")]
        public string Address3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
    }

    public class EditOrganisationVm
    {
        public List<SelectListItem> CountryList;

        public EditOrganisationVm()
        {
            CountryList = DownDownListHelper.GetCountrySelectList();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Phone { get; set; }

        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [Display(Name = "Address 3")]
        public string Address3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
    }
}