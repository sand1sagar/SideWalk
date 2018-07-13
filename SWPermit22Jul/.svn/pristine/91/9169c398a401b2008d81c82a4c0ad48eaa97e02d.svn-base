using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.ViewModel;
using SidewalkPermitWPF.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
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

namespace SidewalkPermitWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataService _dataService;
        //MainMdiContainer
        public MainWindow()
        {
            //InitializeComponent();
            _dataService = new DataService();
            //String env = ConfigurationManager.AppSettings["AppEnvironment"];
            //if (env == "Testing")
            //    //environment.Header = "TESTING";
            //ChangeColorifTesting();
        }

        private void newPermit_Click(object sender, RoutedEventArgs e)
        {
            ChangeMenuColor(sender);
            DataService ser = new DataService();
            PermitView newPermitView = new PermitView(MainMdiContainer);
            //newPermitView.DataContext = new PermitViewModel(ser);
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = newPermitView
            });

        }
        //public void ChangeColorifTesting()
        //{
        //    MainMdiContainer.Background = new SolidColorBrush(Colors.Teal);
        //}
        public void ChangeMenuColor(object sender)
        {
            if (sender.ToString() != "WPF.MDI.MdiContainer")
            {


                MenuItem mnu = (MenuItem)sender;
                switch (mnu.Name)
                {
                    case "newPermit":
                        {
                            foreach (MenuItem item in menuList.Items)
                            {
                                if (mnu.Name != item.Name)
                                {
                                    item.Background = new SolidColorBrush(Colors.LightGray);
                                }
                                else
                                {
                                    item.Background = new SolidColorBrush(Colors.DarkGray);
                                }
                            }
                        }
                        break;
                    case "allPermits":
                        {
                            foreach (MenuItem item in menuList.Items)
                            {
                                if (mnu.Name != item.Name)
                                {
                                    item.Background = new SolidColorBrush(Colors.LightGray);
                                }
                                else
                                {
                                    item.Background = new SolidColorBrush(Colors.DarkGray);
                                }
                            }
                        }
                        break;

                    case "ApprovedPermits":
                        {
                            foreach (MenuItem item in menuList.Items)
                            {
                                if (mnu.Name != item.Name)
                                {
                                    item.Background = new SolidColorBrush(Colors.LightGray);
                                }
                                else
                                {
                                    item.Background = new SolidColorBrush(Colors.DarkGray);
                                }
                            }
                        }
                        break;

                    case "Settings":
                        {
                            foreach (MenuItem item in menuList.Items)
                            {
                                if (mnu.Name != item.Name)
                                {
                                    item.Background = new SolidColorBrush(Colors.LightGray);
                                }
                                else
                                {
                                    item.Background = new SolidColorBrush(Colors.DarkGray);
                                }
                            }
                        }
                        break;

                    //case "Alias":
                    //    {
                    //        foreach (MenuItem item in menuList.Items)
                    //        {
                    //            if (mnu.Name != item.Name)
                    //            {
                    //                item.Background = new SolidColorBrush(Colors.LightGray);
                    //            }
                    //            else
                    //            {
                    //                mnu.Background = new SolidColorBrush(Colors.DarkGray);
                    //            }
                    //        }
                    //    }
                    //    break;

                    //case "tabAbout":
                    //    {
                    //        foreach (MenuItem item in menuList.Items)
                    //        {
                    //            if (mnu.Name != item.Name)
                    //            {
                    //                item.Background = new SolidColorBrush(Colors.LightGray);
                    //            }
                    //            else
                    //            {
                    //                item.Background = new SolidColorBrush(Colors.DarkGray);
                    //            }
                    //        }
                    //    }
                    //    break;
                    default:
                        {
                         mnu.Background = new SolidColorBrush(Colors.LightGray);
                        }
                        break;
                }
            }
            //#FF000000
        }
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            ChangeMenuColor(sender);
        }

        private void allPermits_Click(object sender, RoutedEventArgs e)
        {
            ChangeMenuColor(sender);
            InitialStaffPermitSelection allPermits = new InitialStaffPermitSelection(MainMdiContainer);
            allPermits.DataContext = new InitialStaffPermitSelectionViewModel(_dataService);
            MainMdiContainer.Children.Clear();

            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = allPermits
            });
        }
        internal void newPermitOpen(MdiContainer container)
        {
            PermitView newPermit = new PermitView(container);
            container.Children.Clear();
            container.Children.Add(new MdiChild()
            {
                //Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = newPermit
            });
        }
        internal void allPermitsOpen(MdiContainer container)
        {
            InitialStaffPermitSelection allPermits = new InitialStaffPermitSelection(container);
            allPermits.DataContext = new InitialStaffPermitSelectionViewModel(_dataService);
            container.Children.Clear();
            container.Children.Add(new MdiChild()
            {
                //Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = allPermits
            });
        }

        internal void allPermitsApproved(MdiContainer container)
        {
            ApprovedPermitsView approvedPermits = new ApprovedPermitsView(container);
            approvedPermits.DataContext = new ApprovedPermitsViewModel(_dataService);
            container.Children.Clear();
            container.Children.Add(new MdiChild()
            {
                //Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = approvedPermits
            });
        }

        internal void processStaffPermits(PermitModel permitModel, MdiContainer container)
        {
            StaffPermitProcess permitProcessView = new StaffPermitProcess();
            permitProcessView.DataContext = new StaffPermitProcessViewModel(_dataService, permitModel, container);
            container.Children.Clear();
            container.Children.Add(new MdiChild()
            {
                Title = "Process Permits",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = permitProcessView
            });
        }

        internal void processContractorPermits(PermitModel permitModel, MdiContainer container)
        {
            ContractorPermitProcess contractorView = new ContractorPermitProcess();
            contractorView.DataContext = new ContractorPermitProcessViewModel(_dataService, permitModel, container);
            container.Children.Clear();
            container.Children.Add(new MdiChild()
            {
                Title = "Process Contractor Permits",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = contractorView
            });
        }

        internal void editSubmittedPermits(PermitModel permitModel, MdiContainer container)
        {
            ReviewModifyTransferPermit reviewPermitView = new ReviewModifyTransferPermit();
            reviewPermitView.DataContext = new ReviewModifyTransferPermitViewModel(_dataService, permitModel, container);
            container.Children.Clear();
            container.Children.Add(new MdiChild()
            {
                Title = "Update Permits",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = reviewPermitView
            });
        }

        private void ApprovedPermits_Click(object sender, RoutedEventArgs e)
        {
            ChangeMenuColor(sender);
            ApprovedPermitsView allPermits = new ApprovedPermitsView(MainMdiContainer);
            allPermits.DataContext = new ApprovedPermitsViewModel(_dataService);
            MainMdiContainer.Children.Clear();

            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = allPermits
            });
        }

        private void MainMdiContainer_Loaded(object sender, RoutedEventArgs e)
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["IsKiosk"].ToString()))
            {
                allPermits.Visibility = System.Windows.Visibility.Hidden;
                ApprovedPermits.Visibility = System.Windows.Visibility.Hidden;
            }
            newPermit_Click(sender, e);
        }

        private void tabAbout_Click(object sender, RoutedEventArgs e)
        {
            ChangeMenuColor(sender);
            About aboutDialog = new About();
            aboutDialog.Show();

        }

        private void ContractorAlias_Click(object sender, RoutedEventArgs e)
        {
            ChangeMenuColor(sender);
            DataService ser = new DataService();
            ContractorAlias contractorAlias = new ContractorAlias(MainMdiContainer);
            contractorAlias.DataContext = new ContractorAliasViewModel(ser,MainMdiContainer);
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = contractorAlias
            });
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PermitFee_Click(object sender, RoutedEventArgs e)
        {
            ChangeMenuColor(sender);
            DataService ser = new DataService();
            PermitFeeView permitFee = new PermitFeeView(MainMdiContainer);
            permitFee.DataContext = new PermitFeeViewModel(ser, MainMdiContainer);
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 15),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 15),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.

                Content = permitFee
            });
        }
    }
}

