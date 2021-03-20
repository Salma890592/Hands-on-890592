using System;
using System.Collections.Generic;
using System.Text;
using static AbstractFactoryFinalCase.Program;
namespace AbstractFactoryFinalCase
{
    public interface RetailFactory
    {
        void MakeElectronics(Channel channel, ProductType product);
        void MakeToys(Channel channel, ProductType product);
        void MakeFurniture(Channel channel, ProductType product);

    }
}
