using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.Views;
using System.Windows.Input;
using WPF.MDI;
namespace SidewalkPermitWPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            
            PermitViewCommand = new RelayCommand(ExecutePermitViewCommand);
         
        }


        ///// <summary>
        ///// Simple property to hold the 'FirstViewCommand' - when executed
        ///// it will change the current view to the 'FirstView'
        ///// </summary>
        public ICommand PermitViewCommand { get; private set; }

   

        ///// <summary>
        ///// Set the CurrentViewModel to 'FirstViewModel'
        ///// </summary>
        private void ExecutePermitViewCommand()
        {
            //NewPermit newPermitView = new NewPermit();
            //newPermitView.DataContext = new NewPermitViewModel(_dataService);
            //newPermitView.ShowDialog();
            //MdiChild child = new MdiChild();
            //WindowContainer.Children.Add(new MdiChild()
            //MainMdiContainer.Children.Clear();
            //v.ShowDialog();
            //CurrentViewModel = _permitViewModel;
            //NavigationCommands cmd = new PermitView(); 
        }

    }
}