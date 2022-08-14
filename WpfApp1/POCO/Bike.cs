using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.POCO
{
    class Bike
    {
        private int id;
        private float weight;
        private string type;
        private float length;

        public Bike()
        {
        }

        public Bike(int id, float weight, string type, float length)
        {
            this.id = id;
            this.weight = weight;
            this.type = type;
            this.length = length;
        }

        public int Id { get => id; set => id = value; }
        public float Weight { get => weight; set => weight = value; }
        public string Type { get => type; set => type = value; }
        public float Length { get => length; set => length = value; }

        public override string? ToString()
        {
            return weight+ " " + type + " " + length+" "+id;
        }
    }
}
