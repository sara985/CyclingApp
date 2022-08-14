using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.POCO
{
    internal class Outing
    {
        private int id;
        private DateTime outingdate;
        private double cost;
        private int category;

        public Outing() { }

        public Outing(int id, DateTime outingdate, double cost, int category)
        {
            this.id = id;
            this.outingdate = outingdate;
            this.cost = cost;
            this.category = category;
        }

        public int Id { get => id; set => id = value; }

        public DateTime Outingdate { get => outingdate; set => outingdate = value; }

        public double Cost { get => cost; set => cost = value; }   

        public int Category { get => category; set => category = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string? ToString()
        {
            return base.ToString();
        }
        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }

    }
}
