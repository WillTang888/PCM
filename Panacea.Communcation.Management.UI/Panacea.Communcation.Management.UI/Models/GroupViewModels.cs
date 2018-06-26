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
            Contacts = new List<SelectedContact>();
        }

        [Required]
        [Display(Name = "Group Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Group Description")]
        public string Description { get; set; }

        public List<SelectedContact> Contacts { get; set; }
    }

    public class SelectedContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public string Organisation { get; set; }
    }


}