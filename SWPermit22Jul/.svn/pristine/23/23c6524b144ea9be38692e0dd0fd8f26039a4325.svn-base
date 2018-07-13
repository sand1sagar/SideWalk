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
    public class InitialStaffPermitSelectionViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        ObservableCollection<PermitModel> _submittedPermits;

        public RelayCommand SearchPermitCommand { get; set; }
        public RelayCommand ClearFilterCommand { get; set; }
        public ObservableCollection<PermitModel> SubmittedPermits
        {

            get { return _submittedPermits; }

            set
            {
                _submittedPermits = value;
                RaisePropertyChanged("SubmittedPermits");
            }
        }
        string _applicantName;
        string _affidavitNumber;
        string _ccbNumber;
        public string ApplicantName
        {
            get { return _applicantName; }
            set
            {
                _applicantName = value;
                RaisePropertyChanged("ApplicantName");
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
        public InitialStaffPermitSelectionViewModel(IDataService dataService)
        {
            _dataService = dataService;
            ApplicantName = string.Empty;
            AffidavitNumber = string.Empty;
            CCBNumber = string.Empty;
            SubmittedPermits = new ObservableCollection<PermitModel>();
            SearchPermitCommand = new RelayCommand(SearchPermits);
            ClearFilterCommand = new RelayCommand(ClearFilter);
            LoadSubmittedData();

        }

        async void SearchPermits()
        {
            var permits = await _dataService.GetPermitByStatus("Submitted");
            List<PermitModel> filteredPermits = new List<PermitModel>();
            //filteredPermits = (from t1 in filteredPermits
            //                   orderby t1.filteredPermits.DateIssued descending
            //                   select t1).ToList();
           

            if (!string.IsNullOrEmpty(ApplicantName))
            {
                CCBNumber = string.Empty;
                if (!string.IsNullOrEmpty(AffidavitNumber))
                {
                    filteredPermits = permits.Where(x => (x.Applicant.Name.ToLower().Contains(ApplicantName.ToLower())) && (x.Permit.AffidavitID.Value.ToString().Contains(AffidavitNumber))).ToList();
                }
                else
                {
                    filteredPermits = permits.Where(x => x.Applicant.Name.ToLower().Contains(ApplicantName.ToLower())).ToList();
                }
            }
            else if (!string.IsNullOrEmpty(CCBNumber))
            {
                ApplicantName = string.Empty;
                if (!string.IsNullOrEmpty(AffidavitNumber))
                {
                    filteredPermits = permits.Where(x => (x.Permit.BuilderBoardNo.Contains(CCBNumber.ToUpper())) && (x.Permit.AffidavitID.Value.ToString().Contains(AffidavitNumber))).ToList();
                }
                else
                {
                    filteredPermits = permits.Where(x => x.Permit.BuilderBoardNo.Contains(CCBNumber.ToUpper())).ToList();
                }
            }
            else if (string.IsNullOrEmpty(ApplicantName) && string.IsNullOrEmpty(CCBNumber)&& !string.IsNullOrEmpty(AffidavitNumber))
            {
                filteredPermits = permits.Where(x => x.Permit.AffidavitID.Value.ToString().Contains(AffidavitNumber)).ToList();

            }
            if (filteredPermits.Count > 0)
            {
                SubmittedPermits = new ObservableCollection<PermitModel>(filteredPermits.Distinct().ToList());
            }
            else
            {
                SubmittedPermits = permits;
            }
        }

        void ClearFilter()
        {
            ApplicantName = string.Empty;
            AffidavitNumber = string.Empty;
            CCBNumber = string.Empty;
            LoadSubmittedData();
        }



        async void LoadSubmittedData()
        {
            SubmittedPermits = await _dataService.GetPermitByStatus("Submitted");
        }
    }
}
