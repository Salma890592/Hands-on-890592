using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDp_Hands_On3
{
    class Shop
    {
        public void Construct(PackageBuilder builder)
        {
            builder.BuildSweet();
            builder.BuildSavory();
        }
    }
}
