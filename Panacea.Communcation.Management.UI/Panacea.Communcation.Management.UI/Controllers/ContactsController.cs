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

            model.Contacts = contactService.GetContactsForGrid().Select(y =>
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
                try
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
                    contactService.Insert(eFContact);
                    return Json(new { status = CommonConstants.Ok, message = CommonConstants.AddedSuccessfully });
                }
                catch (Exception e)
                {
                    return Json(new { status = CommonConstants.Ok, message = CommonConstants.SomethingWentWrong });
                }              
            }
            else
            {
                return Json(new { status = CommonConstants.Error, message = CommonConstants.FailedValidation });
            }     
        }


        [HttpGet]
        public PartialViewResult EditContact(int id)
        {
            Contacts eFContact = contactService.GetById(id);
            EditContactVm model = new EditContactVm();
            model.Id = id;
            model.Title = eFContact.Title;
            model.FirstName = eFContact.FirstName;
            model.LastName = eFContact.LastName;
            model.OrganisationId = eFContact.FkOrganisationId;
            model.JobTitle = eFContact.JobTitle;
            model.Phone = eFContact.Phone;
            model.Mobile = eFContact.Mobile;
            model.Email = eFContact.Email;
            model.Address1 = eFContact.Address1;
            model.Address2 = eFContact.Address2;
            model.Address3 = eFContact.Address3;
            model.City = eFContact.City;
            model.County = eFContact.County;
            model.Postcode = eFContact.Postcode;
            model.Country = eFContact.Country;

            return PartialView("_ModalEditContact", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult EditContact(EditContactVm model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //convert model to ef model
                    Contacts eFContact = new Contacts();
                    eFContact.Id = model.Id;
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

                    contactService.Update(eFContact);
                    return Json(new { status = CommonConstants.Ok, message = CommonConstants.Ok });
                }
                catch (Exception e)
                {
                    return Json(new { status = CommonConstants.Error, message = CommonConstants.SomethingWentWrong });
                }
            }
            else
            {
                return Json(new { status = CommonConstants.Error, message = CommonConstants.FailedValidation });
            }            
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