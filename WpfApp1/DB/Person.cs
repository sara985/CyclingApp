using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Person
    {
        public string Mail { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Pos { get; set; }
    }
}
