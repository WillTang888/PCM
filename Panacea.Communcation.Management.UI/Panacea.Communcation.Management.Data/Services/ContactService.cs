using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panacea.Communcation.Management.Business.EFModels;

namespace Panacea.Communcation.Management.Business.Services
{
    public class ContactService : IDisposable
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public Contacts GetById(int id)
        {
            return unitOfWork.ContactRepository.GetByID(id);
        }

        public List<Contacts> GetContactsForGrid()
        {
            return unitOfWork.ContactRepository.Get(x => x.FkRefStatusId == 1, null, "Organisations").ToList();
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

        public void Dispose()
        {
            ((IDisposable) unitOfWork).Dispose();
        }
    }
}
