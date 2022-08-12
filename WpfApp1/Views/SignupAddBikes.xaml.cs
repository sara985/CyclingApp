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

namespace WpfApp1.Views
{
    /// <summary>
    /// Logique d'interaction pour SignupAddBikes.xaml
    /// </summary>
    public partial class SignupAddBikes : Page
    {
        public SignupAddBikes()
        {
            InitializeComponent();
        }
        private void btn_addBikeClick(object sender, RoutedEventArgs e)
        {
            myStackBike.Children.Add(new BikeUserControl());
        }

        private void btn_delBike_Click(object sender, RoutedEventArgs e)
        {
            int lastUIElement = myStackBike.Children.Count - 1;
            myStackBike.Children.RemoveAt(lastUIElement);
        }
    }
}
