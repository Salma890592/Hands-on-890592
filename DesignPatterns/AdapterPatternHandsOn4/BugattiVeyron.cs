using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternHandsOn4
{
    class BugattiVeyron : Movable, Price
    {
        public double getPrice()
        {
            return 2555;
        }

        public double getSpeed()
        {
            return 268;
        }
    }
}
