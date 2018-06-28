//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Panacea.Communcation.Management.Business.EFModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enquiry
    {
        public int Id { get; set; }
        public int FkContactId { get; set; }
        public int FkOrganisationId { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string InternalNotes { get; set; }
        public string Response { get; set; }
        public string Responder { get; set; }
        public Nullable<System.DateTime> ReturnedDate { get; set; }
        public Nullable<int> FkRefResponseMethodId { get; set; }
        public Nullable<int> FkRefOutcomeId { get; set; }
        public int FkRefEnquiryStatusId { get; set; }
        public string FkUserId { get; set; }
        public int FkTeamId { get; set; }
        public Nullable<int> FkEnquiryTypeId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public System.DateTime DeadlineDate { get; set; }
        public Nullable<int> FkRelatedProjectId { get; set; }
        public Nullable<int> FkRelatedReleaseId { get; set; }
        public Nullable<int> FkRefStatusId { get; set; }
    
        public virtual Contacts Contacts { get; set; }
        public virtual RefEnquiryType RefEnquiryType { get; set; }
        public virtual Organisations Organisations { get; set; }
        public virtual RefEnquiryStatus RefEnquiryStatus { get; set; }
        public virtual RefOutcome RefOutcome { get; set; }
        public virtual RefResponseMethod RefResponseMethod { get; set; }
        public virtual Team Team { get; set; }
        public virtual RefStatus RefStatus { get; set; }
    }
}
