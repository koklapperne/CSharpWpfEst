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

namespace Production
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Constructor
        public MainWindow()
        {
            // 
            InitializeComponent();
            // Maximize the window
            WindowState = WindowState.Maximized;
        }

        private void MainDashBoard_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // 29-12-2023 10.11
            MessageBoxResult result = MessageBox.Show("Are you sure you want to close the Dashboard and close the application?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                // Cancel the closing operation
                e.Cancel = true;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }

        // 29-12-2023 10.11

    }
}
