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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for OutingDetailMemberPage.xaml
    /// </summary>
    public partial class OutingDetailMemberPage : Window
    {
        public OutingDetailMemberPage()
        {
            InitializeComponent();
        }

        private void btnCloseOuting_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBookOuting_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ConfirmBookingPage page = new ConfirmBookingPage();
            page.Show();

        }
    }
}
