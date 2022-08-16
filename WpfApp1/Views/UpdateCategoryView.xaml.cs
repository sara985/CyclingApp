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
using WpfApp1.DAO;
using WpfApp1.POCO;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for UpdateCategoryView.xaml
    /// </summary>
    public partial class UpdateCategoryView : UserControl
    {
        public UpdateCategoryView()
        {
            InitializeComponent();
        }

        private void comboCatToAdd_Loaded(object sender, RoutedEventArgs e)
        {
            var vm = (MemberViewModel)this.DataContext;

            CategoryDAO catDAO = new CategoryDAO();
            List<Category> listAllCategories = catDAO.List();
            listAllCategories.RemoveAll(x => vm.Categories.Exists(match: y => y.Id == x.Id));
            comboCatToAdd.ItemsSource = listAllCategories;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //add selected item to viewModel
            var vm = (MemberViewModel)this.DataContext;
            Category c = (Category)comboCatToAdd.SelectedItem;
            MessageBox.Show(c.ToString());
            vm.Categories.Add(c);
            MessageBox.Show(vm.Categories.Count + " ");
            //MessageBox.Show(vm.Categories.Count + " count");


        }

        private void comboListCurentCat_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var vm = (MemberViewModel)this.DataContext;
            MessageBox.Show(vm.Categories.Count() + " count");
        }
    }
}
