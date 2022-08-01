using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Person
    {
        public string Mail { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Pos { get; set; } = 0!;
        public string Address { get; set; } = null!;

    }
}
