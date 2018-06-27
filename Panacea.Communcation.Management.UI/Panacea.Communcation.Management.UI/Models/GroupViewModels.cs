using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Panacea.Communcation.Management.UI.Models
{
    public class GroupGridItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int ContactCount { get; set; }
        public int OrganisationCount { get; set; }
        public string Description { get; set; }
    }

    public class AddGroupVM
    {
        public AddGroupVM()
        {
            Organisations = new List<SelectedOrganisation>();
            Contacts = new List<SelectedContact>();
        }

        [Required]
        [Display(Name = "Group Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Group Description")]
        public string Description { get; set; }

        public List<SelectedOrganisation> Organisations { get; set; } // Stores Selected Organisations
        public List<SelectedContact> Contacts { get; set; } // Stores Selected Contacts
    }

    public class SelectedContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public string Organisation { get; set; }
    }

    public class SelectedOrganisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ContactCount { get; set; }
        public string Country { get; set; }
    }
}