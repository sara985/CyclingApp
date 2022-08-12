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
            MemberDAO memDAO = new MemberDAO();
            List<Member> list = memDAO.List();
            Member first = list[0];
            //Console.WriteLine(memDAO.List());
            MessageBox.Show(first.Firstname);
            //NavigationService.Navigate(new SignupAddVehicle());       
        }
    }
}
