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
using System.Windows.Shapes;
using System.Deployment;
using System.Deployment.Application;
using System.Configuration;

namespace SidewalkPermitWPF.Views
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();

            Version appVersion;

            //if (ApplicationDeployment.IsNetworkDeployed)
            // Crashes in Developement as it is getting the Current deployed version 
            appVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            
            versionLabel.Text = appVersion.ToString();
            String env = ConfigurationManager.AppSettings["AppEnvironment"];
            if(env=="Testing")
            { 
            environmentLabel.Text = "TESTING Environment";
            }
        }
    }
}
