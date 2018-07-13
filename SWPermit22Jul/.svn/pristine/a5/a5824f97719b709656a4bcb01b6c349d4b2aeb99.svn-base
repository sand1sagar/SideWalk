using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.ViewModel;
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

namespace SidewalkPermitWPF.Views
{
    /// <summary>
    /// Interaction logic for StaffPermitProcess.xaml
    /// </summary>
    public partial class ContractorPermitProcess : UserControl
    {
        ContractorPermitProcessViewModel vm;


        public ContractorPermitProcess()
        {
            vm = (ContractorPermitProcessViewModel)this.DataContext;
            InitializeComponent();
        }

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.RemovedItems.Count > 0)
            {
                var permitObj = (ContractorPermit)e.RemovedItems[0];
                txtTotalFee.Text = (decimal.Parse(txtTotalFee.Text) - decimal.Parse(permitObj.Fee)).ToString();
                //vm.TotalFee = (decimal.Parse(txtTotalFee.Text) - decimal.Parse(permitObj.Fee)).ToString();
            }
            if (e.AddedItems.Count > 0)
            {
                var permitObj = (ContractorPermit)e.AddedItems[0];
                txtTotalFee.Text = (decimal.Parse(txtTotalFee.Text) + decimal.Parse(permitObj.Fee)).ToString();
                //vm.TotalFee = (decimal.Parse(txtTotalFee.Text) + decimal.Parse(permitObj.Fee)).ToString();
            }
        }
        private void checkall_Unchecked(object sender, RoutedEventArgs e)
        {
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    ListViewItem lvi = (ListViewItem)listView1.ItemContainerGenerator.ContainerFromItem(listView1.Items[i]);
            //    if (lvi != null)
            //    {
            //        lvi.IsSelected = false;
            //        //CheckBox c = lvi.FindChildByType<CheckBox>();
            //        //c.IsChecked = false;
            //    }
            //}
        }

        private void checkall_Checked(object sender, RoutedEventArgs e)
        {
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    ListViewItem lvi = (ListViewItem)listView1.ItemContainerGenerator.ContainerFromItem(listView1.Items[i]);

            //    if (lvi != null)
            //    {
            //        lvi.IsSelected = true;
            //        //CheckBox c = lvi;
            //        //c.IsChecked = true;
            //    }
            //}
        }

        private void cbxAll_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox, sender as RowDefinition);
        }

        void Handle(CheckBox checkBox,RowDefinition row)
        {
            vm = (ContractorPermitProcessViewModel)this.DataContext;
            if(vm!=null)
                vm.UpdateFee(checkBox.Content.ToString(),checkBox.IsChecked.Value);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Handle(sender as CheckBox, sender as RowDefinition);
        }

    }
}
