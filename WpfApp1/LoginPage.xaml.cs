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
using WpfApp1.DAO;
using WpfApp1.POCO;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtEmail.Text.Trim()=="" || txtPassword.Text.Trim() =="")
            {
                MessageBox.Show("Please fill in your email and password");
            }
            else
            {    
                //OutingDao outDAO = new OutingDao();
                MemberDAO mem = new MemberDAO();
                Member m = mem.GetByLogin(txtEmail.Text, txtPassword.Text);
                MemberViewModel vm = new MemberViewModel(m.Id);
                //int i = outDAO.getRequestBikesPlacesByOutingId(1);
                //MessageBox.Show(i+" ");


                if (m != null)
                {
                    this.Visibility = Visibility.Collapsed;
                    if (m.Position == 1)
                    {
                        TreasurerMainPage treasurerMain = new TreasurerMainPage();
                        treasurerMain.ShowDialog();
                    }
                    else if (m.Position == 2)
                    {
                        MainWindow managermain = new MainWindow();
                        managermain.ShowDialog();
                    }
                    else {
                        NonAdminPage membermain = new NonAdminPage();
                        membermain.DataContext = vm;
                        //MessageBox.Show(vm.Outing.First().Startingpoint);
                        membermain.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect or you are not signed up.");
                }
            }            
        }

        private void btnSignupClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            SignupWindow signup = new SignupWindow();
            signup.DataContext = new MemberViewModel();
            signup.ShowDialog();
        }
    }
}
