using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP_Hands_On2.AbstractHeadLight
{
    public class MercedesHeadLight : IHeadLight
    {
        public void GetHeadLight()
        {
            Console.WriteLine("Mercedes HeadLight");
        }
    }
}
