using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Outing
    {
        public int Idouting { get; set; }
        public string Startingpoint { get; set; } = null!;
        public DateTime Date { get; set; }
        public int Cost { get; set; }
        public int Category { get; set; }
    }
}
