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

        public Enquiry Insert(Enquiry enquiry)
        {
            enquiry = unitOfWork.EnquiryRepository.Insert(enquiry);
            unitOfWork.Save();
            return enquiry;
        }

        public void Update(Enquiry enquiry)
        {
            unitOfWork.EnquiryRepository.Update(enquiry);
            unitOfWork.Save();
        }

        public void DeleteById(int id)
        {
            unitOfWork.EnquiryRepository.Delete(id);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            ((IDisposable)unitOfWork).Dispose();
        }
    }
}
