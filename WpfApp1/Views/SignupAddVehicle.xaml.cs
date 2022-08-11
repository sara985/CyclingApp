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
    /// Logique d'interaction pour SignupAddVehicle.xaml
    /// </summary>
    public partial class SignupAddVehicle : Page
    {
        public SignupAddVehicle()
        {
            InitializeComponent();
        }

        public void btn_goToBikeClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignupAddBikes());
        }
    }
}
