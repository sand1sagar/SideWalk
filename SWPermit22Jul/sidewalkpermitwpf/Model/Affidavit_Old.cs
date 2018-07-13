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
    
    public partial class Affidavit_Old
    {
        public long AffidavitId { get; set; }
        public long AffidavitNumber { get; set; }
        public string QTRSection { get; set; }
        public string MapId { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<bool> AffidavitStatus { get; set; }
        public Nullable<long> InspectorNo { get; set; }
        public Nullable<bool> RepaireByCity { get; set; }
        public Nullable<bool> RepaireByOwner { get; set; }
        public Nullable<bool> PartialRepair { get; set; }
        public Nullable<System.DateTime> RepairDate { get; set; }
        public Nullable<System.DateTime> HoldDate { get; set; }
        public string ContractorName { get; set; }
        public string BuilderBoardNumber { get; set; }
        public Nullable<System.DateTime> DateCancelled { get; set; }
        public string CancelledBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> SentDate { get; set; }
        public string NEW_AFF { get; set; }
        public Nullable<System.DateTime> NEW_RepairDueDate { get; set; }
        public Nullable<bool> NEW_ClearWalk { get; set; }
    }
}