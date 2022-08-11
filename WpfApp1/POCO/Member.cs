using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.POCO
{
    class Member
    {
        //TODO encrypt password
        private int id;
        private string firstname;
        private string lastname;
        private string type;
        private string email;
        private string phone;
        private string password;
        private float _balance;
        private List<Category> _categories;
        private List<Bike> bikes;
        private Vehicle vehicle;
    }
}
