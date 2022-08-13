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
                this.Visibility = Visibility.Collapsed;
                //NonAdminPage membermain = new NonAdminPage();
                //membermain.ShowDialog();
                MemberDAO mem = new MemberDAO();
                Member m = mem.GetByLogin(txtEmail.Text, txtPassword.Text);
                //MessageBox.Show(m.Firstname);
                //MainWindow managermain = new MainWindow();
                //managermain.ShowDialog();
                TreasurerMainPage treasurerMain = new TreasurerMainPage();
                treasurerMain.ShowDialog();

            }
            
        }

        private void btnSignupClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            SignupWindow signup = new SignupWindow();
            signup.ShowDialog();
        }
    }
}
