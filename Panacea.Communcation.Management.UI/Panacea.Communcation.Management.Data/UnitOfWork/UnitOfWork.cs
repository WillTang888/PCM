using Panacea.Communcation.Management.Business.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Communcation.Management.Business
{
    public class UnitOfWork : IDisposable
    {
        private PCMEntities context = new PCMEntities();

        private GenericRepository<Contacts> contactRepository;
        private GenericRepository<Organisations> organisationRepository;
        private GenericRepository<Groups> groupRepository;
        private GenericRepository<Enquiry> enquiryRepository;
        private GenericRepository<RefStatus> refStatusRepository;

        public GenericRepository<Contacts> ContactRepository => this.contactRepository ?? new GenericRepository<Contacts>(context);
        public GenericRepository<Organisations> OrganisationRepository => this.organisationRepository ?? new GenericRepository<Organisations>(context);
        public GenericRepository<Groups> GroupRepository => this.groupRepository ?? new GenericRepository<Groups>(context);
        public GenericRepository<Enquiry> EnquiryRepository => this.enquiryRepository ?? new GenericRepository<Enquiry>(context);
        public GenericRepository<RefStatus> RefStatusRepository => this.refStatusRepository ?? new GenericRepository<RefStatus>(context);


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
