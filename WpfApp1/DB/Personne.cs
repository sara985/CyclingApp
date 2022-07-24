using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Personne
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public int Job { get; set; }
    }
}
