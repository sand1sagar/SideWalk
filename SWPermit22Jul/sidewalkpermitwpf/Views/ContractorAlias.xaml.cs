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
    public partial class ContractorAlias : UserControl
    {

        private readonly IDataService _dataService;
        MainWindow mainWindow;
        MdiContainer _container;
        public ContractorAlias(MdiContainer container)
        {
            InitializeComponent();
            mainWindow = new MainWindow();
            _container = container;
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void LettersAndNumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z0-9 ]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
