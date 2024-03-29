﻿using System;
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
using WpfApp1.ViewModels;
using WpfApp1.DAO;
using WpfApp1.POCO;
using WpfApp1.ViewModels;
using WpfApp1.Views;

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

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you, have a nice day");
            App.Current.Shutdown();
        }

        private void btnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            lblMainMember.Content = "My Account";
            DataContext = new MyAccountViewModel();

        }

        private void btnMemberOuting_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MgrOutingListViewModel();
        }

        private void btnSeeMembers_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MemberListViewModel();
        }
    }
}