using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using PDX.PBOT.SWPermit.Reporting;

using SidewalkPermitWPF.Helper;
using SidewalkPermitWPF.MessageInfrastructure;
using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using WPF.MDI;
using SidewalkPermitWPF.ViewModel;
using System.Threading;

namespace SidewalkPermitWPF.ViewModel
{
    public class ReviewModifyTransferPermitViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private readonly IDataService _dataService;
        ObservableCollection<CCBContractor> _contractors;
        ObservableCollection<PermitApplicant> _permitApplicants;

        

        ObservableCollection<sw_posting> _affidavits;
        ObservableCollection<sw_action_detail> _affidavitCostDetail;
        ObservableCollection<PermitCostsDetail> _permitCostsDetail;
        /// <summary>
        /// Declaring EmployeeInfo object for Save and Messanger purpose
        /// Passing Parameters from View to ViewModel
        /// </summary>
        CCBContractor _contractorInfo;
        PermitApplicant _applicantInfo;
        sw_posting _affidavitInfo;
        sw_action_detail _affidavitCostDetailInfo;
        PermitPayment _permitPaymentInfo;
        Permit _permitInfo;
        ObservableCollection<string> _contractorList;
        MdiContainer _container;
        //int p1Count;
        /// <summary>
        /// The declaration used in case of search affidavit
        /// </summary>

        string _totalFee;
        string _cancelNotes;
        string _expirationDate;
        DateTime _permitExtendedDate;
        DateTime _currentExpiration;
        bool _contractorRadio;
        bool _ownerRadio;
        bool _otherRadio;
        string _permitNumber;
        string _ccbNumber;
        string _ccbNumberOld;
        string _applicantName;
        string _contact;
        string _address;
        string _city;
        string _st;
        string _zip;
        string _phoneNumber;
        bool _cardRadio;
        bool _checkRadio;
        bool _cashRadio;
        string _searchKeyword;
        string _selectedContractor;
        long _previousApplicant;
        bool _isPermitExtended;
        bool _isDatePickerEnabled;
        string _selectedPrintOption;
        private List<string> _printOptionData = new List<string>();


        public string SelectedPrintOption
        {
            get { return _selectedPrintOption; }
            set
            {
                _selectedPrintOption = value;
                RaisePropertyChanged("SelectedPrintOption");
            }
        }
        public List<string> PrintOptionData
        {
            get
            {
                return this._printOptionData;
            }
            set
            {
                this._printOptionData = value;
                RaisePropertyChanged("PrintOptionData ");
            }
        }
        public bool IsDatePickerEnabled
        {
            get { return _isDatePickerEnabled; }
            set
            {
                _isDatePickerEnabled = value;
                RaisePropertyChanged("IsDatePickerEnabled");
            }
        }
        public DateTime IssuedDate { get; set; }
        public string IssuedBy { get; set; }
        public DateTime PermitExtendedDate
        {
            get { return _permitExtendedDate; }
            set
            {
                _permitExtendedDate = value;
                RaisePropertyChanged("PermitExtendedDate");
            }
        }
        
                    public DateTime CurrentExpiration
        {
            get { return _currentExpiration; }
            set
            {
                _currentExpiration = value;
                RaisePropertyChanged("CurrentExpiration");
            }
        }
        public bool IsPermitExtended
        {
            get { return _isPermitExtended; }
            set
            {
                _isPermitExtended = value;
                RaisePropertyChanged("IsPermitExtended");
            }
        }
        public long PreviousApplicantID
        {
            get { return _previousApplicant; }
            set
            {
                _previousApplicant = value;
                RaisePropertyChanged("PreviousApplicantID");
            }
        }
        public string SearchKeyword
        {
            get { return _searchKeyword; }
            set
            {
                _searchKeyword = value;
                RaisePropertyChanged("SearchKeyword");
            }
        }
        public string SelectedContractor
        {
            get { return _selectedContractor; }
            set
            {
                _selectedContractor = value;
                RaisePropertyChanged("SelectedContractor");
            }
        }
        public string TotalFee
        {
            get { return _totalFee; }
            set
            {
                _totalFee = value;
                RaisePropertyChanged("TotalFee");
            }
        }
        public string CancelNotes
        {
            get { return _cancelNotes; }
            set
            {
                _cancelNotes = value;
                RaisePropertyChanged("CancelNotes");
            }
        }
        public string ExpirationDate
        {
            get { return _expirationDate; }
            set
            {
                _expirationDate = value;
                RaisePropertyChanged("ExpirationDate");
            }
        }

