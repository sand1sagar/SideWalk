//using GalaSoft.MvvmLight;
//using GalaSoft.MvvmLight.Ioc;
//using Microsoft.Practices.ServiceLocation;
//using SidewalkWPF.Model;

//namespace SidewalkWPF.ViewModel
//{
//    public class ViewModelLocator
//    {
//        static ViewModelLocator()
//        {
//            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

//            if (ViewModelBase.IsInDesignModeStatic)
//            {
//                SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
//            }
//            else
//            {
//                SimpleIoc.Default.Register<IDataService, DataService>();
//            }

//            SimpleIoc.Default.Register<MainViewModel>();
//        }

//        /// <summary>
//        /// Gets the Main property.
//        /// </summary>
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
//            "CA1822:MarkMembersAsStatic",
//            Justification = "This non-static member is needed for data binding purposes.")]
//        public MainViewModel Main
//        {
//            get
//            {
//                return ServiceLocator.Current.GetInstance<MainViewModel>();
//            }
//        }

//        /// <summary>
//        /// Cleans up all the resources.
//        /// </summary>
//        public static void Cleanup()
//        {
//        }
//    }
//}
