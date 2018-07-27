using AutoMapper;
using Sidewalk.Logic;
using Sidewalk.Logic.Database;
//using SidewalkUI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
namespace SidewalkUI.Api
{
    //[Authorize]
    public class SidewalkApiController : ApiController
    {
        log4net.ILog Log = log4net.LogManager.GetLogger(typeof(SidewalkApiController));
        /// <summary>
        /// Created object of logic layer class
        /// </summary>
        AffidavitLogic affidavitLogic = new AffidavitLogic();
        FormLogic formLogic = new FormLogic();
        AffidavitCostsLogic affidavitCostLogic = new AffidavitCostsLogic();
        ContractorLogic contractorLogic = new ContractorLogic();
        PermitLogic permitLogic = new PermitLogic();
        RepairItemLogic repairItemLogic = new RepairItemLogic();
        ErrorLogLogic errorLogic = new ErrorLogLogic();

        #region Affidavit

        /// <summary>
        /// This method will get all affidavit list
        /// </summary>
        /// <returns></returns>
        public List<Affidavit> GetAffidavit()
        {
            List<Affidavit> result = new List<Affidavit>();
            try
            {
                result = affidavitLogic.GetAffidavitList();
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }
        /// <summary>
        /// get list of affidavit by keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<sw_posting> GetAffidavitByKeyword(string keyword)
        {
            List<sw_posting> result = new List<sw_posting>();
            try
            {
                result = affidavitLogic.GetAffidavitByKeyword(keyword);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        public List<Models.NoticeLetterViewModel> GetAffidavitByParameters(Models.SearchParemeters keyword)
        {
            List<Models.NoticeLetterViewModel> result = new List<Models.NoticeLetterViewModel>();
            try
            {
                result = Mapper.Map<List<Affidavit>, List<Models.NoticeLetterViewModel>>(affidavitLogic.GetAffidavitByParameters(keyword.AffidavitId, keyword.PropertyId, keyword.InspectionDate, keyword.FromDate, keyword.ToDate));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                result = null;
            }
            return result;
        }

        public List<Models.AffidavitViewModel> GetAffidavitByKeyword(Models.SearchParemeters keyword)
        {
            List<Models.AffidavitViewModel> result = new List<Models.AffidavitViewModel>();
            try
            {
                result = Mapper.Map<List<Affidavit>, List<Models.AffidavitViewModel>>(affidavitLogic.GetAffidavitByParameters(keyword.AffidavitId, keyword.PropertyId, keyword.InspectionDate, keyword.FromDate, keyword.ToDate));
            }
            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        /// <summary>
        /// get list of affidavit by property
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<sw_posting> GetAffidavitByPropertyKeyword(string keyword)
        {
            List<sw_posting> result = new List<sw_posting>();
            try
            {
                result = affidavitLogic.GetAffidavitByPropertyKeyword(keyword);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        /// <summary>
        /// This method will get affidavit details by affidavit number
        /// </summary>
        /// <param name="affidavitNumber"></param>
        /// <returns></returns>
        public sw_posting GetAffidavitByNumber(string affidavitNumber)
        {
            sw_posting result = new sw_posting();
            try
            {
                result = affidavitLogic.GetAffidavitDetails(affidavitNumber);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        public bool UploadAffidavitAttachment(List<string> fileNames, string affidavitId)
        {
            bool result = false;
            try
            {
                List<AffidavitAttachment> attachments = new List<AffidavitAttachment>();
                foreach (var item in fileNames)
                {
                    attachments.Add(new AffidavitAttachment()
                    {
                        AffidavitId = long.Parse(affidavitId),
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        FileName = item.Split('~')[0],
                        DisplayName = item.Split('~')[1],
                        IsDeleted = false,
                        Status = true
                    });
                }
                result = affidavitLogic.UploadAffidavitAttachment(attachments);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public List<AffidavitAttachment> GetAffidavitAttachment(long affidavitNo)
        {
            List<AffidavitAttachment> result = new List<AffidavitAttachment>();
            try
            {
                result = affidavitLogic.GetAffidavitAttachments(affidavitNo.ToString());
            }
            catch (Exception ex)
            { }
            return result;
        }
        public bool DeleteAffidavitAttachment(long attachmentId)
        {
            bool result = false;
            try
            {
                result = affidavitLogic.DeleteAffidavitAttachment(attachmentId);
            }
            catch (Exception ex)
            { }
            return result;
        }


        public Affidavit GetAffidavitDetails(string affidavitNo)
        {
            Affidavit result = new Affidavit();
            try
            {
                result = affidavitLogic.GetAffidavitDetails_SWP(long.Parse(affidavitNo));
                Log.Info(ConfigurationManager.ConnectionStrings["SWPostEntities"]);
                Log.Info(ConfigurationManager.ConnectionStrings["SidewalkConnection"]);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            return result;
        }
        public Models.AffidavitDetailsViewModel GetAffidavitByNo(string affidavitNo)
        {
            Models.AffidavitDetailsViewModel result = new Models.AffidavitDetailsViewModel();
            try
            {
                result.AffidavitInfo = affidavitLogic.GetAffidavitDetails_SWP(long.Parse(affidavitNo));
                result.Attachments = affidavitLogic.GetAffidavitAttachments(affidavitNo);
                result.PermitInfo = permitLogic.GetPermitByAffidavit(long.Parse(affidavitNo));
                if (result.PermitInfo != null)
                {
                    result.PermitApplicantInfo = permitLogic.GetPermitApplicant((long)result.PermitInfo.ApplicantID);
                    result.PermitCostInfo = affidavitCostLogic.GetAffidavitCostDetails(affidavitNo, string.Empty);
                }               
            }

            catch (Exception ex)
            {
                result = null;
            }
            return result;
        }

        /// <summary>
        /// This method will get affidavit cost details associated with one affidavit
        /// </summary>
        /// <param name="affidavitID"></param>
        /// <param name="costTypeKey"></param>
        /// <returns></returns>
        /// 
        public List<sw_action_detail> GetAffidavitCostDetails(string affidavitID, string costTypeKey)
        {
            List<sw_action_detail> result = new List<sw_action_detail>();
            try
            {
                if (!string.IsNullOrEmpty(affidavitID) && !string.IsNullOrEmpty(costTypeKey))
                {
                    result = affidavitCostLogic.GetAffidavitCostDetails(affidavitID, costTypeKey);
                    if (result.Count == 0)
                    {
                        result = affidavitCostLogic.GetAffidavitCostDetails(affidavitID, "E");
                    }
                }
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }
        public List<PermitCostsDetail> GetPermitCostsDetail(string affidavitID)
        {
            List<PermitCostsDetail> result = new List<PermitCostsDetail>();
            try
            {
                if (!string.IsNullOrEmpty(affidavitID))
                {
                    result = affidavitCostLogic.GetPermitCostsDetails(affidavitID);
                }
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }
        /// <summary>
        /// This method will search first for contractor licence number, if not found then it will search for contractor name
        /// </summary>
        /// <param name="ccbNumber"></param>
        /// <returns></returns>
        [HttpGet]
        public CCBContractor SearchContractor(string ccbNumber)
        {
            CCBContractor result = new CCBContractor();
            try
            {
                if (!string.IsNullOrEmpty(ccbNumber))
                {
                    result = contractorLogic.SearchContractor(ccbNumber);
                }
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        [HttpGet]
        public List<CCBContractor> SearchContractorByKeyword(string keyword)
        {
            List<CCBContractor> result = new List<CCBContractor>();
            try
            {
                if (!string.IsNullOrEmpty(keyword))
                {
                    result = contractorLogic.SearchContractorByKeyword(keyword);
                }
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        #endregion

        #region Permit
        /// <summary>
        /// This method will get list of permits by its status
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public List<PermitModel> GetPermitsByStatus(string status)
        {
            List<PermitModel> result = new List<PermitModel>();
            try
            {
                result = permitLogic.GetPermitsByStatus(status);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        /// <summary>
        /// This method will get list of permits by its status
        /// </summary>
        /// <param name="applicantName"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public List<PermitModel> GetPermitsByApplicant(string applicantName)
        {
            List<PermitModel> result = new List<PermitModel>();
            try
            {
                result = permitLogic.GetPermitsByApplicant(applicantName);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }
        /// <summary>
        /// this method will create permit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public Permit InsertPermit(Permit model)
        {
            try
            {
                model = permitLogic.InsertPermit(model);
            }
            catch (Exception)
            {
                model = null;
            }
            return model;
        }

        /// <summary>
        /// this method will remove permit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public bool RemovePermit(long permitID)
        {
            bool result = false;
            try
            {
                result = permitLogic.RemovePermit(permitID);
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// this method will update permit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// []
        /// 
        [HttpPost]
        public Permit UpdatePermit(Permit model)
        {
            try
            {
                model = permitLogic.UpdatePermit(model);
            }
            catch (Exception)
            {
                model = null;
            }
            return model;
        }




        /// <summary>
        /// this method will create payment towards a permit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public PermitPayment InsertPermitPayment(PermitPayment model)
        {
            try
            {
                model = permitLogic.InsertPermitPayment(model);
            }
            catch (Exception)
            {
                model = null;
            }
            return model;
        }

        /// <summary>
        /// this method will create payment towards a permit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public PermitApplicant InsertPermitApplicant(PermitApplicant model)
        {
            try
            {
                model = permitLogic.InsertPermitApplicant(model);
            }
            catch (Exception)
            {
                model = null;
            }
            return model;
        }
        /// <summary>
        /// this method will search permit by affidavit
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public Permit GetPermitByAffidavit(long affidavitID)
        {
            return permitLogic.GetPermitByAffidavit(affidavitID);
        }

        /// <summary>
        /// this method will search permit applicant
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 
        [HttpGet]
        public PermitApplicant GetPermitApplicant(long applicantID)
        {
            return permitLogic.GetPermitApplicant(applicantID);
        }

        [HttpGet]
        public PermitPayment GetPermitPayment(long permitID)
        {
            return permitLogic.GetPermitPayment(permitID);
        }

        /// <summary>
        /// this method will update permit applicant
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// []
        /// 
        [HttpPost]
        public PermitApplicant UpdatePermitApplicant(PermitApplicant model)
        {
            try
            {
                model = permitLogic.UpdatePermitApplicant(model);
            }
            catch (Exception)
            {
                model = null;
            }
            return model;
        }
        [HttpGet]
        public ApplicantPermitHistory GetApplicantHistory(string applicantName)
        {
            return permitLogic.GetApplicantHistory(applicantName);
        }
        /// <summary>
        /// this method will create applied permit affidavit costs
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PermitCostsDetail InsertPermitCostsDetail(PermitCostsDetail model)
        {
            return permitLogic.InsertPermitCostsDetail(model);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="affidavitID"></param>
        /// <returns></returns>
        public List<PermitCostsDetail> GetPermitCostsDetailByAffidavit(long affidavitID)
        {
            return permitLogic.GetPermitCostsDetailByAffidavit(affidavitID);
        }

        #endregion

        #region Permit repair item rate
        public List<PermitFeeRate> GetRepairItemRate()
        {
            return repairItemLogic.GetRepairItemRate();
        }
        #endregion

        #region Permit History
        public PermitHistory InsertPermitHistory(PermitHistory model)
        {
            return permitLogic.InsertPermitHistory(model);
        }

        public List<PermitHistory> GetPermitHistoryByPermit(long permitID)
        {
            return permitLogic.GetPermitHistoryByPermit(permitID);
        }
        #endregion

        #region ErrorLogs
        public List<ErrorLog> GetErrorList()
        {
            return errorLogic.GetErrorList();
        }
        public void InsertErrorLog(ErrorLog model)
        {
            errorLogic.InsertErrorLog(model);
        }
        #endregion

        #region Database Sync CCB
        [HttpGet]
        public async Task<bool> SyncOracleSqlCCB()
        {
            return await contractorLogic.SyncOracleSqlCCB();
        }

        [HttpGet]
        public bool StartJob()
        {
            bool result = false;
            try
            {
                JobScheduler.JobScheduler.Start();
                result = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.InnerException != null)
                    Log.Error(ex.InnerException);
                result = false;
            }
            return result;
        }

        [HttpGet]
        public bool StopJob()
        {
            bool result = false;
            try
            {
                JobScheduler.JobScheduler.Stop();
                result = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.InnerException != null)
                    Log.Error(ex.InnerException);
                result = false;
            }
            return result;
        }
        #endregion

        [HttpPost]
        public CCBContractor UpdateAliasName(CCBContractor model)
        {
            contractorLogic.UpdateAliasName(model);
            return model;
        }
        [HttpPost]
        public CCBContractor DeleteAliasName(CCBContractor model)
        {
            CCBContractor result = model;
            contractorLogic.DeleteAliasName(model);
            return result;
        }

        [HttpGet]
        public List<CCBContractor> GetCCBAliasList()
        {
            return contractorLogic.GetCCBAliasList();
        }

        [HttpGet]
        public Permit GetCanceledPermitByAffidavit(long affidavitID)
        {
            return permitLogic.GetCanceledPermitByAffidavit(affidavitID);
        }
        [HttpPost]
        public PermitFee UpdatePermitFee(PermitFee model)
        {
            return permitLogic.UpdatePermitFee(model);
        }
        [HttpPost]
        public PermitFeeRate UpdatePermitFeeRate(PermitFeeRate model)
        {
            return permitLogic.UpdatePermitFeeRate(model);
        }
        [HttpGet]
        public List<PermitFeeRate> GetPermitFeeRate()
        {
            return permitLogic.GetPermitFeeRate();
        }
        [HttpGet]
        public PermitFee GetPermitFee()
        {
            return permitLogic.GetPermitFee();
        }

        [HttpGet]
        public AffidavitHistory UpdateAffidavitHistory(long affidavitNo, int statusValue, int inspectorId)
        {
            //Affidavit affidavit = affidavitLogic.GetAffidavitDetails_SWP(affidavitNo);
            AffidavitHistory history = new AffidavitHistory();
            //if (affidavit.AffidavitStatus.AffidavitStatusId != statusValue)
            //{
            try
            {

                history.AffidavitId = affidavitNo;
                history.AffidavitStatusId = statusValue;
                history.InspectorId = inspectorId;
                history.CreatedDate = DateTime.Now;
                history = affidavitLogic.UpdateAffidavitHistory(history);
            }
            catch (Exception)
            {
                history = null;
            }
            //            }
            return history;

        }

        [HttpPost]
        public bool AddAffidavitFormInspection(AffidavitFormInspection model, int type)
        {
            bool result = false;
            try
            {
                result = formLogic.AddAffidavitFormInspection(model, type);
            }
            catch (Exception)
            {
                result = false; ;
            }
            return result;
        }
        [HttpGet]
        public AffidavitFormInspection GetAffidavitFormInspection(long affidavitNo, int type)
        {
            AffidavitFormInspection result = new AffidavitFormInspection();
            try
            {
                result = formLogic.GetAffidavitFormInspection(affidavitNo, type);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }


        public List<AffidavitHistory> GetAffidavitHistory(string affidavitNo)
        {
            List<AffidavitHistory> result = new List<AffidavitHistory>();
            try
            {
                result = affidavitLogic.GetHistoryDetail(long.Parse(affidavitNo));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            return result;
        }

        public AffidavitFinalInspection GetAffidavitFinalInspection(long affidavitNo, int type)
        {
            AffidavitFinalInspection result = new AffidavitFinalInspection();
            try
            {
                result = formLogic.GetAffidavitFinalInspection(affidavitNo, type);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        [HttpPost]
        public bool AddAffidavitFinalInspection(AffidavitFinalInspection model, int type)
        {
            bool result = false;
            try
            {
                result = formLogic.AddAffidavitFinalInspection(model, type);
            }
            catch (Exception)
            {
                result = false; ;
            }
            return result;
        }

        [HttpGet]
        public List<AffidavitModel> GetAllAffidavit(string fromDate, string toDate)
        {
            try
            {
                return affidavitLogic.GetAllAffidavit(fromDate, toDate);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return null;
            }
        }

        //public List<AffidavitModel> GetAllTrackIT()
        //{
        //    try
        //    {
        //        return affidavitLogic.GetAllTrackIT();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Error(ex.Message);
        //        return null;
        //    }
        //}
        public List<IEnumerable> GetAllTrackIT()
        {
            try
            {
                return affidavitLogic.GetAllTrackIT();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return null;
            }
        }
        public bool SaveTrackItDetails(AffidavitModel aff)
        {
            try
            {
                return affidavitLogic.SaveTrackItDetails(aff);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return false;
            }
        }
    }
}