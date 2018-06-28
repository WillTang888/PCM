using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panacea.Communcation.Management.UI.Models;

namespace Panacea.Communcation.Management.UI.Controllers
{
    public class InteractionsController : Controller
    {
        // GET: Interactions
        public ActionResult Enquiries()
        {
            List<EnquiryGridItemVM> model = new List<EnquiryGridItemVM>();
            return View(model);
        }

        public ActionResult AddEnquiry()
        {         
            return View();
        }



        // GET: Interactions
        public ActionResult Projects()
        {
            return View();
        }


        // GET: Interactions
        public ActionResult Releases()
        {
            return View();
        }


        // GET: Interactions
        public ActionResult Assets()
        {
            return View();
        }
    }
}