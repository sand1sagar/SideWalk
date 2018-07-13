using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WPF.MDI;

namespace SidewalkPermitWPF.Views
{
    /// <summary>
    /// Interaction logic for InitialStaffPermitSelection.xaml
    /// </summary>
    public partial class InitialStaffPermitSelection : UserControl
    {
        MainWindow mainWindow;
        MdiContainer _container;
        public InitialStaffPermitSelection(MdiContainer container)
        {
            InitializeComponent();
            mainWindow = new MainWindow();
            _container = container;
        }
        private void OnHyperlinkClick(object sender, RoutedEventArgs e)
        {
            var selectedItem = (PermitModel)SubmittedPermits.SelectedItem;
            mainWindow.processContractorPermits((PermitModel)SubmittedPermits.SelectedItem, _container);
            //if (selectedItem.Permit.PermitApplicant.ApplicantType == "Contractor")
            //{
            //    mainWindow.processContractorPermits((PermitModel)SubmittedPermits.SelectedItem, _container);
            //}
            //else
            //{
            //    mainWindow.processStaffPermits((PermitModel)SubmittedPermits.SelectedItem, _container);
            //}
        }
    }
}
