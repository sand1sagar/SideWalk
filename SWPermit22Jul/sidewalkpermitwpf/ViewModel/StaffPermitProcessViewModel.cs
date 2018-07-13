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
    public class StaffPermitProcessViewModel : ViewModelBase
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
        PermitModel _permitInfo;
        PermitPayment _permitPaymentInfo;
        MdiContainer _container;

        /// <summary>
        /// The declaration used in case of search affidavit
        /// </summary>

        string _totalFee;
        string _expirationDate;
        bool _contractorRadio;
        bool _ownerRadio;
        bool _otherRadio;
        bool _cardRadio;
        bool _checkRadio;
        bool _cashRadio;
        bool _acceptButtonModel;
        string _permitNumber;
        //string environment;
        public DateTime IssuedDate { get; set; }
        public string IssuedBy { get; set; }
        public string TotalFee
        {
            get { return _totalFee; }
            set
            {
                _totalFee = value;
                RaisePropertyChanged("TotalFee");
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
        public ObservableCollection<PermitCostsDetail> PermitCostsDetail
        {

            get { return _permitCostsDetail; }

            set
            {
                _permitCostsDetail = value;
                RaisePropertyChanged("PermitCostsDetail");
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
            }
        }

        public PermitModel PermitInfo
        {
            get { return _permitInfo; }
            set
            {
                _permitInfo = value;
                RaisePropertyChanged("PermitInfo");
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
        public bool AcceptButtonModel
        {
            get { return _acceptButtonModel; }
            set
            {
                _acceptButtonModel = value;
                RaisePropertyChanged("AcceptButtonModel");
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
        /// <summary>
        /// Commands
        /// </summary>
        public RelayCommand AcceptPermitCommand { get; set; }
        public RelayCommand RejectPermitCommand { get; set; }
        public RelayCommand HoldPermitCommand { get; set; }
        public StaffPermitProcessViewModel(IDataService dataService, PermitModel permit, MdiContainer container)
        {
            _container = container;
            _dataService = dataService;
            AffidavitInfo = new sw_posting();
            ContractorInfo = new CCBContractor();
            GetAffidavitByNumber(permit.Permit.AffidavitID.ToString());
            GetContractorByCCB(permit.Permit.BuilderBoardNo);
            ApplicantInfo = permit.Applicant;
            PermitPaymentInfo = new PermitPayment();
            PermitInfo = permit;
            AcceptButtonModel = true;
            //PermitNumber = permit.Permit.PermitNo.ToString();
            if (permit.Applicant.ApplicantType == "Contractor")
                ContractorRadio = true;
            if (permit.Applicant.ApplicantType == "Owner")
                OwnerRadio = true;
            if (permit.Applicant.ApplicantType == "Other")
                OtherRadio = true;
            AffidavitCostsDetails = new ObservableCollection<sw_action_detail>();
            GetAffidavitCostsDetails(permit.Permit.AffidavitID.ToString());

            PermitPaymentInfo.IssueDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            PermitPaymentInfo.IssuedBy = new string(Environment.UserName.ToUpper().Take(3).ToArray());

            AcceptPermitCommand = new RelayCommand(AcceptPermit);
            RejectPermitCommand = new RelayCommand(RejectPermit);
            HoldPermitCommand = new RelayCommand(HoldPermit);
            //Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            string env = ConfigurationManager.AppSettings["AppEnvironment"];
            PermitReportFactory.AppEnvironment = env;
        }
        async void GetAffidavitByNumber(string affidavitId)
        {
            AffidavitInfo = await _dataService.GetAffidavitByNumber(affidavitId);
            PermitInfo.Affidavit = AffidavitInfo;

        }

        async void GetContractorByCCB(string ccbNumber)
        {
            ContractorInfo = await _dataService.GetContractor(ccbNumber);
            PermitInfo.Contractor = ContractorInfo;
        }

        //>>>
        async void AcceptPermit()
        {
            if ((CardRadio && !string.IsNullOrEmpty(PermitPaymentInfo.ApprovalCode)) || (CheckRadio && !string.IsNullOrEmpty(PermitPaymentInfo.CheckNumber)) || CashRadio)
            {
                AcceptButtonModel = false;
                //if (DateTime.Parse(ExpirationDate) >= PermitInfo.Permit.DateExpired.Value.Date)
                //{
                if (CardRadio)
                {
                    PermitPaymentInfo.CheckNumber = null;
                    PermitPaymentInfo.PaymentMethod = Constants.PermitPaymentMethod_Card;
                }
                else if (CheckRadio)
                {
                    PermitPaymentInfo.ApprovalCode = null;
                    PermitPaymentInfo.PaymentMethod = Constants.PermitPaymentMethod_Check;
                }
                else if (CashRadio)
                {
                    PermitPaymentInfo.PaymentMethod = Constants.PermitPaymentMethod_Cash;
                }
                PermitPaymentInfo.PermitID = PermitInfo.Permit.PermitID;
                string OldIssuedBy = new string(Environment.UserName.ToUpper().Take(3).ToArray());
                string NewIssuedBy = new string(PermitPaymentInfo.IssuedBy.ToUpper().Take(3).ToArray());
                if (NewIssuedBy != OldIssuedBy)
                {
                    PermitPaymentInfo.IssuedBy = NewIssuedBy;
                }
                else
                {
                    PermitPaymentInfo.IssuedBy = OldIssuedBy;
                }
                PermitPaymentInfo = await _dataService.InsertPermitPayment(PermitPaymentInfo);
                if (PermitPaymentInfo.PermitPaymentID > 0)
                {
                    var permit = PermitInfo.Permit;
                    //permit.DateIssued = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    permit.DateIssued = DateTime.Now;
                    permit.DateExpired = DateTime.Parse(ExpirationDate);
                    permit.IssuedBy = PermitPaymentInfo.IssuedBy;
                    //permit.IssuedBy = new string(Environment.UserName.ToUpper().Take(3).ToArray());
                    permit.PermitIssued = "Yes";
                    permit.LastAction = Constants.PermitLastAction_Approved;
                    permit.BuilderBoardNo = "";
                    permit.PermitStatus = Constants.PermitStatus_Accepted;
                    permit.PermitNo = string.Format("{0}-P1", permit.AffidavitID);
                    permit = await _dataService.UpdatePermit(permit);
                    await _dataService.InsertPermitHistory(permit.PermitID, "Approved", "Permit approved and fees paid.");
                }
                //MessageBox.Show("Payment is successfull!");
                //if (!string.IsNullOrEmpty(ApplicantInfo.Email))
                //    EmailHelper.SendEmail(ApplicantInfo.Email, "Test");
                GeneratePDF(PermitInfo.Permit.PermitID.ToString(), PermitInfo.Permit.PermitNo);
                //DirectoryInfo dirInfo = new DirectoryInfo(@"\\pdotfile1\apps\SidewalkPosting\Documents\PDF\Test");
                //FileInfo[] pdfFiles = dirInfo.GetFiles(PermitInfo.Permit.PermitNo.ToString() + ".pdf");
                string permitPath = PermitReportFactory.Instance.LastRepairPermitPath;
                if (!String.IsNullOrEmpty(permitPath))
                {
                    Process.Start(permitPath);
                }
                //PrintPermit(PermitInfo.Permit.PermitID.ToString(), PermitInfo.Affidavit.aff_no.ToString());
                //MainWindow window = new MainWindow();
                //window.allPermitsOpen(_container);
                //}
                //else
                //{
                //    MessageBox.Show("Expiration date should be atleast 30 days from today.");
                //}
                MainWindow window = new MainWindow();
                window.allPermitsOpen(_container);
            }
            else if(CardRadio && string.IsNullOrEmpty(PermitPaymentInfo.ApprovalCode))
            {
                PermitPaymentInfo.CheckNumber = string.Empty;
                MessageBox.Show("Enter the approval code.");
                AcceptButtonModel = true;
            }
            else if (CheckRadio && string.IsNullOrEmpty(PermitPaymentInfo.CheckNumber))
            {
                PermitPaymentInfo.ApprovalCode = string.Empty;
                MessageBox.Show("Enter the check number.");
                AcceptButtonModel = true;
            }
        }
        //>>>
        public void GeneratePDF(string permitID, string permitNo)
        {
            //PermitReportFactory.AppEnvironment = environment; // Remove or commment out this line for production release.
            // Remove or commment out this line for production release.
            // Generate PDF report
            //PermitReportFactory.Instance.GenerateRepairPermitPDF(permitID, permitNo);
            //MessageBox.Show("Permit has been approved.", "Success");
            try
            {
                PermitReportFactory.Instance.GenerateRepairPermitPDF(permitID, permitNo);
                //MessageBox.Show("Permit approved successfully.", "Success");
            }
            catch (Exception genExc)
            {
                //MessageBox.Show(genExc.Message, "'Throws Away' The exception generated by reporting dll's");
                MessageBox.Show(genExc.Message, "There was an error generated while printing the report.");
            }


            // Get the full path to the report to display or print
            string permitPath = PermitReportFactory.Instance.LastRepairPermitPath;

            // Display the report
            //if (!string.IsNullOrEmpty(permitPath))
            //    PermitBrowser.Navigate(PermitReportFactory.Instance.LastRepairPermitPath);
        }
        public void PrintPermit(string permitID, string affidavitID)
        {
            MainWindow window = new MainWindow();
            //window.printingPermit(permit ,_container);
            ApprovedPermitReport rpt = new ApprovedPermitReport(permitID, affidavitID);
            rpt.Show();
        }
        async void RejectPermit()
        {
            bool result = false;
            DialogResult dialogResult= MessageBox.Show("Are you sure you want to reject the permit?", "Reject Permit", MessageBoxButtons.YesNo);
            if(dialogResult==DialogResult.Yes)
            {
                result = await _dataService.RemovePermit(PermitInfo.Permit.PermitID);
                //await _dataService.InsertPermitHistory(item.PetmitID, "Rejected", "Permit rejected.");
                if (result)
                {
                    //MessageBox.Show("Permit rejected successfully.", "Success");
                    MainWindow window = new MainWindow();
                    window.allPermitsOpen(_container);
                }
            }
        }
        async void HoldPermit()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to hold the permit?", "Hold Permit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //result = await _dataService.RemovePermit(PermitInfo.Permit.PermitID);
                //if (result)
                //{
                //MessageBox.Show("Permit wasn't processed");
                MainWindow window = new MainWindow();
                window.allPermitsOpen(_container);

            }
        }

        async void GetAffidavitCostsDetails(string affidavitNo)
        {
            var affidavitCostsDetails = await _dataService.GetAffidavitCostDetails(affidavitNo, "R");

            TotalFee = "0.00";
            var rateList = await _dataService.GetRepairItemRate();
            foreach (var item in affidavitCostsDetails)
            {
                if (item.action_type.Equals(Constants.RepairItem_Sidewalk))
                {
                    item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Sidewalk)).FirstOrDefault().CurrentRate;
                    item.cost = decimal.Parse((item.unit * item.rate).ToString("0.00"));
                    TotalFee = (decimal.Parse(TotalFee) + (item.unit * item.rate)).ToString("0.00");
                    AffidavitCostsDetails.Add(item);
                }
                if (item.action_type.Equals(Constants.RepairItem_Driveway))
                {
                    item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Driveway)).FirstOrDefault().CurrentRate;
                    item.cost = decimal.Parse((item.unit * item.rate).ToString("0.00"));
                    TotalFee = (decimal.Parse(TotalFee) + (item.unit * item.rate)).ToString("0.00");
                    AffidavitCostsDetails.Add(item);
                }
                if (item.action_type.Contains("Curb"))
                {
                    item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Curbs)).FirstOrDefault().CurrentRate;
                    item.cost = decimal.Parse((item.unit * item.rate).ToString("0.00"));
                    TotalFee = (decimal.Parse(TotalFee) + (item.unit * item.rate)).ToString("0.00");
                    AffidavitCostsDetails.Add(item);
                }
                TotalFee = (decimal.Parse(TotalFee)).ToString("0.00");
            }

            if (double.Parse(TotalFee) >= 500.00)
                TotalFee = "500.00";
            else if (double.Parse(TotalFee) <= 60.00)
                TotalFee = "60.00";

            DateTime affidavitDueDate = DateTime.MinValue;

            DateTime calculatedDate = DateTime.Now.AddDays(30.00);

            if (AffidavitInfo.NEW_RepairDueDate != null)
            {
                affidavitDueDate = (DateTime)AffidavitInfo.NEW_RepairDueDate;
            }
            else {
                affidavitDueDate = AffidavitInfo.post_dt.Value.AddDays(67.00);
            }

            if (calculatedDate > affidavitDueDate)
            {
                ExpirationDate = calculatedDate.ToShortDateString();
            }
            else
            {
                ExpirationDate = affidavitDueDate.ToShortDateString();
            }

        }

        void SendAffidavitInfo(sw_posting affidavit)
        {
            if (affidavit != null)
            {
                Messenger.Default.Send<MessageCommunicator>(new MessageCommunicator()
                {
                    AffidavitInfo = affidavit
                });
            }
        }
        void SendApplicantInfo(PermitApplicant applicant)
        {
            if (applicant != null)
            {
                Messenger.Default.Send<MessageCommunicator>(new MessageCommunicator()
                {
                    ApplicantInfo = applicant
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
