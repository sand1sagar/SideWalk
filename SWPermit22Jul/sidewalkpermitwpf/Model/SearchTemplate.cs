using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SidewalkPermitWPF.Model
{
    public class SearchTemplate : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(
               object item,
               DependencyObject container)
        {
            Window wnd = Application.Current.MainWindow;
            if (item is string)
                return wnd.FindResource("WaitTemplate") as DataTemplate;
            else
                return wnd.FindResource("TheItemTemplate") as DataTemplate;
        }
    }
}
