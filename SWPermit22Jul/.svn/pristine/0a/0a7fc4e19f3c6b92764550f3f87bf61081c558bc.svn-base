using System.Windows;
using GalaSoft.MvvmLight.Threading;
using SidewalkPermitWPF.Model;
using System;

namespace SidewalkPermitWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IDataService _dataService = new DataService();
        static App()
        {
            DispatcherHelper.Initialize();
        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error : " + e.Exception.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            //ErrorLog log = new ErrorLog() { LogId=Guid.NewGuid(), Message=e.Exception.Message,StackTrace=e.Exception.StackTrace,CreatedDate=DateTime.UtcNow };
            ErrorLog log = new ErrorLog() { LogId = Guid.NewGuid(), Message = e.Exception.Message, StackTrace = e.Exception.StackTrace, CreatedDate = DateTime.Now };
            _dataService.InsertErrorLog(log);
            e.Handled = true;
        }
    }
}
