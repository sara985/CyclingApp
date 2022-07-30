using System;
using System.Collections.Generic;

namespace WpfApp1.DB
{
    public partial class Member
    {
        public int Memberid { get; set; }
        public string Mail { get; set; } = null!;
        public int Balance { get; set; }
    }
}
