using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panacea.Communcation.Management.Business.EFModels;

namespace Panacea.Communcation.Management.Business.Services
{
    public class OrganisationService : IDisposable
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public List<Organisations> GetAllActive()
        {
            return unitOfWork.OrganisationRepository.Get(x => x.FkRefStatusId == 1).ToList();
        }

        public Organisations GetById(int id)
        {
            return unitOfWork.OrganisationRepository.GetByID(id);
        }
        public List<Organisations> GetOrganisationsForGrid()
        {
            return unitOfWork.OrganisationRepository.Get(x => x.FkRefStatusId == 1).ToList();
        }

        public Organisations Insert(Organisations org)
        {
            var organisation = unitOfWork.OrganisationRepository.Insert(org);
            unitOfWork.Save();
            return organisation;
        }

        public void Update(Organisations org)
        {
            unitOfWork.OrganisationRepository.Update(org);
            unitOfWork.Save();
        }

        public void DeleteById(int id)
        {
            unitOfWork.OrganisationRepository.Delete(id);
            unitOfWork.Save();
        }

        public void Dispose()
        {
            ((IDisposable)unitOfWork).Dispose();
        }
    }
}

