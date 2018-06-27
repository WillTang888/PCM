using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panacea.Communcation.Management.Business.EFModels;

namespace Panacea.Communcation.Management.Business.Services
{
    public class GroupService : IDisposable
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public List<Groups> GetAllActive()
        {
            return unitOfWork.GroupRepository.Get(x => x.FkRefStatusId == 1).ToList();
        }

        public Groups GetById(int id)
        {
            return unitOfWork.GroupRepository.GetByID(id);
        }
        public List<Groups> GetGroupsForGrid()
        {
            return unitOfWork.GroupRepository.Get(x => x.FkRefStatusId == 1).ToList();
        }

        public Groups Insert(Groups grp)
        {
            var group = unitOfWork.GroupRepository.Insert(grp);
            unitOfWork.Save();
            return group;
        }

        public void Update(Groups grp)
        {

        }

        public void DeleteById(int id)
        {

        }

        public Contacts GetContactById(int id)
        {
            return unitOfWork.ContactRepository.GetByID(id);
        }

        public Organisations GetOrganisationById(int id)
        {
            return unitOfWork.OrganisationRepository.GetByID(id);
        }

        public void Dispose()
        {
            ((IDisposable)unitOfWork).Dispose();
        }
    }
}
