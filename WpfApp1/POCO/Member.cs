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
        private int position;
        private string email;
        private string phone;
        private string password;
        private float _balance;

        public Member()
        {
        }

        public Member(int id, string firstname, string lastname, int position, string email, string phone, string password, float balance)
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

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Position { get => position; set => position = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public float Balance { get => _balance; set => _balance = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
