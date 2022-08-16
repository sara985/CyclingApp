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
using WpfApp1.POCO;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ConfirmBookingPage.xaml
    /// </summary>
    public partial class ConfirmBookingPage : Window
    {
        public ConfirmBookingPage(int outingid, int memberid)
        {
            InitializeComponent();
            DataContext = new OutingDetailViewModel(outingid,memberid);
            OutingDetailViewModel vm = (OutingDetailViewModel)this.DataContext;
        }



        private void RdBtnNoCar_Checked_1(object sender, RoutedEventArgs e)
        {
            OutingDetailViewModel vm = (OutingDetailViewModel)this.DataContext;
            bookingControl.DataContext = vm;
            bookingControl.Content = new BookNoCarView();
        }

        private void RdBtnBookCar_Checked(object sender, RoutedEventArgs e)
        {
            //DataContext = new BookCarViewModel();
        }

        private void RdBtnOfferCar_Checked(object sender, RoutedEventArgs e)
        {
            //DataContext = new OfferPickupViewModel();
        }
    }
}
