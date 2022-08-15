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
using WpfApp1.DAO;
using WpfApp1.POCO;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for NonAdminPage.xaml
    /// </summary>
    public partial class NonAdminPage : Window
    {

        public NonAdminPage()
        {

            InitializeComponent();
            //this.memberVM = (MemberViewModel)this.DataContext;
        }


        private void btnMemberOuting_Click(object sender, RoutedEventArgs e)
        {
            
            lblMainMember.Content = "list of incoming outings";
            DataContext = new MemberOutingViewModel();
            
        }


        private void btnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            lblMainMember.Content = "My Account";
            this.DataContext = new MemberViewModel();

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you, have a nice day");
            App.Current.Shutdown();
        }
    }
}
