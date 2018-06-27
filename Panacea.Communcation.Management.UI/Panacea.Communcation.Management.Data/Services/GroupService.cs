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
            unitOfWork.GroupRepository.Update(grp);
            unitOfWork.Save();
        }

        public void DeleteById(int id)
        {
            unitOfWork.GroupRepository.Delete(id);
        }

        public Contacts GetContactById(int id)
        {
            return unitOfWork.ContactRepository.GetByID(id);
        }

        public Organisations GetOrganisationById(int id)
        {
            return unitOfWork.OrganisationRepository.GetByID(id);
        }
        
        public void RemoveAllContacts(int id)
        {
            var group = GetById(id);
            var groupContacts = group.Contacts.ToList();

            foreach (var contact in groupContacts)
            {
                group.Contacts.Remove(contact);
            }

            unitOfWork.Save();
        }

        public void RemoveAllOrganisations(int id)
        {
            var group = GetById(id);
            var groupOrganisations = group.Organisations.ToList();

            foreach (var org in groupOrganisations)
            {
                group.Organisations.Remove(org);
            }

            unitOfWork.Save();
        }

        public void Dispose()
        {
            ((IDisposable)unitOfWork).Dispose();
        }
    }
}
