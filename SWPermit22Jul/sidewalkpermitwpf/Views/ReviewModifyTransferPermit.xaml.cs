using SidewalkPermitWPF.Helper;
using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.MDI;

namespace SidewalkPermitWPF.Views
{
    /// <summary>
    /// Interaction logic for ReviewModifyTransferPermit.xaml
    /// </summary>
    public partial class ReviewModifyTransferPermit : UserControl
    {
        public ReviewModifyTransferPermit()
        {
            InitializeComponent();
            txtApplicantContact.IsEnabled = true;
            txtApplicantPhone.IsEnabled = true;
        }

        private void rdoContractor_Checked(object sender, RoutedEventArgs e)
        {
            txtContractorSearch.IsEnabled = true;
            txtCCBNumber.IsEnabled = false;
            txtApplicantName.IsEnabled = false;
            txtApplicantContact.IsEnabled = true;
            txtApplicantAddress.IsEnabled = false;
            txtApplicantCity.IsEnabled = false;
            txtApplicantState.IsEnabled = false;
            txtApplicantZip.IsEnabled = false;
            txtApplicantPhone.IsEnabled = true;

            txtApplicantName.Text = string.Empty;
            txtApplicantContact.Text = string.Empty;
            txtApplicantAddress.Text = string.Empty;
            txtApplicantCity.Text = string.Empty;
            txtApplicantState.Text = string.Empty;
            txtApplicantZip.Text = string.Empty;
            txtApplicantPhone.Text = string.Empty;
            //txtApplicantEmail.Text = string.Empty;
            txtCCBNumber.Text = string.Empty;
        }
        private void rdoOwner_Checked(object sender, RoutedEventArgs e)
        {
            txtContractorSearch.IsEnabled = false;
            txtCCBNumber.IsEnabled = false;
            txtApplicantName.IsEnabled = true;
            txtApplicantContact.IsEnabled = true;
            txtApplicantAddress.IsEnabled = true;
            txtApplicantCity.IsEnabled = true;
            txtApplicantState.IsEnabled = true;
            txtApplicantZip.IsEnabled = true;
            txtApplicantPhone.IsEnabled = true;

            txtApplicantName.Text = string.Empty;
            txtApplicantContact.Text = string.Empty;
            txtApplicantAddress.Text = string.Empty;
            txtApplicantCity.Text = string.Empty;
            txtApplicantState.Text = string.Empty;
            txtApplicantZip.Text = string.Empty;
            txtApplicantPhone.Text = string.Empty;
            //txtApplicantEmail.Text = string.Empty;
            txtCCBNumber.Text = string.Empty;
        }
        private void rdoOther_Checked(object sender, RoutedEventArgs e)
        {
            txtContractorSearch.IsEnabled = false;
            txtCCBNumber.IsEnabled = false;
            txtApplicantName.IsEnabled = true;
            txtApplicantContact.IsEnabled = true;
            txtApplicantAddress.IsEnabled = true;
            txtApplicantCity.IsEnabled = true;
            txtApplicantState.IsEnabled = true;
            txtApplicantZip.IsEnabled = true;
            txtApplicantPhone.IsEnabled = true;

            txtCCBNumber.Text = string.Empty;
            txtApplicantName.Text = string.Empty;
            txtApplicantContact.Text = string.Empty;
            txtApplicantAddress.Text = string.Empty;
            txtApplicantCity.Text = string.Empty;
            txtApplicantState.Text = string.Empty;
            txtApplicantZip.Text = string.Empty;
            txtApplicantPhone.Text = string.Empty;
            //txtApplicantEmail.Text = string.Empty;
            
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void txtContractorSearch_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtContractorSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void suggestionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtApplicantState_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void txtApplicantState_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
