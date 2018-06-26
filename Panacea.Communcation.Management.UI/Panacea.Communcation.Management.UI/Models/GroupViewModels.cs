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
        //public List<SelectListItem> ContactsList;
        //public List<SelectListItem> OrganisationList;
        //public List<ContactsGridItemVM> SelectedContacts;

        public AddGroupVM()
        {
            //ContactsList = Helpers.DownDownListHelper.GetContactsSelectList();
            //OrganisationList = Helpers.DownDownListHelper.GetOrganisationSelectList();
            //SelectedContacts = new List<ContactsGridItemVM>();
        }

        public int Id { get; set; }
        [Display(Name = "Group Name")]
        public string Name { get; set; }
        [Display(Name = "Group Description")]
        public string Description { get; set; }
    }
}