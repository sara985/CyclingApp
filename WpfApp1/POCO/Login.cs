using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.POCO
{
    internal class Login : INotifyPropertyChanged
    {
        private string _email;
        private string _password;

        public Login()
        {
        }

        public Login(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public string Email { get { return _email; } set { _email = value;
                OnPropertyChanged("Email");
            } 
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(Password);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
