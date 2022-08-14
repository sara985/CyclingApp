using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.POCO
{
    class Category
    {
        private int id;
        private string name;

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string? ToString()
        {
            return id + ". " + name;
        }
    }
}