        public bool ContractorRadio
        {
            get { return _contractorRadio; }
            set
            {
                _contractorRadio = value;
                RaisePropertyChanged("ContractorRadio");
            }
        }
        public bool OwnerRadio
        {
            get { return _ownerRadio; }
            set
            {
                _ownerRadio = value;
                RaisePropertyChanged("OwnerRadio");
            }
        }
        public bool OtherRadio
        {
            get { return _otherRadio; }
            set
            {
                _otherRadio = value;
                RaisePropertyChanged("OtherRadio");
            }
        }
        public bool CardRadio
        {
            get { return _cardRadio; }
            set
            {
                _cardRadio = value;
                RaisePropertyChanged("CardRadio");
            }
        }
        public bool CheckRadio
        {
            get { return _checkRadio; }
            set
            {
                _checkRadio = value;
                RaisePropertyChanged("CheckRadio");
            }
        }
        public bool CashRadio
        {
            get { return _cashRadio; }
            set
            {
                _cashRadio = value;
                RaisePropertyChanged("CashRadio");
            }
        }
        public string PermitNumber
        {
            get { return _permitNumber; }
            set
            {
                _permitNumber = value;
                RaisePropertyChanged("PermitNumber");
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
        public string CCBNumberOld
        {
            get { return _ccbNumberOld; }
            set
            {
                _ccbNumberOld = value;
                RaisePropertyChanged("CCBNumberOld");
            }
        }
        public string ApplicantName
        {
            get { return _applicantName; }
            set
            {
                _applicantName = value;
                RaisePropertyChanged("ApplicantName");
            }
        }
        public string Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                RaisePropertyChanged("Contact");
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                RaisePropertyChanged("Address");
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                RaisePropertyChanged("City");
            }
        }
        public string ST
        {
            get { return _st; }
            set
            {
                _st = value;
                RaisePropertyChanged("ST");
            }
        }
        public string Zip
        {
            get { return _zip; }
            set
            {
                _zip = value;
                RaisePropertyChanged("Zip");
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                RaisePropertyChanged("PhoneNumber");
            }
        }
        bool _saveButtonModel;
        public bool SaveButtonModel
        {
            get { return _saveButtonModel; }
            set
            {
                _saveButtonModel = value;
                RaisePropertyChanged("SaveButtonModel");
            }
        }

