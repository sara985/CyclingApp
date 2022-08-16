using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.POCO
{
    class Category : INotifyPropertyChanged
    {
        private int id;
        private string name;

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get => id;
            set { 
                id = value;
                OnPropertyChanged("Id");
                    }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string? ToString()
        {
            return id + ". " + name;
        }

        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
