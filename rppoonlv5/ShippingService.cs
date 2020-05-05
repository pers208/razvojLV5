using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    class ShippingService
    {
        private double pricePerKg;

        public ShippingService(double pricePerKg)
        {
            this.pricePerKg = pricePerKg;
        }
        public double Price(Box package)
        {
            return pricePerKg * package.Weight;
        }
    }
}
