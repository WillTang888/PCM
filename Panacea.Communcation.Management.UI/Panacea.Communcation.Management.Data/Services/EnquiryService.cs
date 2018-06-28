using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panacea.Communcation.Management.Business.EFModels;

namespace Panacea.Communcation.Management.Business.Services
{
    public class EnquiryService
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public List<Enquiry> GetAllActive()
        {
            return unitOfWork.EnquiryRepository.Get(x => x.FkRefStatusId == 1).ToList();
        }

        public Enquiry GetById(int id)
        {
            return unitOfWork.EnquiryRepository.GetByID(id);
        }

        public List<Enquiry> GetContactsForGrid()
        {
            return unitOfWork.EnquiryRepository.Get(x => x.FkRefStatusId == 1, null, "Organisations").ToList();
        }

        public Contacts Insert(Contacts contact)
        {
            contact = unitOfWork.ContactRepository.Insert(contact);
            unitOfWork.Save();
            return contact;
        }

        public void Update(Contacts contact)
        {
            unitOfWork.ContactRepository.Update(contact);
            unitOfWork.Save();
        }

        public void DeleteById(int id)
        {
            unitOfWork.ContactRepository.Delete(id);
            unitOfWork.Save();
        }

        public List<Contacts> SearchContacts(string searchString)
        {
            string lcSearchString = searchString.ToLower();
            return unitOfWork.ContactRepository.Get(x => x.FkRefStatusId == 1 && (x.FirstName.ToLower().Contains(lcSearchString) ||
                                                                                  x.LastName.ToLower().Contains(lcSearchString) ||
                                                                                  x.Organisations.Name.ToLower().Contains(lcSearchString))
            ).ToList();
        }


        public void Dispose()
        {
            ((IDisposable)unitOfWork).Dispose();
        }
    }
}
