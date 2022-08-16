using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Interfaces
{
    internal interface InterfaceDAO<T>
    {
        void Insert(T t);

        void Update(T t);

        List<T> List();

        T GetById(int id);
    }
}
