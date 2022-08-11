using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Vehicle
    {
        public string Platenumber { get; set; } = null!;
        public int Passangerseat { get; set; }
        public int Extrabikespace { get; set; }
        public int Owner { get; set; }
    }
}
