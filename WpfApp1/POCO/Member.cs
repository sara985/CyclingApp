using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.POCO
{
    class Member : INotifyPropertyChanged
    {
        //TODO encrypt password
        private int id;
        private string firstname;
        private string lastname;
        private int position;
        private string email;
        private string phone;
        private string password;
        private decimal _balance;

        public Member()
        {
        }

        public Member(int id, string firstname, string lastname, int position, string email, string phone, string password, decimal balance)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.position = position;
            this.email = email;
            this.phone = phone;
            this.password = password;
            _balance = balance;
        }

        public Member(string email, string password)
        {
            this.email=email;
            this.password=password;
        }

        public int Id { get => id; set => id = value; 
        }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname
        {
            get { return lastname; }
            set { 
                lastname = value;
                OnPropertyChanged("Lastname");
            }
        }
        public int Position { get => position; set => position = value; }
        public string Email {
            get { return email; }                   
            set { 
                    email = value;
                     OnPropertyChanged("Email");
            }
        }
        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public decimal Balance { get => _balance; set => _balance = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string? ToString()
        {
            return base.ToString();
        }
        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
