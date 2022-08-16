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
            EditBikeView editBikeView = new EditBikeView();
            editContentControl.Content = editBikeView;
        }

        private void btnMyCategory_Click(object sender, RoutedEventArgs e)
        {
            var vm = new MemberViewModel();
            var catUserControl = new UpdateCategoryView();
            editContentControl.Content = new UpdateCategoryView();

        }
    }
}
