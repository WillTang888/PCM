using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panacea.Communcation.Management.Business.Services;

namespace Panacea.Communcation.Management.UI.Helpers
{
    public static class DownDownListHelper
    {
        public static List<SelectListItem> GetTitleSelectList()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem { Text = "", Value = "" },
                new SelectListItem() {Value = "Mr", Text = "Mr"},
                new SelectListItem() {Value = "Mrs", Text = "Mrs"},
                new SelectListItem() {Value = "Miss", Text = "Miss"}
            };
        }

        public static List<SelectListItem> GetCountrySelectList()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem { Text = "", Value = "" },
                new SelectListItem() {Value = "United Kingdom", Text = "United Kingdom"},
                new SelectListItem() {Value = "France", Text = "France"},
                new SelectListItem() {Value = "Spain", Text = "Spain"}
            };
        }

        public static List<SelectListItem> GetContactsSelectList()
        {
            var contactService = new ContactService();

            var listOfContacts = contactService.GetAllActive().Select(y => new SelectListItem() { Text = y.FirstName + " " + y.LastName, Value = y.Id.ToString() }).ToList();
            listOfContacts.Insert(0, new SelectListItem { Text = "", Value = "0" });

            return listOfContacts;
        }

        public static List<SelectListItem> GetOrganisationSelectList()
        {
            var organisationService = new OrganisationService();
            var listOfOrgs = new List<SelectListItem>();

            listOfOrgs = organisationService.GetAllActive().Select(y => new SelectListItem() { Text = y.Name, Value = y.Id.ToString() }).ToList();
            listOfOrgs.Insert(0, new SelectListItem { Text = "", Value = "" });

            return listOfOrgs;
        }

        #region "Enquiries lookup"

        public static List<SelectListItem> GetEnquiryResponseSelectList()
        {
            var enquiryService = new EnquiryService();
            var listOfEnquiryResponseTypes = new List<SelectListItem>();

            listOfEnquiryResponseTypes = enquiryService.GetEnquiryResponseMethods().Select(y => new SelectListItem() { Text = y.Description, Value = y.Id.ToString() }).ToList();
            listOfEnquiryResponseTypes.Insert(0, new SelectListItem { Text = "", Value = "" });

            return listOfEnquiryResponseTypes;
        }

        public static List<SelectListItem> GetEnquiryOutcomeSelectList()
        {
            var enquiryService = new EnquiryService();
            var listOfEnquiryOutcomes = new List<SelectListItem>();

            listOfEnquiryOutcomes = enquiryService.GetEnquiryOutcomes().Select(y => new SelectListItem() { Text = y.Description, Value = y.Id.ToString() }).ToList();
            listOfEnquiryOutcomes.Insert(0, new SelectListItem { Text = "", Value = "" });

            return listOfEnquiryOutcomes;
        }

        public static List<SelectListItem> GetEnquiryStatusSelectList()
        {
            var enquiryService = new EnquiryService();
            var listOfEnquiryStatuses = new List<SelectListItem>();

            listOfEnquiryStatuses = enquiryService.GetEnquiryStatuses().Select(y => new SelectListItem() { Text = y.Description, Value = y.Id.ToString() }).ToList();
            listOfEnquiryStatuses.Insert(0, new SelectListItem { Text = "", Value = "" });

            return listOfEnquiryStatuses;
        }

        public static List<SelectListItem> GetEnquiryTeamsSelectList()
        {
            var enquiryService = new EnquiryService();
            var listOfEnquiryTeams = new List<SelectListItem>();

            listOfEnquiryTeams = enquiryService.GetEnquiryTeams().Select(y => new SelectListItem() { Text = y.Description, Value = y.Id.ToString() }).ToList();
            listOfEnquiryTeams.Insert(0, new SelectListItem { Text = "", Value = "" });

            return listOfEnquiryTeams;
        }

        public static List<SelectListItem> GetEnquiryTypeSelectList()
        {
            var enquiryService = new EnquiryService();
            var listOfEnquiryTypes = new List<SelectListItem>();

            listOfEnquiryTypes = enquiryService.GetEnquiryTypes().Select(y => new SelectListItem() { Text = y.Description, Value = y.Id.ToString() }).ToList();
            listOfEnquiryTypes.Insert(0, new SelectListItem { Text = "", Value = "" });

            return listOfEnquiryTypes;
        }

        public static List<SelectListItem> GetEnquiryUsersSelectList()
        {
            var listOfUsers = new List<SelectListItem>();
            listOfUsers.Add(new SelectListItem { Text = "Will", Value = "Will" });
            listOfUsers.Add(new SelectListItem { Text = "Bill", Value = "Bill" });
            listOfUsers.Add(new SelectListItem { Text = "Hill", Value = "Hill" });
            listOfUsers.Insert(0, new SelectListItem { Text = "", Value = "" });

            return listOfUsers;
        }
        #endregion "Enquiries lookup"
    }
}