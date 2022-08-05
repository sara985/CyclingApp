using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Member
    {
        public int Id { get; set; }
        public string Mail { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Pos { get; set; }
        public int Balance { get; set; }
    }
}
