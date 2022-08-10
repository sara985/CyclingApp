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
    /// Interaction logic for ConfirmBookingPage.xaml
    /// </summary>
    public partial class ConfirmBookingPage : Window
    {
        public ConfirmBookingPage()
        {
            InitializeComponent();
        }


        private void RdBtnNoCar_Checked_1(object sender, RoutedEventArgs e)
        {
            DataContext = new BookNoCarViewModel();
        }

        private void RdBtnBookCar_Checked(object sender, RoutedEventArgs e)
        {
            DataContext = new BookCarViewModel();
        }
    }
}
