using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_2_MVVM_SampleClient.ViewModel;

namespace WpfApp_2_MVVM_SampleClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new MainWindow();
            MainWindowViewModel viewModel = new MainWindowViewModel();

            window.DataContext = viewModel;
            window.Show();


        }
    }

    
}
