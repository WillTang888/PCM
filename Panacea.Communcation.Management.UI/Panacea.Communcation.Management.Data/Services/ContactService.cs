using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Communcation.Management.Business.Services
{
    public class ContactService : IDisposable
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public void Dispose()
        {
            ((IDisposable) unitOfWork).Dispose();
        }
    }
}
