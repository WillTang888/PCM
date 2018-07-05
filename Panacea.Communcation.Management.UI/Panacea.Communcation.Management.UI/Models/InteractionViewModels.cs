using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panacea.Communcation.Management.UI.Helpers;

namespace Panacea.Communcation.Management.UI.Models
{
    public class EnquiryGridItemVM
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
        public string Organisation { get; set; }
        public string Contact { get; set; }
        public string Summary { get; set; }
    }


    // Use for Add Edit
    public class EnquiryVM
    {
        public EnquiryVM()
        {
            ContactList = DownDownListHelper.GetContactsSelectList();
            OganisationList = DownDownListHelper.GetOrganisationSelectList();
            ResponseMethodList = DownDownListHelper.GetEnquiryResponseSelectList();
            OutComeList = DownDownListHelper.GetEnquiryOutcomeSelectList();
            EnquiryStatusList = DownDownListHelper.GetEnquiryStatusSelectList();
            TeamList = DownDownListHelper.GetEnquiryTeamsSelectList();
            UserList = DownDownListHelper.GetEnquiryUsersSelectList();
            EnquiryTypeList = DownDownListHelper.GetEnquiryTypeSelectList();
        }

        public List<SelectListItem> ContactList;
        public List<SelectListItem> OganisationList;
        public List<SelectListItem> ResponseMethodList;
        public List<SelectListItem> OutComeList;
        public List<SelectListItem> EnquiryStatusList;
        public List<SelectListItem> TeamList;
        public List<SelectListItem> UserList;
        public List<SelectListItem> EnquiryTypeList;

        public int Id { get; set; }

        [Required]
        [Display(Name = "Contact")]
        public int ContactId { get; set; }

        [Required]
        [Display(Name = "Organisation")]
        public int OrganisationId { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        [Display(Name = "Enquiry")]
        public string Description { get; set; }

        [Display(Name = "Internal Notes")]
        public string InternalNotes { get; set; }

        public string Response { get; set; }
        public string Responder { get; set; }
        public DateTime ReturnedDate { get; set; }
        public int ResponseMethodId { get; set; }
        public int OutComeId { get; set; }

        [Display(Name = "Status")]
        public int EnquiryStatusId { get; set; }

        [Display(Name = "Team")]
        public int TeamId { get; set; }

        [Display(Name = "User")]
        public string UserId { get; set; }

        [Display(Name = "Type")]
        public string EnquiryTypeId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}