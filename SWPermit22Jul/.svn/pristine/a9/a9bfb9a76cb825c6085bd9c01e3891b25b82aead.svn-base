using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using SidewalkPermitWPF.Helper;
using SidewalkPermitWPF.MessageInfrastructure;
using SidewalkPermitWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidewalkPermitWPF.ViewModel
{
    public class ApprovedPermitsViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        ObservableCollection<PermitModel> _approvedPermits;

        public RelayCommand SearchPermitCommand { get; set; }
        public RelayCommand ClearFilterCommand { get; set; }
        public RelayCommand PrintCommand { get; set; }


        public ObservableCollection<PermitModel> ApprovedPermits
        {

            get { return _approvedPermits; }

            set
            {
                _approvedPermits = value;
                RaisePropertyChanged("ApprovedPermits");
            }
        }
        #region Search parameters
        
        string _applicantName;
        string _ccbNumber;
        string _affidavitNumber;
        string _dateIssuedFrom;
        string _dateIssuedTo;
        string _permitStatus;
        public string ApplicantName
        {
            get { return _applicantName; }
            set
            {
                _applicantName = value;
                RaisePropertyChanged("ApplicantName");
            }
        }
        public string SearchPermitStatus
        {
            get { return _permitStatus; }
            set
            {
                _permitStatus = value;
                RaisePropertyChanged("SearchPermitStatus");
            }
        }
        public string CCBNumber
        {
            get { return _ccbNumber; }
            set
            {
                _ccbNumber = value;
                RaisePropertyChanged("CCBNumber");
            }
        }
        public string AffidavitNumber
        {
            get { return _affidavitNumber; }
            set
            {
                _affidavitNumber = value;
                RaisePropertyChanged("AffidavitNumber");
            }
        }
        public string DateIssuedFrom
        {
            get { return _dateIssuedFrom; }
            set
            {
                _dateIssuedFrom = value;
                RaisePropertyChanged("DateIssuedFrom");
            }
        }
        public string DateIssuedTo
        {
            get { return _dateIssuedTo; }
            set
            {
                _dateIssuedTo = value;
                RaisePropertyChanged("DateIssuedTo");
            }
        }
        #endregion

        public ApprovedPermitsViewModel(IDataService dataService)
        {
            SearchPermitStatus = "Approved";
            _dataService = dataService;
            DateIssuedFrom = DateTime.Now.AddDays(-7).ToShortDateString();
            DateIssuedTo = DateTime.Now.ToShortDateString();
            ApplicantName = string.Empty;
            AffidavitNumber = string.Empty;
            CCBNumber = string.Empty;
            ApprovedPermits = new ObservableCollection<PermitModel>();
            SearchPermitCommand = new RelayCommand(SearchPermits);
            ClearFilterCommand = new RelayCommand(ClearFilter);
            PrintCommand = new RelayCommand(PrintPermits);
            //LoadApprovedLimitedPeriodData();
            SearchPermitsForLastOneWeek();
        }

        async void PrintPermits()
        {

        }
        async void SearchPermitsForLastOneWeek()
        {
            var permits = await _dataService.GetPermitByStatus(SearchPermitStatus);
            List<PermitModel> filteredPermits = new List<PermitModel>();
            filteredPermits = (from t1 in permits
                               where (t1.Permit.DateIssued.Value.Date >= DateTime.Parse(DateIssuedFrom).Date && t1.Permit.DateIssued.Value.Date <= DateTime.Parse(DateIssuedTo).Date) && t1.Permit.PermitApplicant.Name.ToLower().Contains(ApplicantName.ToLower()) || t1.Permit.AffidavitID.Value.Equals(AffidavitNumber)
                               orderby t1.Permit.DateIssued descending
                               select t1).ToList();
            ApprovedPermits = new ObservableCollection<PermitModel>(filteredPermits.Distinct().ToList());

        }
        /// <summary>
        /// this method will search permit based on search parameters
        /// </summary>
        async void SearchPermits()
        {
            var permits = await _dataService.GetPermitByStatus(SearchPermitStatus);
            List<PermitModel> filteredPermits = new List<PermitModel>();
            if ((string.IsNullOrEmpty(ApplicantName) && string.IsNullOrEmpty(AffidavitNumber)))
            {
                filteredPermits = (from t1 in permits
                                   where (t1.Permit.DateIssued.Value.Date >= DateTime.Parse(DateIssuedFrom).Date && t1.Permit.DateIssued.Value.Date <= DateTime.Parse(DateIssuedTo).Date) && t1.Permit.PermitApplicant.Name.ToLower().Contains(ApplicantName.ToLower()) || t1.Permit.AffidavitID.Value.Equals(AffidavitNumber)
                                   orderby t1.Permit.DateIssued descending
                                   select t1).ToList();
            }
            else {
                filteredPermits = (from t1 in permits
                                   where (t1.Permit.DateIssued.Value.Date >= DateTime.Parse("06/22/2017").Date && t1.Permit.DateIssued.Value.Date <= DateTime.Parse(DateIssuedTo).Date) && t1.Permit.PermitApplicant.Name.ToLower().Contains(ApplicantName.ToLower()) || t1.Permit.AffidavitID.Value.Equals(AffidavitNumber)
                                   orderby t1.Permit.DateIssued descending
                                   select t1).ToList();
                if (!string.IsNullOrEmpty(ApplicantName))
                {
                    
                    CCBNumber = string.Empty;
                    if (!string.IsNullOrEmpty(AffidavitNumber))
                    {
                        filteredPermits = filteredPermits.Where(x => (x.Applicant.Name.ToUpper().Contains(ApplicantName.ToUpper())) && (x.Permit.AffidavitID.Value.ToString().Contains(AffidavitNumber))).ToList();
                    }
                    else
                    {
                        filteredPermits = filteredPermits.Where(x => x.Applicant.Name.ToUpper().Contains(ApplicantName.ToUpper())).ToList();
                    }
                }
                //else if (!string.IsNullOrEmpty(CCBNumber))
                //{
                //    ApplicantName = string.Empty;
                //    if (!string.IsNullOrEmpty(AffidavitNumber))
                //    {
                //        filteredPermits = filteredPermits.Where(x => (x.Permit.BuilderBoardNo.Contains(CCBNumber)) && (x.Permit.AffidavitID.Value.ToString().Contains(AffidavitNumber))).ToList();
                //    }
                //    else
                //    {
                //        filteredPermits = filteredPermits.Where(x => x.Permit.BuilderBoardNo.Contains(CCBNumber)).ToList();
                //    }
                //}
                else if (string.IsNullOrEmpty(ApplicantName) && !string.IsNullOrEmpty(AffidavitNumber))
                {
                    filteredPermits = filteredPermits.Where(x => x.Permit.AffidavitID.Value.ToString().Contains(AffidavitNumber)).ToList();
                }
            }
            //filteredPermits.AddRange(permits.Where(x => x.Permit.DateIssued.Value.Date >= DateTime.Parse(DateIssuedFrom).Date && x.Permit.DateIssued.Value.Date <= DateTime.Parse(DateIssuedTo).Date || x.Permit.PermitApplicant.Name.ToLower().Contains(ApplicantName.ToLower()) || x.Permit.AffidavitID.Value.Equals(AffidavitNumber)).ToList());
            ApprovedPermits = new ObservableCollection<PermitModel>(filteredPermits.Distinct().ToList());
           
        }
        /// <summary>
        /// this method will clear all filters
        /// </summary>
        void ClearFilter()
        {
            DateIssuedFrom = DateTime.Now.AddDays(-7).ToShortDateString();
            DateIssuedTo = DateTime.Now.ToShortDateString();
            ApplicantName = string.Empty;
            AffidavitNumber = string.Empty;
            CCBNumber = string.Empty;
            //LoadApprovedLimitedPeriodData();
            SearchPermitsForLastOneWeek();
        }
        /// <summary>
        /// this method will show Approved permits
        /// </summary>
        async void LoadApprovedLimitedPeriodData()
        {
            ApprovedPermits = await _dataService.GetPermitByStatus(SearchPermitStatus);
        }

    }
}
