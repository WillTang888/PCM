using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panacea.Communcation.Management.UI.Models;

namespace Panacea.Communcation.Management.UI.Controllers
{
    public class ContactsController : Controller
    {

        public ActionResult Contacts()
        {
            var model = new AddContactVm();
            return View(model);
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddContact()
        {
            return null;
        }

        public ActionResult Organisations()
        {
            return View();
        }

        public ActionResult Groups()
        {
            return View();
        }
    }
}