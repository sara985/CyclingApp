using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
