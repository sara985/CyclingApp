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
    /// Interaction logic for MemberListView.xaml
    /// </summary>
    public partial class MemberListView : UserControl
    {
        public MemberListView()
        {
            InitializeComponent();
        }

        private void btnSeeMember_Click(object sender, RoutedEventArgs e)
        {
            DetailMemberMgrPage page = new DetailMemberMgrPage();
            page.ShowDialog();
        }
    }
}
