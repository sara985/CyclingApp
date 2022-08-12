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

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for MgrOutingListView.xaml
    /// </summary>
    public partial class MgrOutingListView : UserControl
    {
        public MgrOutingListView()
        {
            InitializeComponent();
        }

        private void btnSeeOuting_Click(object sender, RoutedEventArgs e)
        {
            OutingDetailMemberPage page = new OutingDetailMemberPage();
            page.ShowDialog();
        }
    }
}
