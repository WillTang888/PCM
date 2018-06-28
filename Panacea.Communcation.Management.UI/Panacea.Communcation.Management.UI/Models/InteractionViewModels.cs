using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panacea.Communcation.Management.UI.Models
{
    public class EnquiryGridItemVM
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
        public string Organisation { get; set; }
        public string Contact { get; set; }
        public string Summary { get; set; }
    }
}