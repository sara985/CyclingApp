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
    /// Interaction logic for BookCarView.xaml
    /// </summary>
    public partial class BookCarView : UserControl
    {
        public BookCarView()
        {
            InitializeComponent();
        }

        private void btnConfirmBookCar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Succesfully booked to this Outing");
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }
    }
}
