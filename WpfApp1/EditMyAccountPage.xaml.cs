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
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for EditMyAccountPage.xaml
    /// </summary>
    public partial class EditMyAccountPage : Window
    {
        int id;

        public EditMyAccountPage(int id)
        {
            InitializeComponent();
            this.DataContext = new MemberViewModel(id);
        }

        private void btnSaveClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveChangesMyAccount_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Updated "+id);
        }

        private void btnMyBikes_Click(object sender, RoutedEventArgs e)
        {
            //editFrame.Source = new System.Uri("views/editbikeview.xaml",UriKind.RelativeOrAbsolute);
            EditBikeView editBikeView = new EditBikeView();
            editBikeView.DataContext = this.DataContext;
            editContentControl.Content = editBikeView;
        }

        private void btnMyCategory_Click(object sender, RoutedEventArgs e)
        {
            editFrame.Source = new System.Uri("views/updatecategoryview.xaml", UriKind.RelativeOrAbsolute);

        }

        private void editFrame_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            editFrame.DataContext = this.DataContext;
            MessageBox.Show(this.DataContext.ToString());
        }
    }
}
