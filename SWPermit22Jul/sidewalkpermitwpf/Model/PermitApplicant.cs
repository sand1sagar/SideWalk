//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SidewalkPermitWPF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PermitApplicant
    {
        public PermitApplicant()
        {
            this.Permit = new HashSet<Permit>();
        }
    
        public long ApplicantID { get; set; }
        public string ApplicantType { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Nullable<long> PermitID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ContactPhoneNumber { get; set; }
    
        public virtual ICollection<Permit> Permit { get; set; }
    }
}
