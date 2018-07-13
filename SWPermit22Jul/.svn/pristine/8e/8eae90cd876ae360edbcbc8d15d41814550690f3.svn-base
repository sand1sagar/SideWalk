using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidewalkPermitWPF.Model
{
    public partial class sw_posting
    {
        public int aff_no { get; set; }
        public string qtr_sec { get; set; }
        public string map_id { get; set; }
        public Nullable<System.DateTime> post_dt { get; set; }
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
        public Nullable<System.DateTime> date_added { get; set; }
        public Nullable<System.DateTime> date_updated { get; set; }
        public string notes { get; set; }
        public Nullable<System.DateTime> sent_dt { get; set; }
        public string NEW_AFF { get; set; }
        public bool NEW_ClearWalk { get; set; }
        public Nullable<System.DateTime> NEW_RepairDueDate { get; set; }
        public string inspector_name { get; set; }
        public string fname { get; set; }
    }
    /// <summary>
    /// consolidated permit model
    /// </summary>
    public class PermitModel
    {
        public Permit Permit { get; set; }
        public sw_posting Affidavit { get; set; }
        public CCBContractor Contractor { get; set; }
        public PermitApplicant Applicant { get; set; }
        public List<sw_action_detail> AffidavitCostDetails { get; set; }
        public bool IsChecked { get; set; }
        public string FullAddress { get; set; }

    }
    /// <summary>
    /// contractor model for sql and oracle
    /// </summary>
    public class CCBContractor
    {
        public string business_name { get; set; }
        public string rmi_name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string business_telephone { get; set; }
        public string license_number { get; set; }
        public long ccb_number { get; set; }
        public string alias_name { get; set; }
    }
    /// <summary>
    /// permit history model
    /// </summary>
    public class ApplicantPermitHistory
    {
        public int AppliedPermits { get; set; }
        public int ExpiredPermits { get; set; }
        public int ExpiringSoon { get; set; }
    }
    /// <summary>
    /// sidewalk post model
    /// </summary>
    public class sw_action_detail
    {
        public int aff_no { get; set; }
        public string action { get; set; }
        public string action_type { get; set; }
        public decimal unit { get; set; }
        public decimal cost { get; set; }
        public decimal rate { get; set; }

    }
    /// <summary>
    /// permit application cart
    /// </summary>
    public class AffidavitCart
    {
        public string AffidavitID { get; set; }
        public string PropertyAddress { get; set; }
        public string Remove { get; set; }
        public string PermitID { get; set; }
    }
    #region Contractor Permits
    public class ContractorPermit
    {
        public long Affidavit { get; set; }
        public string NEW_AFF { get; set; }
        public string Fee { get; set; }
        public string PropertyAddress { get; set; }
        public long PetmitID { get; set; }
        public bool IsSelected { get; set; }
        public string ExpirationDate { get; set; }
    }
    #endregion
    //auto complete model
    public class AutoCompleteEntry
    {
        private string[] keywordStrings;
        private string displayString;

        public string[] KeywordStrings
        {
            get
            {
                if (keywordStrings == null)
                {
                    keywordStrings = new string[] { displayString };
                }
                return keywordStrings;
            }
        }

        public string DisplayName
        {
            get { return displayString; }
            set { displayString = value; }
        }

        public AutoCompleteEntry(string name, params string[] keywords)
        {
            displayString = name;
            keywordStrings = keywords;
        }

        public override string ToString()
        {
            return displayString;
        }


    }
}
