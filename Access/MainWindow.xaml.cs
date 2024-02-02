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

namespace Access
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Constructor
        public MainWindow()
        {
            // 29-12-2023 10.10
            InitializeComponent();
        }

        // Eventhandlers

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            // 29-12-2023 11.36
            Production.MainWindow ActiveMainWindow;
            ActiveMainWindow = new Production.MainWindow();
            ActiveMainWindow.Show();
            // Hide MainWindow from Access Project
            Hide();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            // 29-12-2023 12.00
            MessageBoxResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
