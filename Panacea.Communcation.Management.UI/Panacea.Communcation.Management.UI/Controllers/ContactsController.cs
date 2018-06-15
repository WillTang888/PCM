using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Panacea.Communcation.Management.Business.Services;
using Panacea.Communcation.Management.UI.Models;
using Panacea.Communcation.Management.Business.EFModels;

namespace Panacea.Communcation.Management.UI.Controllers
{
    public class ContactsController : Controller
    {
        private ContactService contactService = new ContactService();

        public ActionResult Contacts()
        {
            var model = new ContactListVM();

            model.Contacts = contactService.unitOfWork.ContactRepository.Get(x => x.FkRefStatusId == 1).Select(y =>
                new ContactsGridItemVM()
                {
                    Id = y.Id,
                    Name = y.FirstName + " " + y.LastName,
                    Organisation = y.Organisations.Name,
                    JobTitle = y.JobTitle,
                    Email = y.Email,
                    Country = y.Country
                }).ToList();

            return View(model);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AddContact(AddContactVm model)
        {
            if (ModelState.IsValid)
            {
                //convert model to ef model
                Contacts eFContact = new Contacts();
                eFContact.Id = 0;
                eFContact.Title = model.Title;
                eFContact.FirstName = model.FirstName;
                eFContact.LastName = model.LastName;
                eFContact.FkOrganisationId = model.OrganisationId;
                eFContact.JobTitle = model.JobTitle;
                eFContact.Phone = model.Phone;
                eFContact.Mobile = model.Mobile;
                eFContact.Email = model.Email;
                eFContact.Address1 = model.Address1;
                eFContact.Address2 = model.Address2;
                eFContact.Address3 = model.Address3;
                eFContact.City = model.City;
                eFContact.County = model.County;
                eFContact.Postcode = model.Postcode;
                eFContact.Country = model.Country;
                eFContact.FkRefStatusId = (int)StatusEnum.Active;
                contactService.unitOfWork.ContactRepository.Insert(eFContact);
                contactService.unitOfWork.Save();

                return Json(new { status = CommonConstants.Ok, message = CommonConstants.AddedSuccessfully });
            }

            return Json(new { status = CommonConstants.Error, message = CommonConstants.SomethingWentWrong });
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