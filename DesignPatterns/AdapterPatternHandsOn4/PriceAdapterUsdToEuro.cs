using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternHandsOn4
{
    class PriceAdapterUsdToEuro : PriceAdapter
    {
        private Price luxuryCars;
        public PriceAdapterUsdToEuro(Price price)
        {
            luxuryCars = price;
        }

        public double getPrice()
        {
            return convertUSDtoEURO(luxuryCars.getPrice());
        }
        private double convertUSDtoEURO(double usd) { return usd * 0.84; }
    }

}
