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
    /// Interaction logic for NonAdminPage.xaml
    /// </summary>
    public partial class NonAdminPage : Window
    {
        public NonAdminPage()
        {
            InitializeComponent();
        }

        private void btnMemberOuting_Click(object sender, RoutedEventArgs e)
        {
            lblMainMember.Content = "Check our the list of outings";
            DataContext = new MemberOutingViewModel();
        }
    }
}
