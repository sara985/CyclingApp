using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Category
    {
        public int Idcategory { get; set; }
        public string Namecat { get; set; } = null!;
        public int Manager { get; set; }
    }
}
