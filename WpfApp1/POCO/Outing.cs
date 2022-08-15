using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.POCO
{
    class Outing : INotifyPropertyChanged
    {
        private int id;
        private DateTime outingdate;
        private String startingpoint;
        private decimal cost;
        private int category;

        public Outing() { }

        public Outing(int id, String startingpoint,DateTime outingdate, decimal cost, int category)
        {
            this.id = id;
            this.outingdate = outingdate;
            this.cost = cost;
            this.category = category;
            this.startingpoint = startingpoint;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Outingdate { get => outingdate; set => outingdate = value; }
        public decimal Cost { get => cost; set => cost = value; }   
        public int Category { get => category; set => category = value; }
        public string Startingpoint { get => startingpoint; set => startingpoint = value; }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        public override string? ToString()
        {
            return id + ". Date : " + outingdate + " cost : " + cost + " category : " + category + " starting point : " + startingpoint;
        }
        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
