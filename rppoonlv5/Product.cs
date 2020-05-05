using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    class Product:IShipable
    {
        private double price;
        private double weight;
        private string description;

        public Product(double price, double weight, string description)
        {
            this.price = price;
            this.weight = weight;
            this.description = description;
        }

        public double Price { get { return this.price; } }
        public double Weight { get { return this.weight; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
    }
}
