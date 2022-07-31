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
using WpfApp1.DB;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for memberList.xaml
    /// </summary>
    public partial class memberList : UserControl
    {
        public memberList()
        {
            InitializeComponent();
            using(CYCLINGCLUBContext db=new CYCLINGCLUBContext())
            {
                List<Person> list = db.Persons.ToList();
                gridMember.ItemsSource = list;
            }
           
        }
    }
}
