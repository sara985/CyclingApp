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

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for MyAccountView.xaml
    /// </summary>
    public partial class MyAccountView : UserControl
    {
        public MyAccountView()
        {
            InitializeComponent();
        }

        private void btnUpdateMyAccount_Click(object sender, RoutedEventArgs e)
        {
            EditMyAccountPage page = new EditMyAccountPage();
            page.ShowDialog();
        }
    }
}
