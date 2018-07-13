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
    /// Interaction logic for ApprovedPermitsView.xaml
    /// </summary>
    public partial class ApprovedPermitsView : UserControl
    {
        MainWindow mainWindow;
        MdiContainer _container;
        public ApprovedPermitsView(MdiContainer container)
        {
            InitializeComponent();
            mainWindow = new MainWindow();
            _container = container;
        }
       

        private void OnHyperlinkClickViewPermit(object sender, RoutedEventArgs e)
        {
            mainWindow.editSubmittedPermits((PermitModel)ApprovedPermits.SelectedItem, _container);
        }

        private void ApprovedPermits_Sorting(object sender, DataGridSortingEventArgs e)
        {

        }

        private void ApprovedPermits_Sorting_1(object sender, DataGridSortingEventArgs e)
        {

        }
    }
}
