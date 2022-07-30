using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Bycicle
    {
        public int Idbycicle { get; set; }
        public int Column1 { get; set; }
        public string Type { get; set; } = null!;
        public int Length { get; set; }
        public string Owner { get; set; } = null!;
    }
}
