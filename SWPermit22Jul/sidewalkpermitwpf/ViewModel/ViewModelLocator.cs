/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:SidewalkPermitWPF.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SidewalkPermitWPF.Model;

namespace SidewalkPermitWPF.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        //private static MainViewModel _main;
        //public ViewModelLocator()
        //{
        //    _main = new MainViewModel();
        //}
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
               // SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
                SimpleIoc.Default.Register<IDataService, DataService>();
            }
            else
            {
                SimpleIoc.Default.Register<IDataService, DataService>();
            }
            SimpleIoc.Default.Register<MainWindow>();
            //SimpleIoc.Default.Register<MainViewModel>();
            //SimpleIoc.Default.Register<PermitViewModel>();
            SimpleIoc.Default.Register<InitialStaffPermitSelectionViewModel>();
        }

        public MainWindow Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainWindow>();
            }
        }

        //public InitialStaffPermitSelectionViewModel Main
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<InitialStaffPermitSelectionViewModel>();
        //    }
        //}

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}