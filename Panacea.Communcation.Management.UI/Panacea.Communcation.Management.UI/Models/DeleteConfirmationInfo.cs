using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panacea.Communcation.Management.UI.Models
{
    public class DeleteConfirmationInfo
    {
        public string Id { get; set; } // PK of item to delete

        public string ModalTitle { get; set; } // Title of Delete Confirmation Modal

        public string DeleteAction { get; set; } // Title of Delete Confirmation Modal

        public string DeleteController { get; set; } // Title of Delete Confirmation Modal
    }
}