        public ObservableCollection<CCBContractor> Contractors
        {
            get { return _contractors; }
            //Property's Setter calls RaisedPropertyChanged method which will internally raise 
            //PropertyChanged event when the data from the collection changes.
            set
            {
                _contractors = value;
                RaisePropertyChanged("Contractors");
            }
        }
        public ObservableCollection<string> ContractorList
        {
            get { return _contractorList; }
            //Property's Setter calls RaisedPropertyChanged method which will internally raise 
            //PropertyChanged event when the data from the collection changes.
            set
            {
                _contractorList = value;
                RaisePropertyChanged("ContractorList");
            }
        }
        public ObservableCollection<PermitApplicant> PermitApplicants
        {
            get { return _permitApplicants; }
            //Property's Setter calls RaisedPropertyChanged method which will internally raise 
            //PropertyChanged event when the data from the collection changes.
            set
            {
                _permitApplicants = value;
                RaisePropertyChanged("PermitApplicants");
            }
        }
        public ObservableCollection<sw_posting> Affidavits
        {

            get { return _affidavits; }

            set
            {
                _affidavits = value;
                RaisePropertyChanged("Affidavits");
            }
        }
        public ObservableCollection<sw_action_detail> AffidavitCostsDetails
        {

            get { return _affidavitCostDetail; }

            set
            {
                _affidavitCostDetail = value;
                RaisePropertyChanged("AffidavitCostsDetails");
            }
        }
        public ObservableCollection<PermitCostsDetail> PermitCostsDetails
        {

            get { return _permitCostsDetail; }

            set
            {
                _permitCostsDetail = value;
                RaisePropertyChanged("PermitCostsDetails");
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
        public PermitApplicant ApplicantInfo
        {
            get { return _applicantInfo; }
            set
            {
                _applicantInfo = value;
                RaisePropertyChanged("ApplicantInfo");
                //Dispatcher.CurrentDispatcher.BeginInvoke(
                //new Action<String>(PropertyChanged()),
                //DispatcherPriority.DataBind, "RunAfter");
            }
        }
        public PermitPayment PermitPaymentInfo
        {
            get { return _permitPaymentInfo; }
            set
            {
                _permitPaymentInfo = value;
                RaisePropertyChanged("PermitPaymentInfo");
            }
        }
        public Permit PermitInfo
        {
            get { return _permitInfo; }
            set
            {
                _permitInfo = value;
                RaisePropertyChanged("PermitInfo");
            }
        }
        public sw_posting AffidavitInfo
        {
            get { return _affidavitInfo; }
            set
            {
                _affidavitInfo = value;
                RaisePropertyChanged("AffidavitInfo");
            }
        }
        public sw_action_detail AffidavitCostsDetailInfo
        {
            get { return _affidavitCostDetailInfo; }
            set
            {
                _affidavitCostDetailInfo = value;
                RaisePropertyChanged("AffidavitCostsDetailInfo");
            }
        }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand ContractorChecked { get; set; }
        public RelayCommand CancelCommand { get; set; }
        public RelayCommand SearchContractorCommand { get; set; }
        public RelayCommand ContractorSelectCommand { get; set; }
        public RelayCommand PrintCommand { get; set; }
        public RelayCommand OwnerChecked { get; set; }
        public RelayCommand OtherChecked { get; set; }
        public RelayCommand ShowPermitHistoryCommand { get; set; }
        public ReviewModifyTransferPermitViewModel(IDataService dataService, PermitModel permit, MdiContainer container)
        {
            _container = container;
            _dataService = dataService;
            //AffidavitInfo = new sw_posting();
            ContractorInfo = new CCBContractor();
            GetAffidavitByNumber(permit.Permit.AffidavitID.ToString());
            GetContractorByCCB(permit.Permit.BuilderBoardNo);
            IsDatePickerEnabled = true;
            ApplicantInfo = permit.Applicant;
            PreviousApplicantID = permit.Applicant.ApplicantID;
            CCBNumber = permit.Permit.BuilderBoardNo;
            CCBNumberOld = permit.Permit.BuilderBoardNo;
            PermitInfo = permit.Permit;

            ApplicantName = permit.Applicant.Name;
            Contact=permit.Applicant.Contact;
            Address = permit.Applicant.Address;
            City = permit.Applicant.City;
            ST = permit.Applicant.State;
            Zip = permit.Applicant.Zip;
            PhoneNumber = permit.Applicant.PhoneNumber;

            GetPermitPayment(permit.Permit.PermitID);
            ContractorList = new ObservableCollection<string>();
            PermitNumber = permit.Permit.PermitID.ToString();
            if (permit.Applicant.ApplicantType == "Contractor")
                ContractorRadio = true;
            if (permit.Applicant.ApplicantType == "Owner")
                OwnerRadio = true;
            if (permit.Applicant.ApplicantType == "Other")
                OtherRadio = true;
            AffidavitCostsDetails = new ObservableCollection<sw_action_detail>();
            //GetAffidavitCostsDetails(permit.Permit.AffidavitID.ToString());
            PermitCostsDetails = new ObservableCollection<PermitCostsDetail>();
            GetPermitCostsDetails(permit.Permit.AffidavitID.ToString());

            IssuedBy = "NA";
            IssuedDate = DateTime.MaxValue;
            IsPermitExtended = (PermitInfo.PermitExtended.Equals("Yes")) ? true : false;
            UpdateCommand = new RelayCommand(UpdatePermit);
            ContractorChecked = new RelayCommand(UpdateContractor);
            CancelCommand = new RelayCommand(Cancel);
            SearchContractorCommand = new RelayCommand(ContractorSearch);
            ContractorSelectCommand = new RelayCommand(ContractorSelect);
            PrintCommand = new RelayCommand(PrintPermit);
            OwnerChecked = new RelayCommand(OwnerRadioChanged);
            OtherChecked = new RelayCommand(OtherRadioChanged);
            ShowPermitHistoryCommand = new RelayCommand(ShowPermitHistory);
            //PermitInfo.DateExpiredNew = PermitInfo.DateExpired;
            PermitReportFactory.AppEnvironment = ConfigurationManager.AppSettings["AppEnvironment"];
            SaveButtonModel = true;
            //Full Set=2 Copies +Instructions, CustomerSet = 1 Copy +Instructions, FileCopy = Our Copy, Instructions =Instructions only, Permit = 1 Copy, None = No print
            PrintOptionData.Add("None");
            //PrintOptionData.Add("Permit");
            //PrintOptionData.Add("Instructions");
            PrintOptionData.Add("File Copy");
            PrintOptionData.Add("Customer Copy");
            PrintOptionData.Add("Customer and File Copy");
            SelectedPrintOption = "None";
        }

        async void GetAffidavitByNumber(string affidavitId)
        {
            AffidavitInfo = await _dataService.GetAffidavitByNumber(affidavitId).ConfigureAwait(false);
        }

        async void GetContractorByCCB(string ccbNumber)
        {
            ContractorInfo = await _dataService.GetContractor(ccbNumber);
        }
        
        void ShowPermitHistory()
        {
            PermitHistoryView permitHistory = new PermitHistoryView();
            permitHistory.DataContext = new PermitHistoryViewModel(_dataService, PermitInfo.PermitID);
            permitHistory.ShowDialog();
        }
        void OwnerRadioChanged()
        {
            ApplicantInfo.ApplicantType = "Owner";
            CCBNumber = string.Empty;
        }

        void OtherRadioChanged()
        {
            ApplicantInfo.ApplicantType = "Other";
            CCBNumber = string.Empty;
        }

        async void PrintPermit()
        {
            PermitModel permit = new PermitModel();
            permit.Affidavit = AffidavitInfo;
            permit.Contractor = ContractorInfo;
            permit.Permit = PermitInfo;
            permit.Applicant = ApplicantInfo;
            permit.AffidavitCostDetails = AffidavitCostsDetails.ToList();
            //MainWindow window = new MainWindow();
            //ApprovedPermitReport rpt = new ApprovedPermitReport(permit.Permit.PermitID.ToString(), permit.Affidavit.aff_no.ToString());
            //rpt.Show();
            //DirectoryInfo dirInfo = new DirectoryInfo(@"\\pdotfile1\apps\SidewalkPosting\Documents\PDF\Test");
            //DirectoryInfo dirInfo = new DirectoryInfo(@"\\pdotfile1\apps\SidewalkPosting\Documents\PDF");
            //FileInfo[] pdfFiles = dirInfo.GetFiles(permit.Permit.PermitNo.ToString() + ".pdf");

            //if (pdfFiles.Length == 1)
            //{
            //    Process.Start(pdfFiles[0].FullName);
            //}

            //GeneratePDF(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo);

            //DirectoryInfo dirInfo = new DirectoryInfo(@"\\pdotfile1\apps\SidewalkPosting\Documents\PDF\Test");
            //FileInfo[] pdfFiles = dirInfo.GetFiles(PermitInfo.Permit.PermitNo.ToString() + ".pdf");
            var permitUpdateObj = await _dataService.GetPermitByAffidavit(PermitInfo.AffidavitID.Value);
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["PDFPath"].ToString()))
            {
                string path = ConfigurationManager.AppSettings["PDFPath"].ToString()+ permitUpdateObj.PermitNo + ".pdf";
                Process.Start(path);
            }

        }
        public void GeneratePDF(string permitID, string permitNo)
        {
            //PermitReportFactory.AppEnvironment = environment; // Remove or commment out this line for production release.
            // Remove or commment out this line for production release.
            // Generate PDF report
            try
            {
                PermitReportFactory.Instance.GenerateRepairPermitPDF(permitID, permitNo);
                //MessageBox.Show("Permit has been approved.", "Success");
            }
            catch (Exception genExc)
            {
                MessageBox.Show(genExc.Message, "'Throws Away' The exception generated by reporting dll's");
            }


            // Get the full path to the report to display or print
            //string permitPath = PermitReportFactory.Instance.LastRepairPermitPath;

            // Display the report
            //if (!string.IsNullOrEmpty(permitPath))
            //    PermitBrowser.Navigate(PermitReportFactory.Instance.LastRepairPermitPath);
        }
        internal async void CancelDialog(string comments)
        {
            if (!string.IsNullOrEmpty(comments))
            {
                var permitUpdateObj = await _dataService.GetPermitByAffidavit(PermitInfo.AffidavitID.Value);
                permitUpdateObj.PermitStatus = Constants.PermitStatus_Cancelled;
                permitUpdateObj.Notes = "Cancellation reason: " + comments;
                permitUpdateObj.PermitIssued = "No";
                permitUpdateObj.CancelledBy = new string(Environment.UserName.ToUpper().Take(3).ToArray());
                await _dataService.InsertPermitHistory(PermitInfo.PermitID, "Cancelled", permitUpdateObj.Notes);
                await _dataService.UpdatePermit(permitUpdateObj);
            }
            MainWindow window = new MainWindow();
            window.allPermitsApproved(_container);
        }
        
