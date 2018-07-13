using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidewalkPermitWPF.Model
{
    public interface IDataService
    {
        Task<List<sw_posting>> GetAffidavit();
        Task<ObservableCollection<sw_posting>> GetAffidavitByKeyword(string keyword);
        Task<ObservableCollection<sw_posting>> GetAffidavitByPropertyKeyword(string keyword);
        Task<sw_posting> GetAffidavitByNumber(string affidavitNumber);
        Task<ObservableCollection<sw_action_detail>> GetAffidavitCostDetails(string affidavitId, string costTypeKey);
        Task<ObservableCollection<PermitCostsDetail>> GetPermitCostsDetail(string affidavitId);
        Task<CCBContractor> GetContractor(string ccbNumber);
        Task<ObservableCollection<CCBContractor>> GetContractorByKeyword(string keyword);
        Task<Permit> InsertPermit(Permit model);
        Task<bool> RemovePermit(long permitID);
        Task<Permit> UpdatePermit(Permit model);
        Task<PermitPayment> InsertPermitPayment(PermitPayment model);
        Task<PermitApplicant> InsertPermitApplicant(PermitApplicant model);
        Task<PermitApplicant> GetPermitApplicant(long applicantID);
        Task<PermitApplicant> UpdatePermitApplicant(PermitApplicant model);
        Task<ObservableCollection<PermitModel>> GetPermitByStatus(string status);
        Task<ObservableCollection<PermitModel>> GetPermitsByApplicant(string applicantName);
        Task<Permit> GetPermitByAffidavit(long affidavitID);
        Task<Permit> GetCanceledPermitByAffidavit(long affidavitID);
        Task<PermitPayment> GetPermitPayment(long permitID);
        Task<ApplicantPermitHistory> GetApplicantHistory(string applicantName);
        Task<List<PermitFeeRate>> GetRepairItemRate();
        Task<PermitHistory> InsertPermitHistory(long permitId, string status, string comment);
        Task<List<PermitHistory>> GetPermitHistoryByPermit(long permitID);
        Task<PermitCostsDetail> InsertPermitCostsDetail(PermitCostsDetail model);
        Task<List<PermitCostsDetail>> GetPermitCostsDetailByAffidavit(long affidavitID);
        Task<bool> InsertErrorLog(ErrorLog model);

        Task<CCBContractor> UpdateAliasName(CCBContractor model);
        Task<bool> DeleteAliasName(CCBContractor model);
        Task<ObservableCollection<CCBContractor>> GetCCBAliasList();
        Task<ObservableCollection<PermitFeeRate>> GetPermitFeeRate();
        Task<PermitFeeRate> UpdatePermitFeeRate(PermitFeeRate permitFeeRate);
        Task<PermitFee> GetPermitFee();
        Task<PermitFee> UpdatePermitFee(PermitFee permitFee);
    }
}
