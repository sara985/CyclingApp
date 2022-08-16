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
using WpfApp1.POCO;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for OutingList.xaml
    /// </summary>
    public partial class OutingList : UserControl
    {
        private int _memberId;

        public OutingList()
        {
            InitializeComponent();
        }

        public OutingList(int memberid)
        {
            InitializeComponent();
            MemberId = memberid;
        }

        public int MemberId { get => _memberId; set => _memberId = value; }

        private void btnSeeOuting_Click(object sender, RoutedEventArgs e)
        {
            OutingDetailMemberPage page = new OutingDetailMemberPage();
            page.DataContext = new OutingDetailViewModel((Outing)gridOuting.SelectedItem, Int32.Parse(txt_id.Text));
            page.ShowDialog();
        }
    }
}
