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
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for BookNoCarView.xaml
    /// </summary>
    public partial class BookNoCarView : UserControl
    {
        public BookNoCarView(int outingid)
        {
            //DataContext = new OutingDetailViewModel(outingid);
            InitializeComponent();

        }

        public BookNoCarView()
        {
            InitializeComponent();
        }

        private void BtnConfirmNoCar_Click(object sender, RoutedEventArgs e)

        {
            MessageBox.Show("Succesfully booked to this Outing");
            var myWindow = Window.GetWindow(this);
            myWindow.Close();


        }

        private void comboListBike_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(DataContext.ToString());
        }
    }
}
