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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WinMain_Loaded(object sender, RoutedEventArgs e)
        {
            BtnLogin.Content = "Let's Login";
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            BtnLogin.Content = "Log out ";
            Button BtnContactAdmin = new Button();
            BtnContactAdmin.Content = "Contact Admin";
            BtnContactAdmin.Width = 200;
            BtnContactAdmin.Height = 60;
           
            BtnContactAdmin.Click += new RoutedEventHandler(BtnContactAdmin_clicked);
            FirstGrid.Children.Add(BtnContactAdmin);
        }

        private void BtnContactAdmin_clicked(object sender, RoutedEventArgs e)
        {
            WinMain.Title = "ClubMember HomePage";
        }

        private void BtnLogin_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}