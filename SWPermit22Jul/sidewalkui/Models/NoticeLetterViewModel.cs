using Sidewalk.Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SidewalkUI.Models
{
    public class NoticeLetterViewModel
    {
        public virtual AffidavitStatus AffidavitStatus { get; set; }
        public virtual Inspector Inspector { get; set; }
        public virtual ICollection<AffidavitHistory> AffidavitHistory { get; set; }
        public string InspectorName { get; set; }
        public string PropertyDescription { get; set; }
        public long AffidavitID { get; set; }
        public Nullable<int> InspectorId { get; set; }
        public Nullable<System.DateTime> InspectionDate { get; set; }
        //        public Nullable<int> AffidavitStatus { get; set; }
        public string Status { get; set; }
        public string VisioDiagram { get; set; }
        public string TrackIT { get; set; }
        public string RNO { get; set; }
        public string QtrSection { get; set; }
        public string PropertyID { get; set; }
        public string LegalDesc { get; set; }
        public string Owner1 { get; set; }
        public string Owner2 { get; set; }
        public string Owner3 { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerCity { get; set; }
        public string OwnerState { get; set; }
        public string OwnerZip { get; set; }
        public string SiteAddress { get; set; }
        public string SiteStreetNumber { get; set; }
        public string SiteDistrict { get; set; }
        public string SiteStreetName { get; set; }
        public string SiteStreetDesignator { get; set; }
        public string SiteCity { get; set; }
        public string SiteZip { get; set; }
        public string CityRepair { get; set; }
        public string OwnerRepair { get; set; }
        public string ContractorRepair { get; set; }
        public Nullable<System.DateTime> RepairDueDate { get; set; }
        public Nullable<System.DateTime> RepairNoticeSentDate { get; set; }
        public string RepairNoticeSentBy { get; set; }
        public string CityRepairStart { get; set; }
        public string CityRepairBy { get; set; }
        public Nullable<System.DateTime> HoldUntilDate { get; set; }
        public string HoldUntilBy { get; set; }
        public Nullable<int> permit_no { get; set; }
        public string permit_issued { get; set; }
        public string permit_extended { get; set; }
        public string contractor { get; set; }
        public string builder_board_no { get; set; }
        public Nullable<System.DateTime> date_cancelled { get; set; }
        public string cancelled_by { get; set; }
        public string last_action { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string notes { get; set; }
        public Nullable<int> VisioRevision { get; set; }
        public string New_Aff { get; set; }
        public Nullable<System.DateTime> New_RepairDueDate { get; set; }
        public Nullable<bool> NEW_ClearWalk { get; set; }
        public Nullable<System.DateTime> PermitIssuedDate { get; set; }
        public Nullable<System.DateTime> PermitExpiredDate { get; set; }
        public string CurrentOwner { get; set; }
        public string StatusValue { get; set; }
    }

    public class AffidavitDetailsViewModel
    {
        public Affidavit AffidavitInfo { get; set; }
        public CCBContractor ContractorInfo { get; set; }
        public Permit PermitInfo { get; set; }
        public PermitApplicant PermitApplicantInfo { get; set; }
        public List<sw_action_detail> PermitCostInfo { get; set; }
        public List<AffidavitAttachment> Attachments { get; set; }

    }
    public class FormFinalInspectionViewModel
    {
        public AffidavitDetailsViewModel AffidavitDetails { get; set; }
        public AffidavitFormInspection FormInspection { get; set; }
        public AffidavitFinalInspection FinalInspection { get; set; }
        public string redirectURL { get; set; }
    }
    public class AffidavitViewModel
    {
        public int aff_no { get; set; }
        public string qtr_sec { get; set; }
        public string map_id { get; set; }
        public string post_dt { get; set; }
        public Nullable<int> acct_period { get; set; }
        public string property_id { get; set; }
        public string property_id2 { get; set; }
        public string property_desc { get; set; }
        public Nullable<int> aff_status { get; set; }
        public string owner_name { get; set; }
        public string attn1 { get; set; }
        public string attn2 { get; set; }
        public string st_no { get; set; }
        public string district { get; set; }
        public string st_name { get; set; }
        public string designator { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public Nullable<int> inspector_no { get; set; }
        public string city_owned_flag { get; set; }
        public string owner_resident_flag { get; set; }
        public string service_req_flag { get; set; }
        public string rep_by_city { get; set; }
        public string rep_by_owner { get; set; }
        public string partial_repair { get; set; }
        public string vacant_lot_flag { get; set; }
        public string vacant_desc { get; set; }
        public Nullable<System.DateTime> repair_dt { get; set; }
        public Nullable<System.DateTime> billed_dt { get; set; }
        public string bill_flag { get; set; }
        public Nullable<System.DateTime> hold_until_dt { get; set; }
        public Nullable<int> permit_no { get; set; }
        public string permit_issued { get; set; }
        public string permit_extended { get; set; }
        public Nullable<System.DateTime> date_issued { get; set; }
        public Nullable<System.DateTime> date_expired { get; set; }
        public string contractor { get; set; }
        public string builder_board_no { get; set; }
        public string license_no { get; set; }
        public Nullable<System.DateTime> date_cancelled { get; set; }
        public string cancelled_by { get; set; }
        public string status { get; set; }
        public string last_action { get; set; }
        public string date_added { get; set; }
        public Nullable<System.DateTime> date_updated { get; set; }
        public string notes { get; set; }
        public Nullable<System.DateTime> sent_dt { get; set; }
        public string NEW_AFF { get; set; }
        public bool NEW_ClearWalk { get; set; }
        public Nullable<System.DateTime> NEW_RepairDueDate { get; set; }
        public string inspector_name { get; set; }
        public string fname { get; set; }
        public string PropertyDescription { get; set; }
        public string InspectorName { get; set; }
    }

    public class SearchParemeters
    {
        public string AffidavitId { get; set; }
        public string PropertyId { get; set; }
        public string InspectionDate { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string InspectorName { get; set; }
        public int StatusValue { get; set; }
        public string Owner1 { get; set; }
        public string PropertyDescription { get; set; }
    }

    public class AffidavitHistoryViewModel
    {
        public List<AffidavitHistory> AffidavitHistoryData { get; set; }
    }



}