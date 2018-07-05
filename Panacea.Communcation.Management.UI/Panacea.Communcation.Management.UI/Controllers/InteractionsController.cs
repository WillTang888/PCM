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
            EnquiryVM model = new EnquiryVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEnquiry(EnquiryVM model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditEnquiry(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditEnquiry(EnquiryVM model)
        {
            return RedirectToAction("Enquiries");
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