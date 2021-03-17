using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDP_Hands_On2.AbstractHeadLight;
using AbstractFactoryDP_Hands_On2.AbstractTire;

namespace AbstractFactoryDP_Hands_On2
{
    public class AudiFactory :AbstractFactory
    {
        public override IHeadLight makeHeadLight()
        {
            return new AudiHeadLight();
        }

        public override ITire makeTire()
        {
            return new AudiTire();
        }
    }
}
