using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using SidewalkPermitWPF.Helper;
using SidewalkPermitWPF.MessageInfrastructure;
using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF.MDI;
using PDX.PBOT.SWPermit.Reporting;
using System.IO;
using System.Diagnostics;
using System.Configuration;

namespace SidewalkPermitWPF.ViewModel
{
    public class ContractorAliasViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        
        /// <summary>
        /// Declaring EmployeeInfo object for Save and Messanger purpose
        /// Passing Parameters from View to ViewModel
        /// </summary>
        CCBContractor _contractorInfo;
        MdiContainer _container;

        /// <summary>
        /// The declaration used in case of search affidavit
        /// </summary>

        string _licenseNumber;
       
        public string LicenseNumber
        {
            get { return _licenseNumber; }
            set
            {
                _licenseNumber = value;
                RaisePropertyChanged("LicenseNumber");
            }
        }
        

        public CCBContractor ContractorInfo
        {
            get { return _contractorInfo; }
            set
            {
                _contractorInfo = value;
                RaisePropertyChanged("ContractorInfo");
            }
        }
        ObservableCollection<CCBContractor> _ccbContractors;
        public ObservableCollection<CCBContractor> CCBContractorList
        {
            get { return _ccbContractors; }
            set
            {
                _ccbContractors = value;
                RaisePropertyChanged("CCBContractorList");
            }
        }


        /// <summary>
        /// Commands
        /// </summary>
        public RelayCommand SearchCCBCommand { get; set; }
        public RelayCommand UpdateCCBCommand { get; set; }
        public RelayCommand<long> deleteCCBCommand { get; set; }
        
        //public RelayCommand DeleteCCBCommand { get; set; }
        public ContractorAliasViewModel(IDataService dataService, MdiContainer container)
        {
            _container = container;
            _dataService = dataService;
            SearchCCBCommand = new RelayCommand(SearchContractor);
            UpdateCCBCommand = new RelayCommand(UpdateContractor);
            //DeleteCCBCommand = new RelayCommand(DeleteContractor);
            GetCCBAliasList();
            string env = ConfigurationManager.AppSettings["AppEnvironment"];
            PermitReportFactory.AppEnvironment = env;
            deleteCCBCommand = new RelayCommand<long>((s) => DeleteCCB(s));
        }
        async void GetCCBAliasList()
        {
            CCBContractorList = await _dataService.GetCCBAliasList();
        }
        async void SearchContractor()
        {
            ContractorInfo = null;
            var searchResult = await _dataService.GetContractor(LicenseNumber);
            if (searchResult != null && !string.IsNullOrEmpty(searchResult.business_name))
            {
                ContractorInfo = searchResult;
            }
            else
            {
                MessageBox.Show("No results were found for License number " + LicenseNumber + ". Please try with correct License number.", "No Result Found");
                LicenseNumber = string.Empty;
                //searchResult.business_name = string.Empty;
            }
        }

        async void UpdateContractor()
        {
            await _dataService.UpdateAliasName(ContractorInfo);
            //MessageBox.Show("The Alias was updated successfully.");
            GetCCBAliasList();
        }

        async void DeleteCCB(long license_number)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete the Alias?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var contractorAlias = await _dataService.GetContractor(license_number.ToString());
                await _dataService.DeleteAliasName(contractorAlias);
                //MessageBox.Show("The Alias was deleted successfully.");
            }
            GetCCBAliasList();
        }

    }
}
