using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SidewalkPermitWPF.Helper;
using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.ViewModel;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Media.Animation;
using WPF.MDI;

namespace SidewalkPermitWPF.Views
{
    /// <summary>
    /// Interaction logic for StaffPermitProcess.xaml
    /// </summary>
    public partial class StaffPermitProcess : UserControl
    {

        private readonly IDataService _dataService;
        public StaffPermitProcess()
        {
            InitializeComponent();
        }
        private void LetterValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void PhoneNumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            //Regex regex = new Regex(" ^[1 - 9]\d{ 2} -\d{ 3} -\d{ 4}");
            Regex regex = new Regex("[^0-9,-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        //        async void GetAffidavitCostsDetails()
        //        { 
        //        string TotalFee = "0.00";
        //            //btnSubmit.IsEnabled = true;
        //            var affidavitCostsDetails = await _dataService.GetAffidavitCostDetails(txtAffidavit.ToString(), "R");
        //            List<sw_action_detail> filteredCostDetails = new List<sw_action_detail>();
        //        var rateList = await _dataService.GetRepairItemRate();
        //                    foreach (var item in affidavitCostsDetails)
        //                    {
        //                        try
        //                        {
        //                            if (item.action_type.Equals(Constants.RepairItem_Sidewalk))
        //                            {
        //                                TotalFee = (decimal.Parse(TotalFee) + (item.unit* rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Sidewalk)).FirstOrDefault().CurrentRate)).ToString();
        //        item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Sidewalk)).FirstOrDefault().CurrentRate;
        //                                item.cost = decimal.Parse((item.unit* item.rate).ToString("0.00"));
        //                                TotalFee = decimal.Parse(TotalFee).ToString("0.00");
        //        filteredCostDetails.Add(item);
        //                            }
        //                            else if (item.action_type.Equals(Constants.RepairItem_Driveway))
        //                            {

        //                                TotalFee = (decimal.Parse(TotalFee) + (item.unit* rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Driveway)).FirstOrDefault().CurrentRate)).ToString();
        //    item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Driveway)).FirstOrDefault().CurrentRate;
        //                                item.cost = decimal.Parse((item.unit* item.rate).ToString("0.00"));
        //                                TotalFee = decimal.Parse(TotalFee).ToString("0.00");
        //    filteredCostDetails.Add(item);
        //                            }
        //                            else if (item.action_type.Equals(Constants.RepairItem_Curb))
        //                            {
        //                                TotalFee = (decimal.Parse(TotalFee) + (item.unit* rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Curb)).FirstOrDefault().CurrentRate)).ToString();
        //item.rate = (decimal)rateList.Where(x => x.Action_Type.Equals(Constants.RepairItem_Curb)).FirstOrDefault().CurrentRate;
        //                                item.cost = decimal.Parse((item.unit* item.rate).ToString("0.00"));
        //                                TotalFee = decimal.Parse(TotalFee).ToString("0.00");
        //filteredCostDetails.Add(item);
        //                            }

        //                        }
        //                        catch (Exception)
        //                        {

        //                            throw;
        //                        }

        //                    }
        //            feeComputationGrid.ItemsSource = null;
        //            feeComputationGrid.ItemsSource = filteredCostDetails;
        //                    if (double.Parse(TotalFee) >= 500.00)
        //                        TotalFee = "500";
        //                    else if (double.Parse(TotalFee) <= 60.00)
        //                        TotalFee = "60";
        //            txtTotalFee.Text = double.Parse(TotalFee).ToString("0.00");

        //                    //txtPropertySearch.IsEnabled = false;
        //                }
    }
}
