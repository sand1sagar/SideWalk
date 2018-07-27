using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sidewalk.Logic.Database;
using System.Data.SqlClient;
using System.Data;
using Sidewalk.Logic.Caching;
using AutoMapper;


namespace Sidewalk.Logic
{
    public class AffidavitLogic
    {
        log4net.ILog Log = log4net.LogManager.GetLogger(typeof(AffidavitLogic));
        SWPostEntities context = new SWPostEntities();
        public AffidavitLogic()
        {
            context.Configuration.LazyLoadingEnabled = false;
            context.Configuration.ProxyCreationEnabled = false;
        }

        /// <summary>
        /// this method will get list of affidavit
        /// </summary>
        /// <returns></returns>
        //public List<sw_posting> GetAffidavitList()
        //{
        //    List<sw_posting> result = new List<sw_posting>();

        public List<Affidavit> GetAffidavitList()
        {
            List<Affidavit> result = new List<Affidavit>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    //using (SqlCommand cmd = new SqlCommand("getAffidavitList", con))
                    using (SqlCommand cmd = new SqlCommand("sp_getAffidavitList_swp", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Affidavit affidavit = new Affidavit();
                                affidavit.AffidavitID = String.IsNullOrEmpty(dataReader["AffidavitID"].ToString()) ? 0 : int.Parse(dataReader["AffidavitID"].ToString());
                                affidavit.InspectorId = String.IsNullOrEmpty(dataReader["InspectorId"].ToString()) ? 0 : int.Parse(dataReader["InspectorId"].ToString());
                                affidavit.InspectionDate = String.IsNullOrEmpty(dataReader["InspectionDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["InspectionDate"].ToString());
                                affidavit.Status = String.IsNullOrEmpty(dataReader["Status"].ToString()) ? 0 : int.Parse(dataReader["Status"].ToString());
                                affidavit.VisioDiagram = dataReader["VisioDiagram"] + "";
                                affidavit.TrackIT = dataReader["TrackIT"] + "";
                                affidavit.RNO = dataReader["RNO"] + "";
                                affidavit.QtrSection = dataReader["QtrSection"] + "";
                                affidavit.PropertyID = dataReader["PropertyID"] + "";
                                affidavit.LegalDesc = dataReader["LegalDesc"] + "";
                                affidavit.Owner1 = dataReader["Owner1"] + "";
                                affidavit.Owner2 = dataReader["Owner2"] + "";
                                affidavit.Owner3 = dataReader["Owner3"] + "";
                                affidavit.OwnerAddress = dataReader["OwnerAddress"] + "";
                                affidavit.OwnerCity = dataReader["OwnerCity"] + "";
                                affidavit.OwnerState = dataReader["OwnerState"] + "";
                                affidavit.OwnerZip = dataReader["OwnerZip"] + "";
                                affidavit.SiteAddress = dataReader["SiteAddress"] + "";
                                affidavit.SiteStreetNumber = dataReader["SiteStreetNumber"] + "";
                                affidavit.SiteDistrict = dataReader["SiteDistrict"] + "";
                                affidavit.SiteStreetName = dataReader["SiteStreetName"] + "";
                                affidavit.SiteStreetDesignator = dataReader["SiteStreetDesignator"] + "";
                                affidavit.SiteCity = dataReader["SiteCity"] + "";
                                affidavit.SiteZip = dataReader["SiteZip"] + "";
                                affidavit.CityRepair = dataReader["CityRepair"] + "";
                                affidavit.OwnerRepair = dataReader["OwnerRepair"] + "";
                                affidavit.ContractorRepair = dataReader["ContractorRepair"] + "";
                                affidavit.RepairDueDate = String.IsNullOrEmpty(dataReader["RepairDueDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["RepairDueDate"].ToString());
                                affidavit.RepairNoticeSentDate = String.IsNullOrEmpty(dataReader["RepairNoticeSentDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["RepairNoticeSentDate"].ToString());
                                affidavit.RepairNoticeSentBy = dataReader["RepairNoticeSentBy"] + "";
                                affidavit.CityRepairStart = dataReader["CityRepairStart"] + "";
                                affidavit.CityRepairBy = dataReader["CityRepairBy"] + "";
                                affidavit.HoldUntilDate = String.IsNullOrEmpty(dataReader["HoldUntilDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["HoldUntilDate"].ToString());
                                affidavit.HoldUntilBy = dataReader["HoldUntilBy"] + "";
                                affidavit.permit_no = String.IsNullOrEmpty(dataReader["permit_no"].ToString()) ? 0 : int.Parse(dataReader["permit_no"].ToString());
                                affidavit.permit_issued = dataReader["permit_issued"] + "";
                                affidavit.permit_extended = dataReader["permit_extended"] + "";
                                affidavit.PermitIssuedDate = String.IsNullOrEmpty(dataReader["PermitIssuedDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["PermitIssuedDate"].ToString());
                                affidavit.PermitExpiredDate = String.IsNullOrEmpty(dataReader["PermitExpiredDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["PermitExpiredDate"].ToString());
                                affidavit.contractor = dataReader["contractor"] + "";
                                affidavit.builder_board_no = dataReader["builder_board_no"] + "";
                                affidavit.date_cancelled = String.IsNullOrEmpty(dataReader["date_cancelled"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_cancelled"].ToString());
                                affidavit.cancelled_by = dataReader["cancelled_by"] + "";
                                affidavit.last_action = dataReader["last_action"] + "";
                                affidavit.CreateDate = String.IsNullOrEmpty(dataReader["CreateDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["CreateDate"].ToString());
                                affidavit.LastModifiedDate = String.IsNullOrEmpty(dataReader["LastModifiedDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["LastModifiedDate"].ToString());
                                affidavit.LastModifiedBy = dataReader["LastModifiedBy"] + "";
                                affidavit.notes = dataReader["notes"] + "";
                                affidavit.VisioRevision = String.IsNullOrEmpty(dataReader["VisioRevision"].ToString()) ? 0 : int.Parse(dataReader["VisioRevision"].ToString());
                                affidavit.New_Aff = dataReader["New_Aff"] + "";
                                affidavit.New_RepairDueDate = String.IsNullOrEmpty(dataReader["New_RepairDueDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["New_RepairDueDate"].ToString());
                                affidavit.NEW_ClearWalk = String.IsNullOrEmpty(dataReader["NEW_ClearWalk"].ToString()) ? false : Convert.ToBoolean(dataReader["NEW_ClearWalk"]);

                                result.Add(affidavit);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                result = null;
            }
            return result;
        }

        public List<AffidavitAttachment> GetAffidavitAttachments(string affidavitId)
        {
            List<AffidavitAttachment> result = new List<AffidavitAttachment>();
            try
            {
                long affId = long.Parse(affidavitId);
                result = context.AffidavitAttachment.Where(x => x.AffidavitId == affId).OrderByDescending(x => x.CreatedDate).ToList();
            }
            catch (Exception ex)
            {
            }
            return result;
        }


        public bool DeleteAffidavitAttachment(long attachmentId)
        {
            bool result = false;
            try
            {
                var existingItem = context.AffidavitAttachment.Where(x => x.AttachmentId == attachmentId).FirstOrDefault();
                if (existingItem != null)
                    context.AffidavitAttachment.Remove(existingItem);
                context.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        public bool UploadAffidavitAttachment(List<AffidavitAttachment> model)
        {
            bool result = false;
            try
            {
                //foreach (var item in model)
                //{
                //    var existingItem = context.AffidavitAttachment.Where(x => x.AffidavitId == item.AffidavitId).ToList();
                //    if (existingItem != null)
                //        context.AffidavitAttachment.RemoveRange(existingItem);
                //    context.SaveChanges();
                //}
                context.AffidavitAttachment.AddRange(model);
                context.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// this method will get affidavit details of affidavit
        /// </summary>
        /// <param name="affidavitID"></param>
        /// <returns></returns>
        public sw_posting GetAffidavitDetails(string affidavitID)
        {
            sw_posting affidavit = new sw_posting();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("getAffidavitDetails", con))
                    {
                        cmd.Parameters.AddWithValue("@affidavitId", SqlDbType.NVarChar).Value = affidavitID;
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                affidavit.aff_no = String.IsNullOrEmpty(dataReader["aff_no"].ToString()) ? 0 : int.Parse(dataReader["aff_no"].ToString());
                                affidavit.NEW_AFF = dataReader["NEW_AFF"].ToString();
                                affidavit.qtr_sec = dataReader["qtr_sec"].ToString();
                                affidavit.InspectorName = dataReader["InspectorName"].ToString();
                                affidavit.PropertyDescription = dataReader["PropertyDescription"].ToString();
                                affidavit.map_id = dataReader["map_id"].ToString();
                                affidavit.post_dt = String.IsNullOrEmpty(dataReader["post_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["post_dt"].ToString());// DateTime.Parse(dataReader["post_dt"].ToString());
                                affidavit.acct_period = String.IsNullOrEmpty(dataReader["acct_period"].ToString()) ? 0 : int.Parse(dataReader["acct_period"].ToString());
                                affidavit.property_id = dataReader["property_id"].ToString();
                                affidavit.property_id2 = dataReader["property_id2"].ToString();
                                affidavit.property_desc = dataReader["property_desc"].ToString();
                                affidavit.aff_status = String.IsNullOrEmpty(dataReader["aff_status"].ToString()) ? 0 : int.Parse(dataReader["aff_status"].ToString());
                                affidavit.owner_name = dataReader["owner_name"].ToString();
                                affidavit.attn1 = dataReader["attn1"].ToString();
                                affidavit.attn2 = dataReader["attn2"].ToString();
                                affidavit.st_no = dataReader["st_no"].ToString();
                                affidavit.district = dataReader["district"].ToString();
                                affidavit.st_name = dataReader["st_name"].ToString();
                                affidavit.designator = dataReader["designator"].ToString();
                                affidavit.city = dataReader["city"].ToString();
                                affidavit.zip = dataReader["zip"].ToString();
                                //affidavit.inspector_no = String.IsNullOrEmpty(dataReader["inspector_no"].ToString()) ? 0 : int.Parse(dataReader["inspector_no"].ToString());
                                affidavit.inspector_name = dataReader["inspector_name"].ToString();
                                affidavit.city_owned_flag = dataReader["city_owned_flag"].ToString();
                                affidavit.owner_resident_flag = dataReader["owner_resident_flag"].ToString();
                                affidavit.service_req_flag = dataReader["service_req_flag"].ToString();
                                affidavit.rep_by_city = dataReader["rep_by_city"].ToString();
                                affidavit.rep_by_owner = dataReader["rep_by_owner"].ToString();
                                affidavit.partial_repair = dataReader["partial_repair"].ToString();
                                affidavit.vacant_lot_flag = dataReader["vacant_lot_flag"].ToString();
                                affidavit.vacant_desc = dataReader["vacant_desc"].ToString();
                                affidavit.repair_dt = String.IsNullOrEmpty(dataReader["repair_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["repair_dt"].ToString());// DateTime.Parse(dataReader["repair_dt"].ToString());
                                affidavit.billed_dt = String.IsNullOrEmpty(dataReader["billed_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["billed_dt"].ToString());// DateTime.Parse(dataReader["billed_dt"].ToString());
                                affidavit.bill_flag = dataReader["bill_flag"].ToString();
                                affidavit.hold_until_dt = String.IsNullOrEmpty(dataReader["hold_until_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["hold_until_dt"].ToString());// DateTime.Parse(dataReader["hold_until_dt"].ToString());
                                affidavit.permit_no = String.IsNullOrEmpty(dataReader["permit_no"].ToString()) ? 0 : int.Parse(dataReader["permit_no"].ToString());
                                affidavit.permit_issued = dataReader["permit_issued"].ToString();
                                affidavit.permit_extended = dataReader["permit_extended"].ToString();
                                affidavit.date_issued = String.IsNullOrEmpty(dataReader["date_issued"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_issued"].ToString());// DateTime.Parse(dataReader["date_issued"].ToString());
                                affidavit.date_expired = String.IsNullOrEmpty(dataReader["date_expired"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_expired"].ToString());// DateTime.Parse(dataReader["date_expired"].ToString());
                                affidavit.contractor = dataReader["contractor"].ToString();
                                affidavit.builder_board_no = dataReader["builder_board_no"].ToString();
                                affidavit.license_no = dataReader["license_no"].ToString();
                                affidavit.date_cancelled = String.IsNullOrEmpty(dataReader["date_cancelled"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_cancelled"].ToString());
                                affidavit.cancelled_by = dataReader["cancelled_by"].ToString();
                                affidavit.status = dataReader["status"].ToString();
                                affidavit.last_action = dataReader["last_action"].ToString();
                                affidavit.date_added = String.IsNullOrEmpty(dataReader["date_added"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_added"].ToString());
                                affidavit.date_updated = String.IsNullOrEmpty(dataReader["date_updated"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_updated"].ToString());
                                affidavit.notes = dataReader["notes"].ToString();
                                affidavit.NEW_AFF = dataReader["NEW_AFF"].ToString();
                                affidavit.NEW_ClearWalk = String.IsNullOrEmpty(dataReader["NEW_ClearWalk"].ToString()) ? false : bool.Parse(dataReader["NEW_ClearWalk"].ToString());
                                affidavit.NEW_RepairDueDate = String.IsNullOrEmpty(dataReader["NEW_RepairDueDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["NEW_RepairDueDate"].ToString());
                                affidavit.sent_dt = String.IsNullOrEmpty(dataReader["sent_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["sent_dt"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                affidavit = null;
            }
            return affidavit;
        }
        /// <summary>
        /// this method will be use for search affidavit by keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<sw_posting> GetAffidavitByKeyword(string keyword)
        {
            List<sw_posting> result = new List<sw_posting>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("getAffidavitByKeyword", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@keyword", SqlDbType.NVarChar).Value = keyword;
                        con.Open();
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                sw_posting affidavit = new sw_posting();
                                affidavit.aff_no = String.IsNullOrEmpty(dataReader["aff_no"].ToString()) ? 0 : int.Parse(dataReader["aff_no"].ToString());
                                // affidavit.qtr_sec = dataReader["qtr_sec"].ToString();
                                // affidavit.map_id = dataReader["map_id"].ToString();
                                //affidavit.post_dt = String.IsNullOrEmpty(dataReader["post_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["post_dt"].ToString());// DateTime.Parse(dataReader["post_dt"].ToString());
                                //affidavit.acct_period = String.IsNullOrEmpty(dataReader["acct_period"].ToString()) ? 0 : int.Parse(dataReader["acct_period"].ToString());
                                //affidavit.property_id = dataReader["property_id"].ToString();
                                //affidavit.property_id2 = dataReader["property_id2"].ToString();
                                //affidavit.property_desc = dataReader["property_desc"].ToString();
                                //affidavit.aff_status = String.IsNullOrEmpty(dataReader["aff_status"].ToString()) ? 0 : int.Parse(dataReader["aff_status"].ToString());
                                //affidavit.owner_name = dataReader["owner_name"].ToString();
                                //affidavit.attn1 = dataReader["attn1"].ToString();
                                //affidavit.attn2 = dataReader["attn2"].ToString();
                                affidavit.st_no = dataReader["st_no"].ToString();
                                affidavit.district = dataReader["district"].ToString();
                                affidavit.st_name = dataReader["st_name"].ToString();
                                affidavit.designator = dataReader["designator"].ToString();
                                //affidavit.city = dataReader["city"].ToString();
                                //affidavit.zip = dataReader["zip"].ToString();
                                //affidavit.inspector_no = String.IsNullOrEmpty(dataReader["inspector_no"].ToString()) ? 0 : int.Parse(dataReader["inspector_no"].ToString());
                                //affidavit.city_owned_flag = dataReader["city_owned_flag"].ToString();
                                //affidavit.owner_resident_flag = dataReader["owner_resident_flag"].ToString();
                                //affidavit.service_req_flag = dataReader["service_req_flag"].ToString();
                                //affidavit.rep_by_city = dataReader["rep_by_city"].ToString();
                                //affidavit.rep_by_owner = dataReader["rep_by_owner"].ToString();
                                //affidavit.partial_repair = dataReader["partial_repair"].ToString();
                                //affidavit.vacant_lot_flag = dataReader["vacant_lot_flag"].ToString();
                                //affidavit.vacant_desc = dataReader["vacant_desc"].ToString();
                                //affidavit.repair_dt = String.IsNullOrEmpty(dataReader["repair_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["repair_dt"].ToString());// DateTime.Parse(dataReader["repair_dt"].ToString());
                                //affidavit.billed_dt = String.IsNullOrEmpty(dataReader["billed_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["billed_dt"].ToString());// DateTime.Parse(dataReader["billed_dt"].ToString());
                                //affidavit.bill_flag = dataReader["bill_flag"].ToString();
                                //affidavit.hold_until_dt = String.IsNullOrEmpty(dataReader["hold_until_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["hold_until_dt"].ToString());// DateTime.Parse(dataReader["hold_until_dt"].ToString());
                                //affidavit.permit_no = String.IsNullOrEmpty(dataReader["permit_no"].ToString()) ? 0 : int.Parse(dataReader["permit_no"].ToString());
                                //affidavit.permit_issued = dataReader["permit_issued"].ToString();
                                //affidavit.permit_extended = dataReader["permit_extended"].ToString();
                                //affidavit.date_issued = String.IsNullOrEmpty(dataReader["date_issued"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_issued"].ToString());// DateTime.Parse(dataReader["date_issued"].ToString());
                                //affidavit.date_expired = String.IsNullOrEmpty(dataReader["date_expired"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_expired"].ToString());// DateTime.Parse(dataReader["date_expired"].ToString());
                                //affidavit.contractor = dataReader["contractor"].ToString();
                                //affidavit.builder_board_no = dataReader["builder_board_no"].ToString();
                                //affidavit.license_no = dataReader["license_no"].ToString();
                                //affidavit.date_cancelled = String.IsNullOrEmpty(dataReader["date_cancelled"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_cancelled"].ToString());
                                //affidavit.cancelled_by = dataReader["cancelled_by"].ToString();
                                //affidavit.status = dataReader["status"].ToString();
                                //affidavit.last_action = dataReader["last_action"].ToString();
                                //affidavit.date_added = String.IsNullOrEmpty(dataReader["date_added"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_added"].ToString());
                                //affidavit.date_updated = String.IsNullOrEmpty(dataReader["date_updated"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_updated"].ToString());
                                //affidavit.notes = dataReader["notes"].ToString();
                                //affidavit.sent_dt = String.IsNullOrEmpty(dataReader["sent_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["sent_dt"].ToString());
                                result.Add(affidavit);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                result = null;
            }
            return result;
        }

        //public List<sw_posting> GetAffidavitByParameters(string affidavitId, string propertyId, string inspectionDate, string fromDate, string toDate)
        //{
        //    string from = fromDate.Split('/')[2] + "-" + fromDate.Split('/')[0] + "-" + fromDate.Split('/')[1];
        //    string to = toDate.Split('/')[2] + "-" + toDate.Split('/')[0] + "-" + toDate.Split('/')[1];
        //    List<sw_posting> result = new List<sw_posting>();
        //    try
        //    {
        //        var list = context.getAffidavitByParameter(affidavitId, propertyId, inspectionDate, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, from, to).ToList();

        //        result = Mapper.Map<List<getAffidavitByParameter_Result>, List<sw_posting>>(list);

        //    }

        public List<Affidavit> GetAffidavitByParameters(string affidavitId, string propertyId, string inspectionDate, string fromDate, string toDate)
        {
            string from = fromDate.Split('/')[2] + "-" + fromDate.Split('/')[0] + "-" + fromDate.Split('/')[1];
            string to = toDate.Split('/')[2] + "-" + toDate.Split('/')[0] + "-" + toDate.Split('/')[1];
            List<Affidavit> result = new List<Affidavit>();
            try
            {
                var dateFrom = DateTime.Parse(fromDate);
                var dateTo = DateTime.Parse(toDate);
                var affidavitList = context.Affidavit.Include("AffidavitStatus").Include("AffidavitHistory").Include("Inspector")
                    .Where(x => x.InspectionDate.Value >= dateFrom && x.InspectionDate <= dateTo).ToList();
                //var list = context.sp_getAffidavitByParameter_swp(affidavitId, propertyId, inspectionDate, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, from, to).ToList();
                List<string> propertyIdList = affidavitList.Select(x => x.PropertyID).ToList<string>();
                var propertyOwnerList = context.PORT_TAXLOTS_PDX.Where(x => propertyIdList.Contains(x.PROPERTYID)).ToList();
                foreach (var item in affidavitList)
                {
                    var ownerExist = propertyOwnerList.Where(x => x.PROPERTYID.Contains(item.PropertyID)).FirstOrDefault();
                    if (ownerExist != null)
                        item.CurrentOwner = ownerExist.OWNER1;
                    item.InspectorName = item.Inspector.FullName;
                    item.StatusValue = item.AffidavitStatus.Status;

                    //Nulling the fields to avoid the circular reference

                    item.AffidavitStatus.Affidavit = null;
                    item.Inspector.Affidavit = null;
                    item.AffidavitHistory = null;
                    item.AffidavitStatus.AffidavitHistory = null;
                    item.Inspector.AffidavitHistory = null;
                }
                result = affidavitList;
                //Mapper.Map<List<sp_getAffidavitByParameter_swp_Result>, List<Affidavit>>(list);

            }
            catch (Exception ex)
            {
                Log.Error(ex);
                result = null;
            }
            return result;
        }
        /// <summary>
        /// this method will be use for search affidavit by keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<sw_posting> GetAffidavitByPropertyKeyword(string keyword)
        {
            List<sw_posting> result = new List<sw_posting>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("getAffidavitByProperty", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@keyword", SqlDbType.NVarChar).Value = keyword;
                        con.Open();
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                sw_posting affidavit = new sw_posting();
                                affidavit.aff_no = String.IsNullOrEmpty(dataReader["aff_no"].ToString()) ? 0 : int.Parse(dataReader["aff_no"].ToString());
                                // affidavit.qtr_sec = dataReader["qtr_sec"].ToString();
                                // affidavit.map_id = dataReader["map_id"].ToString();
                                //affidavit.post_dt = String.IsNullOrEmpty(dataReader["post_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["post_dt"].ToString());// DateTime.Parse(dataReader["post_dt"].ToString());
                                //affidavit.acct_period = String.IsNullOrEmpty(dataReader["acct_period"].ToString()) ? 0 : int.Parse(dataReader["acct_period"].ToString());
                                //affidavit.property_id = dataReader["property_id"].ToString();
                                //affidavit.property_id2 = dataReader["property_id2"].ToString();
                                //affidavit.property_desc = dataReader["property_desc"].ToString();
                                //affidavit.aff_status = String.IsNullOrEmpty(dataReader["aff_status"].ToString()) ? 0 : int.Parse(dataReader["aff_status"].ToString());
                                //affidavit.owner_name = dataReader["owner_name"].ToString();
                                //affidavit.attn1 = dataReader["attn1"].ToString();
                                //affidavit.attn2 = dataReader["attn2"].ToString();
                                affidavit.st_no = dataReader["st_no"].ToString();
                                affidavit.district = dataReader["district"].ToString();
                                affidavit.st_name = dataReader["st_name"].ToString();
                                affidavit.designator = dataReader["designator"].ToString();
                                //affidavit.city = dataReader["city"].ToString();
                                //affidavit.zip = dataReader["zip"].ToString();
                                //affidavit.inspector_no = String.IsNullOrEmpty(dataReader["inspector_no"].ToString()) ? 0 : int.Parse(dataReader["inspector_no"].ToString());
                                //affidavit.city_owned_flag = dataReader["city_owned_flag"].ToString();
                                //affidavit.owner_resident_flag = dataReader["owner_resident_flag"].ToString();
                                //affidavit.service_req_flag = dataReader["service_req_flag"].ToString();
                                //affidavit.rep_by_city = dataReader["rep_by_city"].ToString();
                                //affidavit.rep_by_owner = dataReader["rep_by_owner"].ToString();
                                //affidavit.partial_repair = dataReader["partial_repair"].ToString();
                                //affidavit.vacant_lot_flag = dataReader["vacant_lot_flag"].ToString();
                                //affidavit.vacant_desc = dataReader["vacant_desc"].ToString();
                                //affidavit.repair_dt = String.IsNullOrEmpty(dataReader["repair_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["repair_dt"].ToString());// DateTime.Parse(dataReader["repair_dt"].ToString());
                                //affidavit.billed_dt = String.IsNullOrEmpty(dataReader["billed_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["billed_dt"].ToString());// DateTime.Parse(dataReader["billed_dt"].ToString());
                                //affidavit.bill_flag = dataReader["bill_flag"].ToString();
                                //affidavit.hold_until_dt = String.IsNullOrEmpty(dataReader["hold_until_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["hold_until_dt"].ToString());// DateTime.Parse(dataReader["hold_until_dt"].ToString());
                                //affidavit.permit_no = String.IsNullOrEmpty(dataReader["permit_no"].ToString()) ? 0 : int.Parse(dataReader["permit_no"].ToString());
                                //affidavit.permit_issued = dataReader["permit_issued"].ToString();
                                //affidavit.permit_extended = dataReader["permit_extended"].ToString();
                                //affidavit.date_issued = String.IsNullOrEmpty(dataReader["date_issued"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_issued"].ToString());// DateTime.Parse(dataReader["date_issued"].ToString());
                                //affidavit.date_expired = String.IsNullOrEmpty(dataReader["date_expired"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_expired"].ToString());// DateTime.Parse(dataReader["date_expired"].ToString());
                                //affidavit.contractor = dataReader["contractor"].ToString();
                                //affidavit.builder_board_no = dataReader["builder_board_no"].ToString();
                                //affidavit.license_no = dataReader["license_no"].ToString();
                                //affidavit.date_cancelled = String.IsNullOrEmpty(dataReader["date_cancelled"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_cancelled"].ToString());
                                //affidavit.cancelled_by = dataReader["cancelled_by"].ToString();
                                //affidavit.status = dataReader["status"].ToString();
                                //affidavit.last_action = dataReader["last_action"].ToString();
                                //affidavit.date_added = String.IsNullOrEmpty(dataReader["date_added"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_added"].ToString());
                                //affidavit.date_updated = String.IsNullOrEmpty(dataReader["date_updated"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_updated"].ToString());
                                //affidavit.notes = dataReader["notes"].ToString();
                                //affidavit.sent_dt = String.IsNullOrEmpty(dataReader["sent_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["sent_dt"].ToString());
                                result.Add(affidavit);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                result = null;
            }
            return result;
        }

        #region SWP
        public Affidavit GetAffidavitDetails_SWP(long affidavitID)
        {
            Affidavit affidavit = new Affidavit();
            try
            {
                affidavit = context.Affidavit.Include("AffidavitHistory.AffidavitStatus").Include("AffidavitStatus").Include("Inspector").Where(x => x.AffidavitID == affidavitID).FirstOrDefault();
            }
            //try
            //{
            //    using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
            //    {
            //        using (SqlCommand cmd = new SqlCommand("sp_getAffidavitDetails_swp", con))
            //        {
            //            cmd.Parameters.AddWithValue("@affidavitId", SqlDbType.NVarChar).Value = affidavitID;
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            con.Open();
            //            SqlDataReader dataReader = cmd.ExecuteReader();
            //            if (dataReader.HasRows)
            //            {
            //                while (dataReader.Read())
            //                {
            //                    affidavit.AffidavitID = String.IsNullOrEmpty(dataReader["AffidavitID"].ToString()) ? 0 : int.Parse(dataReader["AffidavitID"].ToString());
            //                    affidavit.New_Aff = dataReader["New_Aff"].ToString();
            //                    affidavit.QtrSection = dataReader["QtrSection"].ToString();
            //                    affidavit.InspectorName = dataReader["InspectorName"].ToString();
            //                    affidavit.PropertyDescription = dataReader["PropertyDescription"].ToString();
            //                    affidavit.map_id = dataReader["map_id"].ToString();
            //                    affidavit.post_dt = String.IsNullOrEmpty(dataReader["post_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["post_dt"].ToString());// DateTime.Parse(dataReader["post_dt"].ToString());
            //                    affidavit.acct_period = String.IsNullOrEmpty(dataReader["acct_period"].ToString()) ? 0 : int.Parse(dataReader["acct_period"].ToString());
            //                    affidavit.property_id = dataReader["property_id"].ToString();
            //                    affidavit.property_id2 = dataReader["property_id2"].ToString();
            //                    affidavit.property_desc = dataReader["property_desc"].ToString();
            //                    affidavit.aff_status = String.IsNullOrEmpty(dataReader["aff_status"].ToString()) ? 0 : int.Parse(dataReader["aff_status"].ToString());
            //                    affidavit.owner_name = dataReader["owner_name"].ToString();
            //                    affidavit.attn1 = dataReader["attn1"].ToString();
            //                    affidavit.attn2 = dataReader["attn2"].ToString();
            //                    affidavit.st_no = dataReader["st_no"].ToString();
            //                    affidavit.district = dataReader["district"].ToString();
            //                    affidavit.st_name = dataReader["st_name"].ToString();
            //                    affidavit.designator = dataReader["designator"].ToString();
            //                    affidavit.city = dataReader["city"].ToString();
            //                    affidavit.zip = dataReader["zip"].ToString();
            //                    //affidavit.inspector_no = String.IsNullOrEmpty(dataReader["inspector_no"].ToString()) ? 0 : int.Parse(dataReader["inspector_no"].ToString());
            //                    affidavit.inspector_name = dataReader["inspector_name"].ToString();
            //                    affidavit.city_owned_flag = dataReader["city_owned_flag"].ToString();
            //                    affidavit.owner_resident_flag = dataReader["owner_resident_flag"].ToString();
            //                    affidavit.service_req_flag = dataReader["service_req_flag"].ToString();
            //                    affidavit.rep_by_city = dataReader["rep_by_city"].ToString();
            //                    affidavit.rep_by_owner = dataReader["rep_by_owner"].ToString();
            //                    affidavit.partial_repair = dataReader["partial_repair"].ToString();
            //                    affidavit.vacant_lot_flag = dataReader["vacant_lot_flag"].ToString();
            //                    affidavit.vacant_desc = dataReader["vacant_desc"].ToString();
            //                    affidavit.repair_dt = String.IsNullOrEmpty(dataReader["repair_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["repair_dt"].ToString());// DateTime.Parse(dataReader["repair_dt"].ToString());
            //                    affidavit.billed_dt = String.IsNullOrEmpty(dataReader["billed_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["billed_dt"].ToString());// DateTime.Parse(dataReader["billed_dt"].ToString());
            //                    affidavit.bill_flag = dataReader["bill_flag"].ToString();
            //                    affidavit.hold_until_dt = String.IsNullOrEmpty(dataReader["hold_until_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["hold_until_dt"].ToString());// DateTime.Parse(dataReader["hold_until_dt"].ToString());
            //                    affidavit.permit_no = String.IsNullOrEmpty(dataReader["permit_no"].ToString()) ? 0 : int.Parse(dataReader["permit_no"].ToString());
            //                    affidavit.permit_issued = dataReader["permit_issued"].ToString();
            //                    affidavit.permit_extended = dataReader["permit_extended"].ToString();
            //                    affidavit.date_issued = String.IsNullOrEmpty(dataReader["date_issued"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_issued"].ToString());// DateTime.Parse(dataReader["date_issued"].ToString());
            //                    affidavit.date_expired = String.IsNullOrEmpty(dataReader["date_expired"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_expired"].ToString());// DateTime.Parse(dataReader["date_expired"].ToString());
            //                    affidavit.contractor = dataReader["contractor"].ToString();
            //                    affidavit.builder_board_no = dataReader["builder_board_no"].ToString();
            //                    affidavit.license_no = dataReader["license_no"].ToString();
            //                    affidavit.date_cancelled = String.IsNullOrEmpty(dataReader["date_cancelled"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_cancelled"].ToString());
            //                    affidavit.cancelled_by = dataReader["cancelled_by"].ToString();
            //                    affidavit.status = dataReader["status"].ToString();
            //                    affidavit.last_action = dataReader["last_action"].ToString();
            //                    affidavit.date_added = String.IsNullOrEmpty(dataReader["date_added"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_added"].ToString());
            //                    affidavit.date_updated = String.IsNullOrEmpty(dataReader["date_updated"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["date_updated"].ToString());
            //                    affidavit.notes = dataReader["notes"].ToString();
            //                    affidavit.NEW_AFF = dataReader["NEW_AFF"].ToString();
            //                    affidavit.NEW_ClearWalk = String.IsNullOrEmpty(dataReader["NEW_ClearWalk"].ToString()) ? false : bool.Parse(dataReader["NEW_ClearWalk"].ToString());
            //                    affidavit.NEW_RepairDueDate = String.IsNullOrEmpty(dataReader["NEW_RepairDueDate"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["NEW_RepairDueDate"].ToString());
            //                    affidavit.sent_dt = String.IsNullOrEmpty(dataReader["sent_dt"].ToString()) ? (DateTime?)null : DateTime.Parse(dataReader["sent_dt"].ToString());
            //                }
            //            }
            //        }
            //    }
            //}
            catch (Exception ex)
            {
                Log.Error(ex);
                affidavit = new Affidavit();
            }
            return affidavit;
        }

        public List<AffidavitHistory> GetHistoryDetail(long affidavitId)
        {
            var history = context.AffidavitHistory.Include("AffidavitStatus").Where(x => x.AffidavitId == affidavitId).ToList();
            if (history == null)
            {
                return new List<AffidavitHistory>();
            }
            return history;
        }
        #endregion

        public AffidavitHistory UpdateAffidavitHistory(AffidavitHistory model)
        {
            try
            {
                var affidavit = context.Affidavit.Where(x => x.AffidavitID.Equals(model.AffidavitId)).FirstOrDefault();
                var status = context.AffidavitStatus.Where(x => x.AffidavitStatusId == model.AffidavitStatusId).FirstOrDefault();
                model.StatusValue = status.Status;
                affidavit.Status = status.AffidavitStatusId;
                context.AffidavitHistory.Add(model);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                model = null;
            }
            return model;
        }

        public List<AffidavitModel> GetAllAffidavit(string fromDate, string toDate)
        {
            List<AffidavitModel> lstAffidavit = new List<AffidavitModel>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    //using (SqlCommand cmd = new SqlCommand("getAffidavitList", con))
                    using (SqlCommand cmd = new SqlCommand("PROC_GETAFFIDAVIT_SWP", con))
                    {
                        cmd.Parameters.AddWithValue("@FROMDATE", SqlDbType.NVarChar).Value = fromDate;
                        cmd.Parameters.AddWithValue("@TODATE", SqlDbType.NVarChar).Value = toDate;
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                AffidavitModel affidavit = new AffidavitModel();
                                affidavit.AffidavitId = String.IsNullOrEmpty(dataReader["AffidavitID"].ToString()) ? 0 : int.Parse(dataReader["AffidavitID"].ToString());
                                affidavit.PropertyAddress = Convert.ToString(dataReader["PropertyAddress"]);
                                affidavit.OwnerName = Convert.ToString(dataReader["OwnerName"]);
                                affidavit.InspectorName = Convert.ToString(dataReader["InspectorName"]);
                                affidavit.NewOwner = Convert.ToString(dataReader["NewOwner"]);
                                affidavit.PropertyId = Convert.ToString(dataReader["PropertyId"]);
                                affidavit.Status = Convert.ToString(dataReader["Status"]);
                                affidavit.StatusId = String.IsNullOrEmpty(dataReader["StatusId"].ToString()) ? 0 : int.Parse(dataReader["StatusId"].ToString());
                                affidavit.InspectionDate = Convert.ToString(dataReader["InspectionDate"]);
                                affidavit.IsHighlightOwner = String.IsNullOrEmpty(dataReader["IsHighlightOwner"].ToString()) ? false : Convert.ToBoolean(dataReader["IsHighlightOwner"]);
                                lstAffidavit.Add(affidavit);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                lstAffidavit = null;
            }
            return lstAffidavit;
        }

        //public List<AffidavitModel> GetAllTrackIT()
        //{
        //    var result = (from track in context.TrackIT
        //                  join affidavit in context.Affidavit on track.AffidavitId equals affidavit.AffidavitID
        //                  join stat in context.AffidavitStatus on track.StatusId equals stat.AffidavitStatusId
        //                  select new { track, affidavit, stat })
        //                  .Select(x => new AffidavitModel
        //                  {
        //                      AffidavitId = x.track.AffidavitId,
        //                      PropertyAddress = x.affidavit.SiteStreetNumber,
        //                      StatusId = x.track.StatusId,
        //                      Status = x.stat.Status,
        //                      RequestedDate = x.track.RequestedDate,
        //                      Comments = x.track.Comments

        //                  }).ToList();
        //    return result;
        //}
        public List<IEnumerable> GetAllTrackIT()
        {
            var results = new SWPostEntities()
               .MultipleResults("PROC_GETTRACKIT_SWP")
               .With<AffidavitModel>()
               .With<AffidavitModel>()
               .Execute();


            return results;
        }
        public bool SaveTrackItDetails(AffidavitModel aff)
        {
            context = new SWPostEntities();
            FormAndFinalInspectionRequests form = new FormAndFinalInspectionRequests();
            try
            {
                form.AffidavitId = aff.AffidavitId;
                form.Comments = aff.Comments;
                form.RequestedDate = DateTime.Now;
                form.TypeOfInspectionNeeded = aff.TypeOfInspectionNeeded;
                context.FormAndFinalInspectionRequests.Add(form);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
