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
    public class ContactListVM
    {
        public ContactListVM()
        {
            Contacts = new List<ContactsGridItemVM>();
            addContactVm = new AddContactVm();
        }

        public List<ContactsGridItemVM> Contacts { get; set; }
        public AddContactVm addContactVm { get; set; }
    }

    public class ContactsGridItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organisation { get; set; }
        public int OrganisationId { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
    }

    public class AddContactVm
    {
        public List<SelectListItem> TitleList;
        public List<SelectListItem> OganisationList;
        public List<SelectListItem> CountryList;

        public AddContactVm()
        {
            TitleList = DownDownListHelper.GetTitleSelectList();
            OganisationList = DownDownListHelper.GetOrganisationSelectList();
            CountryList = DownDownListHelper.GetCountrySelectList();
        }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Organisation")]
        public int OrganisationId { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }

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
        public string Description { get; set; }
    }

    public class EditContactVm
    {
        public List<SelectListItem> TitleList;
        public List<SelectListItem> OganisationList;
        public List<SelectListItem> CountryList;

        public EditContactVm()
        {
            TitleList = DownDownListHelper.GetTitleSelectList();
            OganisationList = DownDownListHelper.GetOrganisationSelectList();
            CountryList = DownDownListHelper.GetCountrySelectList();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Organisation")]
        public int? OrganisationId { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }

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
        public string Description { get; set; }
    }

    public class DisplayContactVm
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? OrganisationId { get; set; }

        public string Organisation { get; set; }

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

        public string Description { get; set; }
    }
}