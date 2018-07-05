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
        private GenericRepository<RefResponseMethod> refResponseRepository;
        private GenericRepository<RefOutcome> refOutcomeRepository;
        private GenericRepository<RefEnquiryStatus> refEnquiryStatusRepository;
        private GenericRepository<Team> teamRepository;
        private GenericRepository<RefEnquiryType> refEnquiryTypeRepository;


        public GenericRepository<Contacts> ContactRepository => this.contactRepository ?? new GenericRepository<Contacts>(context);
        public GenericRepository<Organisations> OrganisationRepository => this.organisationRepository ?? new GenericRepository<Organisations>(context);
        public GenericRepository<Groups> GroupRepository => this.groupRepository ?? new GenericRepository<Groups>(context);
        public GenericRepository<Enquiry> EnquiryRepository => this.enquiryRepository ?? new GenericRepository<Enquiry>(context);
        public GenericRepository<RefStatus> RefStatusRepository => this.refStatusRepository ?? new GenericRepository<RefStatus>(context);
        public GenericRepository<RefResponseMethod> RefResponseMethod => this.refResponseRepository ?? new GenericRepository<RefResponseMethod>(context);
        public GenericRepository<RefOutcome> RefOutcomeRepository => this.refOutcomeRepository ?? new GenericRepository<RefOutcome>(context);
        public GenericRepository<RefEnquiryStatus> RefEnquiryStatusRepository => this.refEnquiryStatusRepository ?? new GenericRepository<RefEnquiryStatus>(context);
        public GenericRepository<Team> TeamRepository => this.teamRepository ?? new GenericRepository<Team>(context);
        public GenericRepository<RefEnquiryType> RefEnquiryTypeRepository => this.refEnquiryTypeRepository ?? new GenericRepository<RefEnquiryType>(context);


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
