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
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for TreasurerMainPage.xaml
    /// </summary>
    public partial class TreasurerMainPage : Window
    {
        public TreasurerMainPage()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you, have a nice day");
            App.Current.Shutdown();
        }

        private void btnInvoices_Click(object sender, RoutedEventArgs e)
        {
            //lblMainTreasur.Content = "List of Invoices";
            DataContext = new InvoiceViewModel();
        }
    }
}
