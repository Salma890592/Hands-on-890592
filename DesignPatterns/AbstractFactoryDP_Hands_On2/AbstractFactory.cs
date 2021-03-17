using System;
using System.Collections.Generic;
using AbstractFactoryDP_Hands_On2.AbstractHeadLight;
using AbstractFactoryDP_Hands_On2.AbstractTire;

namespace AbstractFactoryDP_Hands_On2
{
    public abstract class AbstractFactory
    {
        public abstract IHeadLight makeHeadLight();
        public abstract ITire makeTire();
    }
}
