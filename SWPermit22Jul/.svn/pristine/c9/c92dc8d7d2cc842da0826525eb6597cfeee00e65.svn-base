using System;
using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Input;
using PDX.PBOT.SWPermit.Reporting;
using System.Collections.Generic;
using System.Threading;

namespace SidewalkPermitWPF.Views
{
    /// <summary>
    /// Description for NumberOfCopies.
    /// </summary>
    public partial class NumberOfCopies : Window
    {
        Dictionary<string, string> _permits = new Dictionary<string, string>();

        /// <summary>
        /// Initializes a new instance of the NumberOfCopies class.
        /// </summary>
        public NumberOfCopies(Dictionary<string, string> permits)
        {
            _permits = permits;
            InitializeComponent();
            //Thread.Sleep(12000);
        }
        public string ResponseText
        {
            get { return ResponseTextBox.Text; }
            set { ResponseTextBox.Text = value; }
        }
        private void btnOK_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ResponseTextBox.Text))
            {
                foreach (var item in _permits)
                {
                    switch (int.Parse(ResponseTextBox.Text))
                    {
                        case 0:
                            PermitReportFactory.Instance.ProcessRepairPermits(item.Key.ToString(), item.Value.ToString(), PermitPrint.Option.None);
                            break;
                        case 1:
                            PermitReportFactory.Instance.ProcessRepairPermits(item.Key.ToString(), item.Value.ToString(), PermitPrint.Option.DuplexedCustomerSet);
                            break;
                        case 2:
                            PermitReportFactory.Instance.ProcessRepairPermits(item.Key.ToString(), item.Value.ToString(), PermitPrint.Option.DuplexedFullSet);
                            break;
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter number of copies required.");
            }
            
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-2]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}


