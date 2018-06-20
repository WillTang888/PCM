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

        public static List<SelectListItem> GetOrganisationSelectList()
        {
            var organisationService = new OrganisationService();
            var listOfOrgs = new List<SelectListItem>();

            listOfOrgs = organisationService.GetAllActive().Select(y => new SelectListItem() {Text = y.Name, Value = y.Id.ToString()}).ToList();

            listOfOrgs.Insert(0, new SelectListItem { Text = "", Value = "" });

            return listOfOrgs;
        }
    }
}