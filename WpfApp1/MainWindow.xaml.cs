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
            btn_first.Content = "Changed";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn_first.Content = "See your name";
            MessageBox.Show("The button content was changed");
            Button second = new Button();
            second.Content = "second content";
            second.Width = 100;
            second.Height = 50;
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri(@"C:\Users\Sarah\Documents\GitHub\CyclingApp\WpfApp1\windows.png", UriKind.RelativeOrAbsolute));
            second.Background = brush;
            second.Click += new RoutedEventHandler(second_clicked);
            first_grid.Children.Add(second);
            string name = txt_first.Text;
            MessageBox.Show(name);
        }

        private void second_clicked(object sender, RoutedEventArgs e)
        {
            //Normally has to change the window title but I can't do it, code says : WinMain.Title = "new";
            WinMain.Title = "new";
            btn_first.Content = "it works !";
        }
    }
}