using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.DAO;
using WpfApp1.POCO;

namespace WpfApp1.Views
{
    /// <summary>
    /// Logique d'interaction pour Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btn_next_click(object sender, RoutedEventArgs e)
        {
            var vm = (ViewModels.MemberViewModel)this.DataContext;
            if(cb_cylco.IsChecked == true)
            {
                vm.Categories.Add(new Category(1, "cyclo"));
            }

            SignupAddVehicle signupAddVehicleFrame = new SignupAddVehicle();
            //signupAddVehicleFrame.DataContext = this.DataContext;
            //NavigationService.Navigate(signupAddVehicleFrame);
            NavigationService.Navigate(signupAddVehicleFrame);       
        }
    }
}
