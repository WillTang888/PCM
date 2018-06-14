using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Panacea.Communcation.Management.UI.Helpers
{
    public static class DownDownListHelper
    {
        public static List<SelectListItem> GetTitleSelectList()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() {Value = "Mr", Text = "Mr"},
                new SelectListItem() {Value = "Mrs", Text = "Mrs"},
                new SelectListItem() {Value = "Miss", Text = "Miss"}
            };
        }

        public static List<SelectListItem> GetCountrySelectList()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() {Value = "United Kingdom", Text = "United Kingdom"},
                new SelectListItem() {Value = "France", Text = "France"},
                new SelectListItem() {Value = "Spain", Text = "Spain"}
            };
        }
    }
}