        async void Cancel()
        {
            if (PermitInfo.PermitStatus == 2)
            {
                CancelDialog cancelDialogObj = new CancelDialog(this);
                cancelDialogObj.ShowDialog();
            }
            else
            {
                MessageBox.Show("The permit has been Cancelled already.");
            }
        }
        async void UpdatePermit()
        {
            bool transferred = false;
            //Transfer to another Applicant
            if (ApplicantName != ApplicantInfo.Name)
            {
                SaveButtonModel = false;
                // Initialize dictionary
                //Dictionary<string, string> dictionaryPermitBatch = new Dictionary<string, string>();

                var previousApplicant = await _dataService.GetPermitApplicant(PreviousApplicantID);
                string previousApplicantDetail = string.Format("({0}) {1}-{2}", previousApplicant.ApplicantType, CCBNumberOld, previousApplicant.Name);
                if (((OwnerRadio || OtherRadio) && previousApplicant.ApplicantType == "Contractor") || ((OwnerRadio) && previousApplicant.ApplicantType == "Other") || ((OtherRadio) && previousApplicant.ApplicantType == "Owner"))
                {
                    if (ApplicantInfo.Contact == Contact)
                        ApplicantInfo.Contact = string.Empty;
                    if (ApplicantInfo.Address == Address)
                        ApplicantInfo.Address = string.Empty;
                    if (ApplicantInfo.City == City)
                        ApplicantInfo.City = string.Empty;
                    if (ApplicantInfo.State == ST)
                        ApplicantInfo.State = string.Empty;
                    if (ApplicantInfo.Zip == Zip)
                        ApplicantInfo.Zip = string.Empty;
                    if (ApplicantInfo.PhoneNumber == PhoneNumber)
                        ApplicantInfo.PhoneNumber = string.Empty;
                }
            
                if (!string.IsNullOrEmpty(ApplicantInfo.Name) && !string.IsNullOrEmpty(ApplicantInfo.PhoneNumber))
                {
                    //!String.IsNullOrEmpty(ApplicantInfo.Name) ? ApplicantInfo.Name : "";
                    //(affidavit.inspector_name != null) ? affidavit.inspector_name.ToString() : string.Empty;
                    previousApplicant.ApplicantType = ApplicantInfo.ApplicantType;

                    previousApplicant.Name = ApplicantInfo.Name;

                    previousApplicant.Contact = !string.IsNullOrEmpty(ApplicantInfo.Contact) ? ApplicantInfo.Contact : string.Empty;
                    previousApplicant.Address = !string.IsNullOrEmpty(ApplicantInfo.Address) ? ApplicantInfo.Address : string.Empty;
                    previousApplicant.City = !string.IsNullOrEmpty(ApplicantInfo.City) ? ApplicantInfo.City : string.Empty;
                    previousApplicant.State = !string.IsNullOrEmpty(ApplicantInfo.State) ? ApplicantInfo.State : string.Empty;
                    previousApplicant.Zip = !string.IsNullOrEmpty(ApplicantInfo.Zip) ? ApplicantInfo.Zip : string.Empty;
                    previousApplicant.PhoneNumber = !string.IsNullOrEmpty(ApplicantInfo.PhoneNumber) ? ApplicantInfo.PhoneNumber : string.Empty;

                    previousApplicant.Email = ApplicantInfo.Email;
                    previousApplicant.PermitID = PermitInfo.PermitID;
                    var updatedApplicant = await _dataService.InsertPermitApplicant(previousApplicant);
                    var permitUpdateObj = await _dataService.GetPermitByAffidavit(PermitInfo.AffidavitID.Value);
                    permitUpdateObj.ContractorID = PermitInfo.ContractorID;
                    permitUpdateObj.BuilderBoardNo = CCBNumber;
                    if (ApplicantInfo.ApplicantType == "Owner" || ApplicantInfo.ApplicantType == "Other")
                    {
                        permitUpdateObj.ContractorID = "PO";
                        permitUpdateObj.BuilderBoardNo = null;
                    }
                    else
                    {
                        permitUpdateObj.ContractorID = ApplicantInfo.Name;
                    }
                    permitUpdateObj.ApplicantType = ApplicantInfo.ApplicantType;
                    permitUpdateObj.ApplicantID = updatedApplicant.ApplicantID;
                    int count = int.Parse(permitUpdateObj.PermitNo.Split('P')[1]);
                    permitUpdateObj.PermitNo = permitUpdateObj.AffidavitID+"-P" + (++count).ToString();
                    PermitInfo.PermitNo = permitUpdateObj.PermitNo;
                    //PermitInfo.PermitID, "Expiration Date Changed", "Permit expiration date changed to " + PermitInfo.DateExpiredNew.Value.ToShortDateString()
                    //await _dataService.InsertPermitHistory(PermitInfo.PermitID, "Transferred ", string.Format("{0} to ({1}) {2}-{3}", previousApplicantDetail, previousApplicant.ApplicantType, CCBNumber, ApplicantInfo.Name));
                    await _dataService.InsertPermitHistory(PermitInfo.PermitID, "Transferred ", string.Format("Transferred to ({0}) {1}-{2}", previousApplicant.ApplicantType, CCBNumber, ApplicantInfo.Name));
                    await _dataService.UpdatePermit(permitUpdateObj);
                    //MessageBox.Show("Permit transferred successfully.");

                    //Comment for Aspire
                    //GeneratePDF(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo);

                    //Uncomment for Aspire
                    //// Initialize dictionary 
                    //Dictionary<string, string> dictionaryPermitBatch = new Dictionary<string, string>();
                    //dictionaryPermitBatch.Add(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo);
                    //NumberOfCopies copiesDialog = new NumberOfCopies(dictionaryPermitBatch);
                    //copiesDialog.Show();

                    //try
                    //{
                    //    //Full Set = 2 Copies + Instructions, CustomerSet = 1 Copy + Instructions, FileCopy = Our Copy, Instructions = Instructions only, Permit = 1 Copy, None = No print
                    //        if (SelectedPrintOption == "Customer Copy")
                    //    {
                    //        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.DuplexedCustomerSet);
                    //    }
                    //    else if (SelectedPrintOption == "File Copy")
                    //    {
                    //        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.FileCopy);
                    //    }
                    //    else if (SelectedPrintOption == "Customer and File Copy")
                    //    {
                    //        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.DuplexedFullSet);
                    //    }
                    //    else
                    //    {
                    //        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.None);
                    //    }

                    //    //PermitReportFactory.Instance.ProcessRepairPermits(dictionaryPermitBatch);
                    //    //dictionaryPermitBatch.Clear();
                    //}
                    //catch (Exception processExc)
                    //{
                    //    throw processExc;
                    //}

                    ApplicantName = ApplicantInfo.Name;
                    PreviousApplicantID = updatedApplicant.ApplicantID;
                    transferred = true;
                    //MainWindow window = new MainWindow();
                    //window.allPermitsOpen(_container);
                }
                else
                {
                    MessageBox.Show("Name and Phone number are required fields");
                    SaveButtonModel = true;
                }
            }

            // Extension of the Permit
            var permitUpdateObject = await _dataService.GetPermitByAffidavit(PermitInfo.AffidavitID.Value);
           
            if ((CurrentExpiration == DateTime.MinValue && PermitInfo.DateExpiredNew!=null && PermitInfo.DateExpiredNew != PermitInfo.DateExpired && permitUpdateObject.DateExpiredNew != PermitInfo.DateExpiredNew ) || (CurrentExpiration!= DateTime.MinValue && PermitInfo.DateExpiredNew != CurrentExpiration ))
            {
                SaveButtonModel = false;

                permitUpdateObject = await _dataService.GetPermitByAffidavit(PermitInfo.AffidavitID.Value);
                permitUpdateObject.DateExpiredNew = PermitInfo.DateExpiredNew;
                int count = int.Parse(permitUpdateObject.PermitNo.Split('P')[1]);
                if (transferred)
                {
                    permitUpdateObject.PermitNo = permitUpdateObject.AffidavitID + "-P" + (count).ToString();
                }
                else
                {
                    permitUpdateObject.PermitNo = permitUpdateObject.AffidavitID + "-P" + (++count).ToString();
                }
                //permitUpdateObj.DatePermitExtended = DateTime.Now;
                permitUpdateObject.PermitExtended = "Yes";
                    await _dataService.InsertPermitHistory(PermitInfo.PermitID, "Expiration date changed", "Expiration date changed to " + PermitInfo.DateExpiredNew.Value.ToShortDateString());
                    //+ ExpirationDate + " to "
                    await _dataService.UpdatePermit(permitUpdateObject);
                    _currentExpiration = (DateTime)PermitInfo.DateExpiredNew;
                //MessageBox.Show("Permit expiration date changed successfully.");
                PermitInfo.PermitNo = permitUpdateObject.PermitNo;
                //Dictionary<string, string> dictionaryPermitBatch = new Dictionary<string, string>();
                //dictionaryPermitBatch.Add(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo);
                //NumberOfCopies copiesDialog = new NumberOfCopies(dictionaryPermitBatch);
                //copiesDialog.Show();
                //GeneratePDF(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo);
                
                //try
                //{
                //    //Full Set = 2 Copies + Instructions, CustomerSet = 1 Copy + Instructions, FileCopy = Our Copy, Instructions = Instructions only, Permit = 1 Copy, None = No print
                //    if (SelectedPrintOption == "Customer Copy")
                //    {
                //        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.DuplexedCustomerSet);
                //    }
                //    else if (SelectedPrintOption == "File Copy")
                //    {
                //        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.FileCopy);
                //    }
                //    else if (SelectedPrintOption == "Customer and File Copy")
                //    {
                //        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.DuplexedFullSet);
                //    }
                //    else
                //    {
                //        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.None);
                //    }

                //    //PermitReportFactory.Instance.ProcessRepairPermits(dictionaryPermitBatch);
                //    //dictionaryPermitBatch.Clear();
                //}
                //catch (Exception processExc)
                //{
                //    throw processExc;
                //}
                
            //PermitInfo.DateExpired = PermitInfo.DateExpiredNew;         
            }

            //Updating the Applicant details
            if (!string.IsNullOrEmpty(ApplicantInfo.Name) && !string.IsNullOrEmpty(ApplicantInfo.PhoneNumber) && (ApplicantName == ApplicantInfo.Name))
            {
                SaveButtonModel = false;
                if (OwnerRadio || OtherRadio)
                {
                    var previousApplicant = await _dataService.GetPermitApplicant(PreviousApplicantID);
                    if (ApplicantInfo.ApplicantType == "Owner")
                    {
                        previousApplicant.ApplicantType = "Owner";
                    }
                    else if (ApplicantInfo.ApplicantType == "Other")
                    {
                        previousApplicant.ApplicantType = "Other";
                    }
                    previousApplicant.Name = ApplicantInfo.Name;

                    previousApplicant.Contact = !string.IsNullOrEmpty(ApplicantInfo.Contact) ? ApplicantInfo.Contact : string.Empty;
                    previousApplicant.Address = !string.IsNullOrEmpty(ApplicantInfo.Address) ? ApplicantInfo.Address : string.Empty;
                    previousApplicant.City = !string.IsNullOrEmpty(ApplicantInfo.City) ? ApplicantInfo.City : string.Empty;
                    previousApplicant.State = !string.IsNullOrEmpty(ApplicantInfo.State) ? ApplicantInfo.State : string.Empty;
                    previousApplicant.Zip = !string.IsNullOrEmpty(ApplicantInfo.Zip) ? ApplicantInfo.Zip : string.Empty;
                    previousApplicant.PhoneNumber = !string.IsNullOrEmpty(ApplicantInfo.PhoneNumber) ? ApplicantInfo.PhoneNumber : string.Empty;

                    previousApplicant.Email = ApplicantInfo.Email;
                    previousApplicant.PermitID = PermitInfo.PermitID;
                    var updatedApplicant = await _dataService.UpdatePermitApplicant(previousApplicant);
                    //MessageBox.Show("Permit updated successfully.");
                    GeneratePDF(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo);

                    //ApplicantInfo.Contact = string.Empty;
                    //ApplicantInfo.Address = string.Empty;
                    //ApplicantInfo.City = string.Empty;
                    //ApplicantInfo.State = string.Empty;
                    //ApplicantInfo.Zip = string.Empty;
                }
                if (ContractorRadio)
                {
                    var previousApplicant = await _dataService.GetPermitApplicant(PreviousApplicantID);
                    previousApplicant.Contact = ApplicantInfo.Contact;
                    previousApplicant.PhoneNumber = ApplicantInfo.PhoneNumber;
                    var updatedApplicant = await _dataService.UpdatePermitApplicant(previousApplicant);
                    GeneratePDF(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo);
                    //MessageBox.Show("Permit updated successfully.");
                }
                if (!string.IsNullOrEmpty(ApplicantInfo.Name) && string.IsNullOrEmpty(ApplicantInfo.PhoneNumber) && (ApplicantName == ApplicantInfo.Name))
                {
                    MessageBox.Show("Name and Phone number are required fields");
                    SaveButtonModel = true;
                }
            }

            if (!string.IsNullOrEmpty(ApplicantInfo.Name) && !string.IsNullOrEmpty(ApplicantInfo.PhoneNumber))
            {
                //MessageBox.Show("Permit saved successfully.");
                SaveButtonModel = true;
                Dictionary<string, string> dictionaryPermitBatch = new Dictionary<string, string>();
                dictionaryPermitBatch.Add(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo);

                try
                {
                    //Full Set = 2 Copies + Instructions, CustomerSet = 1 Copy + Instructions, FileCopy = Our Copy, Instructions = Instructions only, Permit = 1 Copy, None = No print
                    if (SelectedPrintOption == "Customer Copy")
                    {
                        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.DuplexedCustomerSet);
                    }
                    else if (SelectedPrintOption == "File Copy")
                    {
                        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.FileCopy);
                    }
                    else if (SelectedPrintOption == "Customer and File Copy")
                    {
                        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.DuplexedFullSet);
                    }
                    else
                    {
                        PermitReportFactory.Instance.ProcessRepairPermits(PermitInfo.PermitID.ToString(), PermitInfo.PermitNo, PermitPrint.Option.None);
                    }

