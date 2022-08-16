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
using WpfApp1.DAO;
using WpfApp1.POCO;
using WpfApp1.ViewModels;
using WpfApp1.Views;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddNewOutingPage.xaml
    /// </summary>
    public partial class AddNewOutingPage : Window
    {
        public AddNewOutingPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveNewOuting_Click(object sender, RoutedEventArgs e)
        {
            if (txtStartingPoint.Text.Trim() == "" || PickerOutingDate.Text.Trim()=="" || txtCostOuting.Text.Trim()=="" || txtCatOuting.Text.Trim()=="")
            {
                MessageBox.Show("Please fill in the form correctly before saving");
            }
            else
            {
                //todo
                OutingDao outingDAO = new OutingDao();
                outingDAO.Insert(new Outing(txtStartingPoint.Text,Convert.ToDateTime(PickerOutingDate.Text),Convert.ToDecimal(txtCostOuting.Text),Convert.ToInt32(txtCatOuting.Text)));
                MessageBox.Show("succeed");
                txtStartingPoint.Clear();
                txtCostOuting.Clear();
                txtCatOuting.Clear();
            }
        }
    }
}
