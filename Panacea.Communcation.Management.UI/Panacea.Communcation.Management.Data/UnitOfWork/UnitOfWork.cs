using Panacea.Communcation.Management.Business.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Communcation.Management.Business.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private PCMEntities context = new PCMEntities();
        private GenericRepository<RefStatus> refStatusRepository;

        public GenericRepository<RefStatus> RefStatusRepository
        {
            get
            {
                return this.refStatusRepository ?? new GenericRepository<RefStatus>(context);
            }
        }

      
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