                    //PermitReportFactory.Instance.ProcessRepairPermits(dictionaryPermitBatch);
                    //dictionaryPermitBatch.Clear();
                }
                catch (Exception processExc)
                {
                    throw processExc;
                }
                //NumberOfCopies copiesDialog = new NumberOfCopies(dictionaryPermitBatch);
                //Thread.Sleep(12000);
                //copiesDialog.Show();
            }
        }

     
        void UpdateContractor()
        {
            ApplicantInfo.ApplicantType = "Contractor";
        }
        async void ContractorSelect()
        {
            if (ContractorList.Count > 0)
            {
                var contractor = await _dataService.GetContractor(SelectedContractor.Split(',')[0]);
                PermitInfo.ContractorID = SelectedContractor.Split(',')[1].ToString();
                PermitApplicant applicant = new PermitApplicant();
                applicant.ApplicantType = "Contractor";
                CCBNumber = contractor.license_number;
                applicant.Name = (!string.IsNullOrEmpty(contractor.alias_name) ? contractor.alias_name : contractor.business_name);
                applicant.Contact = contractor.rmi_name;
                applicant.Address = contractor.address;
                applicant.City = contractor.city;
                applicant.State = contractor.state;
                applicant.Zip = contractor.zip;
                applicant.PhoneNumber = contractor.business_telephone;
                ApplicantInfo = applicant;
                ContractorList.Clear();
                SearchKeyword = string.Empty;
            }
        }
        async void ContractorSearch()
        {
            var text = SearchKeyword;
            ContractorList.Clear();
            if (SearchKeyword.Length >= 2)
            {
                var contractors = await _dataService.GetContractorByKeyword(SearchKeyword);
                if (contractors != null && contractors.Count > 0)
                {
                    foreach (var item in contractors)
                    {
                        ContractorList.Add(string.Format("{0}, {1}", item.license_number, (!string.IsNullOrEmpty(item.alias_name) ? item.alias_name : item.business_name)));
                    }
                }
                else
                {
                    ContractorList.Clear();
                    ContractorList.Add("No results found");
                }
            }
        }
        async void GetPermitPayment(long permitID)
        {
            PermitPaymentInfo = await _dataService.GetPermitPayment(permitID);
            if (PermitPaymentInfo.PaymentMethod == Constants.PermitPaymentMethod_Card)
                CardRadio = true;
            if (PermitPaymentInfo.PaymentMethod == Constants.PermitPaymentMethod_Check)
                CheckRadio = true;
            if (PermitPaymentInfo.PaymentMethod == Constants.PermitPaymentMethod_Cash)
                CashRadio = true;
        }
        ////AffidavitCostsDetailInfo
        //async void GetAffidavitCostsDetails(string affidavitNo)
        //{
        //    var rateList = await _dataService.GetRepairItemRate();
        //    var affidavitCostsDetails = await _dataService.GetAffidavitCostDetails(affidavitNo, "R");
        //    TotalFee = "0.00";
        //    foreach (var item in affidavitCostsDetails)
        //    {
        //        if (item.action_type.Equals(Constants.RepairItem_Sidewalk))
        //        {
        //            item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Sidewalk)).FirstOrDefault().CurrentRate;
        //            item.cost = decimal.Parse((item.unit * item.rate).ToString("0.00"));
        //            TotalFee = (decimal.Parse(TotalFee) + (item.unit * item.rate)).ToString("0.00");
        //            AffidavitCostsDetails.Add(item);
        //        }
        //        if (item.action_type.Equals(Constants.RepairItem_Driveway))
        //        {
        //            item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Driveway)).FirstOrDefault().CurrentRate;
        //            item.cost = decimal.Parse((item.unit * item.rate).ToString("0.00"));
        //            TotalFee = (decimal.Parse(TotalFee) + (item.unit * item.rate)).ToString("0.00");
        //            AffidavitCostsDetails.Add(item);
        //        }
        //        if (item.action_type.Contains("Curb"))
        //        {
        //            item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Curbs)).FirstOrDefault().CurrentRate;
        //            item.cost = decimal.Parse((item.unit * item.rate).ToString("0.00"));
        //            TotalFee = (decimal.Parse(TotalFee) + (item.unit * item.rate)).ToString("0.00");
        //            AffidavitCostsDetails.Add(item);
        //        }
        //        TotalFee = (decimal.Parse(TotalFee)).ToString("0.00");
        //    }   
        //    if (double.Parse(TotalFee) >= 500.00)
        //        TotalFee = "500.00";
        //    else if (double.Parse(TotalFee) <= 60.00)
        //        TotalFee = "60.00";
        //    DateTime calculatedDate = DateTime.Now.AddDays(30);
        //    DateTime affidavitDueDate = DateTime.Now;
        //    if (AffidavitInfo!=null)
        //        affidavitDueDate = AffidavitInfo.post_dt.Value.AddDays(67);
        //    if (calculatedDate > affidavitDueDate)
        //    {
        //        ExpirationDate = calculatedDate.ToShortDateString();
        //    }
        //    else
        //    {
        //        ExpirationDate = affidavitDueDate.ToShortDateString();
        //    }
        //}

        //PermitCostsDetailInfo
        async void GetPermitCostsDetails(string affidavitNo)
        {
            var permitCostsDetail = await _dataService.GetPermitCostsDetail(affidavitNo);
            
            TotalFee = permitCostsDetail.Sum(x => x.Cost).ToString();

            PermitCostsDetails = permitCostsDetail;
            var minmaxFee = await _dataService.GetPermitFee();
            if (double.Parse(TotalFee) >= double.Parse(minmaxFee.MaximumFee.Value.ToString("0.00")))
                TotalFee = minmaxFee.MaximumFee.Value.ToString("0.00");
            else if (double.Parse(TotalFee) <= double.Parse(minmaxFee.MinimumFee.Value.ToString("0.00")))
                TotalFee = minmaxFee.MinimumFee.Value.ToString("0.00");

            //DateTime calculatedDate = DateTime.Now.AddDays(30);
            //DateTime affidavitDueDate = DateTime.Now;
            //if (AffidavitInfo != null)
            //    affidavitDueDate = AffidavitInfo.post_dt.Value.AddDays(67);

            //if (calculatedDate > affidavitDueDate)
            //{
            //    ExpirationDate = calculatedDate.ToShortDateString();

            //}
            //else
            //{
            //    ExpirationDate = affidavitDueDate.ToShortDateString();
            //}

        }


        void SendAffidavitInfo(SidewalkPermitWPF.Model.sw_posting affidavit)
        {
            if (affidavit != null)
            {
                Messenger.Default.Send<MessageCommunicator>(new MessageCommunicator()
                {
                    AffidavitInfo = affidavit
                });
            }
        }
        void SendContractor(CCBContractor contractor)
        {
            if (contractor != null)
            {
                Messenger.Default.Send<MessageCommunicator>(new MessageCommunicator()
                {
                    ContractorInfo = contractor
                });
            }
        }
    }
}
