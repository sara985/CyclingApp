using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.POCO;

namespace WpfApp1.ViewModels
{
    internal class LoginViewModel
    {
        public LoginViewModel()
        {
        }

        public LoginViewModel(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public Member GetMember(string email, string password)
        {
            return null;
        }
    }
}
